using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for(int i = 0; i < 5; i++) 
            {
                Console.WriteLine("------------");
                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine($"Ron Swanson: {quote.Ron()}");
            }



            var client1 = new HttpClient();
            var key = "7df1d3eb764e5823d6a96ca295d7a31f";
            var city = "Charleston";

            var weatherURL = $"";
            var response = client1.GetStringAsync( weatherURL ).Result;


            JObject formattedResponse = JObject.Parse( response );
            var temp = formattedResponse.["list"][0]["main"]["temp"];
            Console.WriteLine(temp);
        }

        
    }
}
