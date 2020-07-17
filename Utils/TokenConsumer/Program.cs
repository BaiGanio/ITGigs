using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using Nito.AsyncEx;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TokenConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is basic demo for now!");
            AsyncContext.Run(() => DoJobAsync());
        }

        private static async Task DoJobAsync()
        {
            TokenResponse tr = await TakeBgFreeTokenAsync(); 
            if(tr.IsError)
            {
                Console.WriteLine(tr.Error);
            }
            else
            {
                Console.WriteLine(tr.Json);
            }
            Console.WriteLine("==================================================");
            await CallBgApi(tr);
        }

        private static async Task<TokenResponse> TakeBgFreeTokenAsync()
        {
            // Discover endpoints from metadata
            DiscoveryClient dc = new DiscoveryClient("https://ids4core20.azurewebsites.net/");
            //DiscoveryClient dc = new DiscoveryClient("http://localhost:5001/");
            DiscoveryResponse dr = await dc.GetAsync();
            if (dr.IsError)
            {
                Console.WriteLine(dr.Error);
                return null;
            }

            // Request token
            TokenClient tc = new TokenClient(dr.TokenEndpoint, "bgapi-free", "bgapi-free-seret");
            TokenResponse tr = await tc.RequestClientCredentialsAsync("scope.bgapi-free");
            return tr;
        }

        private static async Task CallBgApi(TokenResponse tokenResponse)
        {
            // call api
            var client = new HttpClient();
            client.SetBearerToken(tokenResponse.AccessToken);

            //var response = await client.GetAsync("http://localhost:64751/Free/Towns");
            //var response = await client.GetAsync("http://bgapi.azurewebsites.net/api/userservice");
            var response = await client.GetAsync("https://bgapi.azurewebsites.net/Free/Towns");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                try
                {
                    var content = await response.Content.ReadAsStringAsync();
                    // JObject obj = JsonConvert.DeserializeObject(content);
                    Console.WriteLine(JArray.Parse(content));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}