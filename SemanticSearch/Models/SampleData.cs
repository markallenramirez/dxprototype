using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticSearch.Models {
    static class SampleData {
        public static List<DictionaryEntry> DictionaryEntries = [
            new (1, "Car", "A vehicle with four wheels"),
            new (2, "Bus", "A large vehicle for transporting passengers"),
            new (3, "Tea", "A hot drink made from brewed leaves"),
            new (4, "Coffee", "A hot drink made from brewed beans"),
            new (5, "Computer", "An electronic device for processing data"),
            new (6, "Mouse", "An input device for controlling the cursor on the screen"),
            new (7, "Airplane", "An aircraft for transporting passengers and cargo"),
            new (8, "Table", "Furniture for working or dining"),
            new (9, "Chair", "A comfortable seat with armrests"),
            new (10, "Phone", "A device for voice and text communication"),
            new (11, "Book", "A printed publication with texts and illustrations"),
            new (12, "Pen", "A tool for writing with ink"),
            new (13, "Watch", "A device for measuring time"),
            new (14, "Television", "A device for watching videos and broadcasts"),
            new (15, "Camera", "A device for taking photographs"),
            new (16, "Bicycle", "A two-wheeled vehicle"),
            new (17, "Plate", "A dish for serving food"),
            new (18, "Cup", "A container for drinking hot beverages"),
            new (19, "Backpack", "A bag carried on the back"),
            new (20, "Calculator", "An electronic device for calculations"),
            new (21, "Tablet", "A mobile device with a touch screen"),
            new (22, "Keyboard", "An input device for typing text"),
            new (23, "Spoon", "A utensil for eating soups and cereals"),
            new (24, "Fork", "A utensil for picking up food"),
            new (25, "Knife", "A tool for cutting food"),
            new (26, "Lamp", "A lighting device"),
            new (27, "Wardrobe", "Furniture for storing clothes and things"),
            new (28, "Mirror", "An object for reflecting images"),
            new (29, "Microwave", "A device for quickly heating food"),
            new (30, "Refrigerator", "A device for keeping food at low temperatures"),
            new (31, "Vacuum Cleaner", "A device for cleaning dust and debris"),
            new (32, "Kettle", "A container for boiling water"),
            new (33, "Bottle", "A container for storing liquids"),
            new (34, "Glasses", "A device for correcting vision"),
            new (35, "Headphones", "A device for personal audio listening"),
            new (36, "Speaker", "A device for playing sound"),
            new (37, "Microphone", "A device for recording and transmitting sound"),
            new (38, "Mouse", "A small rodent"),
            new (39, "Power Bank", "A device for charging gadgets on the go"),
            new (40, "Monitor", "A screen for displaying information from a computer"),
            new (41, "Notebook", "A book of blank pages for writing notes"),
            new (42, "Pencil", "A tool for writing or drawing with graphite"),
            new (43, "Backpack", "A bag worn on the back for carrying items"),
            new (44, "Shoes", "Footwear for protection and comfort"),
            new (45, "Socks", "Garments worn on the feet"),
            new (46, "T-shirt", "A short-sleeved casual top"),
            new (47, "Jacket", "A garment for the upper body, typically having a front opening"),
            new (48, "Hat", "A head covering for warmth or fashion"),
            new (49, "Scarf", "A long piece of cloth worn around the neck"),
            new (50, "Gloves", "Hand coverings for warmth or protection"),
            new (51, "Umbrella", "A device for protection against rain or sun"),
            new (52, "Wallet", "A small case for holding money and personal items"),
            new (53, "Purse", "A handbag used by women to carry everyday items"),
            new (54, "Watch", "A timepiece worn on the wrist"),
            new (55, "Belt", "A strap worn around the waist"),
            new (56, "Ring", "A circular band worn on the finger"),
            new (57, "Necklace", "A piece of jewelry worn around the neck"),
            new (58, "Bracelet", "A piece of jewelry worn around the wrist"),
            new (59, "Earrings", "Jewelry worn on the earlobes"),
            new (60, "Sunglasses", "Eyewear for protection against sunlight"),
            new (61, "Notebook", "A portable computer"),
            new (62, "Printer", "A device that produces paper copies of documents"),
            new (63, "Router", "A device that forwards data packets between computer networks"),
            new (64, "Modem", "A device that modulates and demodulates signals for internet access"),
            new (65, "Smartphone", "A mobile phone with advanced features and computing capability"),
            new (66, "Blender", "An appliance for mixing or pureeing foods and liquids"),
            new (67, "Toaster", "A device for browning slices of bread"),
            new (68, "Oven", "An appliance for baking or roasting food"),
            new (69, "Stove", "An appliance for cooking food by direct heat"),
            new (70, "Dishwasher", "An appliance for cleaning dishes"),
            new (71, "Washing Machine", "An appliance for washing clothes"),
            new (72, "Dryer", "An appliance for drying clothes"),
            new (73, "Iron", "A device for smoothing wrinkles in fabric"),
            new (74, "Ironing Board", "A flat surface for ironing clothes"),
            new (75, "Broom", "A tool for sweeping floors"),
            new (76, "Dustpan", "A flat scoop for collecting dust and debris"),
            new (77, "Mop", "A tool for cleaning floors"),
            new (78, "Bucket", "A container for carrying liquids"),
            new (79, "Detergent", "A cleaning agent"),
            new (80, "Sponge", "A porous material for cleaning"),
            new (81, "Towel", "A piece of cloth for drying things"),
            new (82, "Toothbrush", "A brush for cleaning teeth"),
            new (83, "Toothpaste", "A paste for cleaning teeth"),
            new (84, "Shampoo", "A liquid for washing hair"),
            new (85, "Conditioner", "A product for making hair softer and more manageable"),
            new (86, "Soap", "A substance for washing and cleaning"),
            new (87, "Body Wash", "A liquid soap for cleaning the body"),
            new (88, "Lotion", "A cream for moisturizing skin"),
            new (89, "Deodorant", "A substance for preventing body odor"),
            new (90, "Perfume", "A fragrant liquid for applying to the body"),
            new (91, "Razor", "A tool for shaving hair"),
            new (92, "Shaving Cream", "A cream for softening hair before shaving"),
            new (93, "Hair Dryer", "A device for drying hair"),
            new (94, "Comb", "A tool for arranging hair"),
            new (95, "Hairbrush", "A brush for styling hair"),
            new (96, "Nail Clippers", "A tool for trimming nails"),
            new (97, "Nail File", "A tool for smoothing and shaping nails"),
            new (98, "Tweezers", "A tool for plucking hair or handling small objects"),
            new (99, "Scissors", "A tool for cutting"),
            new (100, "Band-Aid", "A small adhesive bandage for minor cuts and scrapes")
        ];

        public static List<SampleOrder> Orders = new List<SampleOrder>() {
            new SampleOrder {
                OrderID = 10248,
                OrderDate = new DateTime(1996, 7, 4),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10249,
                OrderDate = new DateTime(1996, 7, 5),
                ShipCountry = "Germany",
                ShipCity = "Münster",
                CustomerName = "Karin Josephs"
            },
            new SampleOrder {
                OrderID = 10250,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10251,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "France",
                ShipCity = "Lyon",
                CustomerName = "Mary Saveley"
            },
            new SampleOrder {
                OrderID = 10252,
                OrderDate = new DateTime(1996, 7, 9),
                ShipCountry = "Belgium",
                ShipCity = "Charleroi",
                CustomerName = "Pascale Cartrain"
            },
            new SampleOrder {
                OrderID = 10253,
                OrderDate = new DateTime(1996, 7, 10),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10254,
                OrderDate = new DateTime(1996, 7, 11),
                ShipCountry = "Switzerland",
                ShipCity = "Bern",
                CustomerName = "Yang Wang"
            },
            new SampleOrder {
                OrderID = 10255,
                OrderDate = new DateTime(1996, 7, 12),
                ShipCountry = "Switzerland",
                ShipCity = "Genève",
                CustomerName = "Michael Holz"
            },
            new SampleOrder {
                OrderID = 10256,
                OrderDate = new DateTime(1996, 7, 15),
                ShipCountry = "Brazil",
                ShipCity = "Resende",
                CustomerName = "Paula Parente"
            },
            new SampleOrder {
                OrderID = 10257,
                OrderDate = new DateTime(1996, 7, 16),
                ShipCountry = "Venezuela",
                ShipCity = "San Cristóbal",
                CustomerName = "Carlos Hernández"
            },
            new SampleOrder {
                OrderID = 10258,
                OrderDate = new DateTime(1996, 7, 17),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderID = 10259,
                OrderDate = new DateTime(1996, 7, 18),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Francisco Chang"
            },
            new SampleOrder {
                OrderID = 10260,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Germany",
                ShipCity = "Köln",
                CustomerName = "Henriette Pfalzheim"
            },
            new SampleOrder {
                OrderID = 10261,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderID = 10262,
                OrderDate = new DateTime(1996, 7, 22),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10263,
                OrderDate = new DateTime(1996, 7, 23),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderID = 10264,
                OrderDate = new DateTime(1996, 7, 24),
                ShipCountry = "Sweden",
                ShipCity = "Bräcke",
                CustomerName = "Maria Larsson"
            },
            new SampleOrder {
                OrderID = 10265,
                OrderDate = new DateTime(1996, 7, 25),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            },
            new SampleOrder {
                OrderID = 10266,
                OrderDate = new DateTime(1996, 7, 26),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderID = 10267,
                OrderDate = new DateTime(1996, 7, 29),
                ShipCountry = "Germany",
                ShipCity = "München",
                CustomerName = "Peter Franken"
            },
            new SampleOrder {
                OrderID = 10268,
                OrderDate = new DateTime(1996, 7, 30),
                ShipCountry = "Venezuela",
                ShipCity = "Caracas",
                CustomerName = "Manuel Pereira"
            },
            new SampleOrder {
                OrderID = 10269,
                OrderDate = new DateTime(1996, 7, 31),
                ShipCountry = "USA",
                ShipCity = "Seattle",
                CustomerName = "Karl Jablonski"
            },
            new SampleOrder {
                OrderID = 10270,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderID = 10271,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "USA",
                ShipCity = "Lander",
                CustomerName = "Art Braunschweiger"
            },
            new SampleOrder {
                OrderID = 10272,
                OrderDate = new DateTime(1996, 8, 2),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10273,
                OrderDate = new DateTime(1996, 8, 5),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10274,
                OrderDate = new DateTime(1996, 8, 6),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10275,
                OrderDate = new DateTime(1996, 8, 7),
                ShipCountry = "Italy",
                ShipCity = "Bergamo",
                CustomerName = "Giovanni Rovelli"
            },
            new SampleOrder {
                OrderID = 10276,
                OrderDate = new DateTime(1996, 8, 8),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderID = 10277,
                OrderDate = new DateTime(1996, 8, 9),
                ShipCountry = "Germany",
                ShipCity = "Leipzig",
                CustomerName = "Alexander Feuer"
            },
            new SampleOrder {
                OrderID = 10278,
                OrderDate = new DateTime(1996, 8, 12),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderID = 10279,
                OrderDate = new DateTime(1996, 8, 13),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderID = 10280,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderID = 10281,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderID = 10282,
                OrderDate = new DateTime(1996, 8, 15),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderID = 10283,
                OrderDate = new DateTime(1996, 8, 16),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderID = 10284,
                OrderDate = new DateTime(1996, 8, 19),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderID = 10285,
                OrderDate = new DateTime(1996, 8, 20),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10286,
                OrderDate = new DateTime(1996, 8, 21),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10287,
                OrderDate = new DateTime(1996, 8, 22),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Janete Limeira"
            },
            new SampleOrder {
                OrderID = 10288,
                OrderDate = new DateTime(1996, 8, 23),
                ShipCountry = "Italy",
                ShipCity = "Reggio Emilia",
                CustomerName = "Maurizio Moroni"
            },
            new SampleOrder {
                OrderID = 10289,
                OrderDate = new DateTime(1996, 8, 26),
                ShipCountry = "UK",
                ShipCity = "London",
                CustomerName = "Victoria Ashworth"
            },
            new SampleOrder {
                OrderID = 10290,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Pedro Afonso"
            },
            new SampleOrder {
                OrderID = 10291,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderID = 10292,
                OrderDate = new DateTime(1996, 8, 28),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Anabela Domingues"
            },
            new SampleOrder {
                OrderID = 10293,
                OrderDate = new DateTime(1996, 8, 29),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderID = 10294,
                OrderDate = new DateTime(1996, 8, 30),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10295,
                OrderDate = new DateTime(1996, 9, 2),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10296,
                OrderDate = new DateTime(1996, 9, 3),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderID = 10297,
                OrderDate = new DateTime(1996, 9, 4),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            }
        };
    }
}
