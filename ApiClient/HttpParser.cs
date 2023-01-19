using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http;

namespace ApiClient
{
    public class ApiHelper
    {
        private static readonly string baseAddress = "https://api.thecatapi.com/v1/";
        public static string RequestListFromWebApi() //padarytas tiktai kad istestuoti parsinima
        {
            HttpClient ApiClientTest = new HttpClient();
            string jsonString = ApiClientTest.GetStringAsync(baseAddress + "breeds").Result;
            return jsonString;
        }
        public static List<CatModel> GetCats(string requestedData)
        {
            var cats = JsonSerializer.Deserialize<List<CatModel>>(requestedData);
            Console.WriteLine($"Request is made: Received {cats.Count} cat instances at " + DateTime.Now.ToString("h:mm:ss tt"));
            return cats;
        }

        public static List<ImageModel> GetRandomImage()
        {
            using (HttpClient ApiClient = new HttpClient())
            {

                string jsonString = ApiClient.GetStringAsync(baseAddress + "images/search").Result;
                var images = JsonSerializer.Deserialize<List<ImageModel>>(jsonString);
                Console.WriteLine($"Request is made: Received cat picture at " + DateTime.Now.ToString("h:mm:ss tt"));
                return images;
            }
        }

        public static List<ImageModel> GetBreedImage(string catId)
        {
            using (HttpClient ApiClient = new HttpClient())
            {
                string jsonString = ApiClient.GetStringAsync(baseAddress + "images/search?breed_ids = " + catId).Result;
                var imageById = JsonSerializer.Deserialize<List<ImageModel>>(jsonString);
                Console.WriteLine($"Request is made: Received cat picture by cat's breed at " + DateTime.Now.ToString("h:mm:ss tt"));
                return imageById;
            }
        }
    }
}
