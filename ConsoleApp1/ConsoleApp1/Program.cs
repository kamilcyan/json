using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();

            var products = new List<Product>();

            product.Name = "Apple";
            product.Price = 3.99f;

            product1.Name = "Orange";
            product1.Price = 9.99f;

            product2.Name = "Banana";
            product2.Price = 0.99f;

            product3.Name = "Cherry";
            product3.Price = 1.99f;

            products.Add(product);
            string output = JsonConvert.SerializeObject(product);

            products.Add(product1);
            string output1 = JsonConvert.SerializeObject(product1);

            products.Add(product2);
            string output2 = JsonConvert.SerializeObject(product2);

            products.Add(product3);
            string output3 = JsonConvert.SerializeObject(product3);


            //{
            //  "Name": "Apple",
            //  "ExpiryDate": "2008-12-28T00:00:00",
            //  "Price": 3.99,
            //  "Sizes": [
            //    "Small",
            //    "Medium",
            //    "Large"
            //  ]
            //}

            //JsonSerializer serializer = new JsonSerializer();
            //serializer.Converters.Add(new JavaScriptDateTimeConverter());
            //serializer.NullValueHandling = NullValueHandling.Ignore;

            //using (StreamWriter sw = new StreamWriter(@"d:\json.txt"))
            //using (JsonWriter writer = new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(writer, product);
            //    Console.WriteLine(sw);

            //    // {"ExpiryDate":new Date(1230375600000),"Price":0}
            //}

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);

            //List<Product> deserializedProduct = JsonConvert.DeserializeObject<List<Product>>(output);

            Console.WriteLine(output);
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);

            Console.ReadLine();
        }
    }
}
