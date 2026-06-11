using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ElBruno.LocalEmbeddings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;
using OllamaSharp;
using SemanticSearch.Models;
using System.Collections.Concurrent;
using System.Numerics.Tensors;

namespace SemanticSearch.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {
        //readonly IEmbeddingGenerator<string, Embedding<float>> Embedder;
        readonly static ConcurrentDictionary<string, Embedding<float>> cache = new(StringComparer.OrdinalIgnoreCase);
        static Task? _cacheInitTask;
        static IEmbeddingGenerator<string, Embedding<float>> Embedder;

        public SampleDataController() {
            //Embedder = new OllamaApiClient(new Uri("http://localhost:11434"), "nomic-embed-text");
        }

        public async Task FillCacheAsync(IEnumerable<string> words)
        {
            Embedder ??= await LocalEmbeddingGenerator.CreateAsync();

            try
            {
                var nonCachedWords = words.Where(x => !cache.ContainsKey(x)).ToArray();
                if (!nonCachedWords.Any())
                    return;
                var embeddings = await Embedder.GenerateAsync(nonCachedWords);
                foreach (var (word, embedding) in nonCachedWords.Zip(embeddings))
                {
                    cache[word] = embedding;
                }
            }
            catch
            {
            }
        }
        public float GetSimilarity(string text, string searchText)
        {
            var eFilter = cache[text];
            var eText = cache[searchText];
            var cosineSimilarity = TensorPrimitives.CosineSimilarity(eText.Vector.Span, eFilter.Vector.Span);
            return cosineSimilarity;
        }

        string GetItemDescription(DictionaryEntry item) => $"{item.Name} - {item.Description}";

        Task EnsureCacheFilledAsync()
        {
            return _cacheInitTask ??= FillCacheAsync(SampleData.DictionaryEntries.Select(GetItemDescription));
        }

        [HttpGet]
        public async Task<object> Get(string searchValue, DataSourceLoadOptions loadOptions) {
            await EnsureCacheFilledAsync();

            if (string.IsNullOrEmpty(searchValue))
            {
                return DataSourceLoader.Load(SampleData.DictionaryEntries, loadOptions);
            }

            loadOptions.Filter = null; // Ignore default filtering

            await FillCacheAsync([searchValue]);

            var result = SampleData.DictionaryEntries
                .Select(item => new
                {
                    Entry = item,
                    Similarity = GetSimilarity(GetItemDescription(item), searchValue)
                })
                .OrderByDescending(x => x.Similarity)
                .Where(x => x.Similarity > 0.31f)
                .Select(x => x.Entry);

            return DataSourceLoader.Load(result, loadOptions);
        }

    }
}