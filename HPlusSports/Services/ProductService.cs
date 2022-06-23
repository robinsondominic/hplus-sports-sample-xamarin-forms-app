using System;
using System.Collections.Generic;
using System.IO;

using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace HPlusSports.Services
{
	public static class ProductService
    {
        private const string WISHLIST_FILE = "wishlist.json";
		static HttpClient client;

        public static List<Product> WishList
        {
            get;
            set;
        }

        static ProductService()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("https://hplussport.com/api/");

		}

        public static async Task<List<Product>> GetProductsAsync()
		{
            var productsRaw = await client.GetStringAsync("products/");

            var serializer = new JsonSerializer();
            using(var tReader = new StringReader(productsRaw))
            {
                using(var jReader = new JsonTextReader(tReader))
                {
                    var products = serializer.Deserialize<List<Product>>(
                        jReader);

                    return products;
                }
            }
		}

        public static async Task SaveWishList()
        {
            if (WishList != null && WishList.Count > 0)
            {
                //Save Products to Wish List
            }
        }

        public static async Task LoadWishList()
        {
            //Load items from wish list
        }
    }
}
