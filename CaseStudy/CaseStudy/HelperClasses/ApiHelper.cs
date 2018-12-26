using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
<<<<<<< HEAD:CaseStudyRM/CaseStudyRM/HelperClasses/ApiHelper.cs
using CaseStudyRM.Models;
=======
using CaseStudy.Models;
>>>>>>> f7b79c46a0c5620f3da7d8851ab21f3824a4c974:CaseStudy/CaseStudy/HelperClasses/ApiHelper.cs
using Newtonsoft.Json;

namespace CaseStudyRM.HelperClasses
{
    public class ApiHelper
    {
<<<<<<< HEAD:CaseStudyRM/CaseStudyRM/HelperClasses/ApiHelper.cs
        internal async static Task<IEnumerable<Result>> Search (string searchT, string mediaT)
=======
        internal static async Task<IEnumerable<Result>> Search (string searchT, string mediaT)
>>>>>>> f7b79c46a0c5620f3da7d8851ab21f3824a4c974:CaseStudy/CaseStudy/HelperClasses/ApiHelper.cs
        {
            var searchResults = new RootObject();
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://itunes.apple.com/search?term=");
            
            var searchURL  = "https://itunes.apple.com/search?term=" + URLBuilder(mediaT, searchT);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(searchURL).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Successful call to itunes api");
                searchResults = JsonConvert.DeserializeObject<RootObject>(response.Content.ReadAsStringAsync().Result);
                
            }
            else
            {
                Console.WriteLine("Error in API call");
            }

            return searchResults.Results;
        }
    
        // Function to correctly format the url so the api can make the call
        public static string URLBuilder(string MT, string ST )
        {
            string mediaString = MT;
            string term = ST.ToLower();
            term = ST.Replace(" ", "+");
            string entity = toEntity(mediaString);
            // Limit to only 10 searches to minimize huge list
            string limit = "10";
            
            return term + "&entity=" + entity + "&limit=" + limit;;
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