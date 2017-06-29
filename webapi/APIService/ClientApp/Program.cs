using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        private const string BooksUrl = "http://localhost:59977/api/Books";
        private static HttpClient s_client = new HttpClient();
        static void Main(string[] args)
        {
            Console.WriteLine("press return to start");
            Console.ReadLine();

            //AddBookAsync().Wait();
            //GetBooksAsync().Wait();

            GetBooksXmlAsync().Wait();
            GetBooksAsync().Wait();

            Console.WriteLine("press return to exit");
            Console.ReadLine();
        }

        private static async Task AddBookAsync()
        {
            Book b = new Book { Title = "Professional C# 7", Publisher = "Wrox Press" };
            string json = JsonConvert.SerializeObject(b);

            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage resp = await s_client.PostAsync(BooksUrl, content);
            resp.EnsureSuccessStatusCode();
            string jsonReturn = await resp.Content.ReadAsStringAsync();
            Book b2 = JsonConvert.DeserializeObject<Book>(jsonReturn);
        }

        private static async Task GetBooksAsync()
        {
            HttpResponseMessage resp = await s_client.GetAsync(BooksUrl);
            resp.EnsureSuccessStatusCode();

            string json = await resp.Content.ReadAsStringAsync();
            IEnumerable<Book> books = JsonConvert.DeserializeObject<IEnumerable<Book>>(json);
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }


        }

        private static async Task GetBooksXmlAsync()
        {
            var xmlHeader = new MediaTypeWithQualityHeaderValue("application/xml");
            s_client.DefaultRequestHeaders.Accept.Add(xmlHeader);
            HttpResponseMessage resp = await s_client.GetAsync(BooksUrl);
            resp.EnsureSuccessStatusCode();

            string xml = await resp.Content.ReadAsStringAsync();

            s_client.DefaultRequestHeaders.Accept.Remove(xmlHeader);
        }
    }
}
