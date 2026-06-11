using ElBruno.LocalEmbeddings;
using Microsoft.Extensions.AI;
using OllamaSharp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddControllersWithViews()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

await using var embedder = await LocalEmbeddingGenerator.CreateAsync();

builder.Services.AddSingleton<IEmbeddingGenerator<string, Embedding<float>>>((provider) =>
{
    //return new OllamaApiClient(new Uri("http://localhost:11434"), "nomic-embed-text");
    return embedder;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
