
using System.Collections.Generic;
using System.Web.UI.WebControls;
using WebGrease.Css.Ast.MediaQuery;

namespace CaseStudyRM.Models
{
    public class SearchQuery
    {
        public string SearchTerm { get; set; }
        public int NumberOfClicks { get; set; }
        public Media MediaType { get; set; }

        public SearchQuery()
        {
            
        }
        // Creates the url to call on the itunes api
        public string urlBuilder(string query, Media media)
        {
            string baseURL = "https://itunes.apple.com/search?term=";
            string mediaString = media.ToString();
            string term = query.Replace(" ", "+");
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
                    return "all";
            }
        }

    }

    public class JSONSearchRoot
    {
        public int ResultCount { get; set; }
        public List<SearchQuery> Results { get; set; }
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