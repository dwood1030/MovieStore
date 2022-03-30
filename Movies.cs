using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace MovieStoreApp
{
    internal class Movies
    {
        public string Title { get; set; }

        public string Quantity { get; set; }

        public Movies(string title, string quantity)
        {
            Title = title;
            Quantity = quantity;
        }

        static List<Movies> movieList = new List<Movies>();

        public static void ViewInventory()
        {
            string movieString = File.ReadAllText(@"movieList.json");
            var movie = JsonSerializer.Deserialize<List<Movies>>(movieString);

            Console.WriteLine(movieString);
        }
    }
}
