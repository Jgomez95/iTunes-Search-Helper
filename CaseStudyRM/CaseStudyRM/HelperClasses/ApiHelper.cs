using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CaseStudyRM.Models;
using Newtonsoft.Json;

namespace CaseStudyRM.HelperClasses
{
    public class ApiHelper
    {
        internal async static Task<IEnumerable<Result>> Search (string searchT, string mediaT)
        {
            var searchResults = new RootObject();
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://itunes.apple.com/search?term=");
            
            var searchURL  = "https://itunes.apple.com/search?term=" + URLBuilder(mediaT, searchT);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(searchURL).Result;

            if (response.IsSuccessStatusCode)
            {
                searchResults = JsonConvert.DeserializeObject<RootObject>(response.Content.ReadAsStringAsync().Result);
                
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return searchResults.Results;
        }
    
        public static string URLBuilder(string MT, string ST )
        {
            string mediaString = MT;
            string term = ST.ToLower();
            term = ST.Replace(" ", "+");
            string entity = toEntity(mediaString);
            string limit = "10";
            
            return term + "&entity=" + entity + "&limit=" + limit;;
        }
        
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