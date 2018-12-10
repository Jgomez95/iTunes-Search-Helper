using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CaseStudyRM.Controllers;
using CaseStudyRM.Models;
using Newtonsoft.Json;

namespace CaseStudyRM.HelperClasses
{
    public class ApiHelper
    {
        internal async static Task<IEnumerable<SearchQuery>> Search (string URL)
        {
            var searchResults = new JSONSearchRoot();


            var client = new HttpClient();
            client.BaseAddress = new Uri("https://itunes.apple.com/search?term=");

            var searchURL = URL;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync(searchURL).Result;

            if (response.IsSuccessStatusCode)
            {
                searchResults = JsonConvert.DeserializeObject<JSONSearchRoot>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int) response.StatusCode, response.ReasonPhrase);
            }

            return searchResults.Results;
        }


    }
}