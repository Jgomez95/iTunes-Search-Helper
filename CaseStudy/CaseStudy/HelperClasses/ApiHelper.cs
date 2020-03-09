using System;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CaseStudy.Models;

namespace CaseStudyRM.HelperClasses
{
    public class ApiHelper
    {
        public async Task<List<Result>> Search (string searchTerm, string mediaType)
        {
            var searchResults = new RootObject();

            // ClientHandler for local testing. Only to avoid certificate errors
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var client = new HttpClient(clientHandler))
            {
                var searchURL = $"https://itunes.apple.com/search?term=" + URLBuilder(mediaType, searchTerm);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
                    HttpResponseMessage response = await client.GetAsync(searchURL);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Successful call to itunes api");

                        var objectToDeserialize = await response.Content.ReadAsStringAsync();

                        searchResults = JsonConvert.DeserializeObject<RootObject>(objectToDeserialize);
                    }

                }
                catch (ArgumentNullException e)
                {
                    throw new Exception(e.Message);
                }
                catch (HttpRequestException e)
                {
                    throw new Exception(e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            foreach (var entry in searchResults.Results)
            {
                entry.OriginalSearchName = searchTerm;
            }

            return searchResults.Results;
        }
    
        // Function to correctly format the url so the api can make the call
        public static string URLBuilder(string MT, string ST)
        {
            string mediaString = MT;
            string term = ST.ToLower();
            term = ST.Replace(" ", "+");
            string entity = toEntity(mediaString);
            // Limit to only 10 searches to minimize huge list
            string limit = "10";

            return $"{term}&entity={entity}&limit={limit}";
        }
        
        // Changes to the media type to the correct format for the entity
        public static string toEntity(string type)
        {
            switch (type)
            {
                case "Music":
                    return "musicTrack";
                case "Movie":
                    return "movie";
                case "Podcast":
                    return "podcast";
                case "Audiobook":
                    return "audiobook";
                default:
                    return "allTrack";
            }
        }

    }
    
    
}