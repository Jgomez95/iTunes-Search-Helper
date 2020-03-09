using System;
using System.Collections.Generic;

namespace CaseStudy.Models
{
    // Model for the user search
    public class SearchQuery
    {
        public string SearchTerm { get; set; }
        public string MediaType { get; set; }

        public SearchQuery()
        {
            SearchTerm = string.Empty;
        }

        // Creates the url to call on the itunes api
        public string urlBuilder()
        {
            string baseURL = "https://itunes.apple.com/search?term=";
            string mediaString = MediaType;
            string term = SearchTerm.Replace(" ", "+");
            string entity = changeToEntity(mediaString);
            string limit = "10";

            return baseURL + term + "&entity=" + entity + "&limit=" + limit; ;
        }

        // Based on what the user selects in the media type drop down list, this function
        // will change the type to the format that the url will accept
        public string changeToEntity(string type)
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