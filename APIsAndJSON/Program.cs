using Newtonsoft.Json.Linq;





        HttpClient client = new HttpClient();
        
        for (int i = 1; i <= 5; i++)
        {
           string kanyeUrl = "https://api.kanye.rest/";

           string KanyeResponse = client.GetStringAsync(kanyeUrl).Result;

           JObject kanyeQuote = JObject.Parse(KanyeResponse);
            
            Console.WriteLine($"------------");
            Console.WriteLine($"Kanye:{kanyeQuote["quote"]}");
            Console.WriteLine($"------------");
        
            string ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronUrl).Result;

            var ronQuote = JArray.Parse(ronResponse);

            Console.WriteLine($"------------");
            Console.WriteLine($"Ron:{ronQuote[0]}");
            Console.WriteLine($"------------");

        }
   
