using System;
using System.Collections.Generic;

namespace CaseStudyRM.Models
{
    public class SearchQuery
    {
        public string SearchTerm { get; set; }
        public int NumberOfClicks { get; set; }
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
            
            return baseURL + term + "&entity=" + entity + "&limit=" + limit;;
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

    public class Result
    {
        public string wrapperType { get; set; }
        public string kind { get; set; }
        public int artistId { get; set; }
        public int collectionId { get; set; }
        public int trackId { get; set; }
        public string artistName { get; set; }
        public string collectionName { get; set; }
        public string trackName { get; set; }
        public string collectionCensoredName { get; set; }
        public string trackCensoredName { get; set; }
        public string artistViewUrl { get; set; }
        public string collectionViewUrl { get; set; }
        public string trackViewUrl { get; set; }
        public string previewUrl { get; set; }
        public string artworkUrl30 { get; set; }
        public string artworkUrl60 { get; set; }
        public string artworkUrl100 { get; set; }
        public double collectionPrice { get; set; }
        public double trackPrice { get; set; }
        public DateTime releaseDate { get; set; }
        public string collectionExplicitness { get; set; }
        public string trackExplicitness { get; set; }
        public int discCount { get; set; }
        public int discNumber { get; set; }
        public int trackCount { get; set; }
        public int trackNumber { get; set; }
        public int trackTimeMillis { get; set; }
        public string country { get; set; }
        public string currency { get; set; }
        public string primaryGenreName { get; set; }
        public bool isStreamable { get; set; }
        public string contentAdvisoryRating { get; set; }
        public string collectionArtistName { get; set; }
    }

    public class RootObject
    {
        public int resultCount { get; set; }
        public List<Result> Results { get; set; }
    }
    
    
    public enum Media
    {
        All,
        Music,
        Movies,
        Podcasts,
        Audiobooks
    }
    
}