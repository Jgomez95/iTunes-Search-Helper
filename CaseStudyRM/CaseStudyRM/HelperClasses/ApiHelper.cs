using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using CaseStudyRM.Controllers;
using CaseStudyRM.Models;
using Newtonsoft.Json;

namespace CaseStudyRM.HelperClasses
{
    public class ApiHelper
    {
        public static async Task<List<Result>> Search (string searchT, string mediaT)
        {
            var searchResults = new RootObject();


            using (var client = new HttpClient())
            {
                //string baseAddress = "https://itunes.apple.com/search?term=";
                //string restOfAddress = URLBuilder(mediaT, searchT);
                //client.BaseAddress = new Uri("https://itunes.apple.com/search?term=");
    
                string searchURL = "https://itunes.apple.com/search?term=" + URLBuilder(mediaT, searchT);

                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(searchURL);
                //HttpResponseMessage response = client.GetAsync(searchURL).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Successful API Call");
                    string result = await response.Content.ReadAsStringAsync();
                    searchResults = JsonConvert.DeserializeObject<RootObject>(result);
                    return searchResults.Results;
                }
                else
                {
                    return null;
                    //Console.WriteLine("{0} ({1})", (int) response.StatusCode, response.ReasonPhrase);
                }
            }

            //return searchResults.Results;
        }
    
        public static string URLBuilder(string MT, string ST )
        {
            string mediaString = MT;
            ST.ToLower();
            string term = ST.Replace(" ", "+");
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