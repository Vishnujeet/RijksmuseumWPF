using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using RM.Common;
using Newtonsoft.Json;
using Polly;
using Polly.Retry;

namespace RM.Service
{
    public class RMService : IRMService
    {
        private int maxRetryAttempts = 3;
        private TimeSpan pauseBetweenFailures = TimeSpan.FromSeconds(2);
        private readonly AsyncRetryPolicy<Root> retryPolicy;
        private HttpClient client;

        public RMService()
        {
            retryPolicy = Policy<Root>.Handle<HttpRequestException>().RetryAsync(maxRetryAttempts);
            client = new HttpClient();
        }

        public async Task<Root> GetAllArtObject()
        {
            try
            {
                var dataPath = Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location);
                var fileLocation = dataPath + "\\jsonData.json";

                if (!File.Exists(fileLocation))
                    return await retryPolicy.ExecuteAsync(async () =>
                    {
                        var response =
                            await client.GetAsync(
                                $"https://www.rijksmuseum.nl/api/nl/collection?key=3GW9HXmd&p=5&ps=50");
                        if (response.StatusCode == HttpStatusCode.NotFound) return null;
                        var content = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<Root>(content);
                        using var file = File.CreateText(fileLocation);
                        var serializer = new JsonSerializer();
                        serializer.Serialize(file, data);
                        return data;
                    });

                var localData = File.ReadAllText(fileLocation);
                return JsonConvert.DeserializeObject<Root>(localData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<SingleArt> GetArtObjectDetails(string id)
        {
            try
            {
                var response =
                    await client.GetAsync($"https://www.rijksmuseum.nl/api/nl/collection/{id}?key=3GW9HXmd");
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SingleArt>(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}