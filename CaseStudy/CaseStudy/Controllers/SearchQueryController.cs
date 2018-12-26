using CaseStudy.Models;
using CaseStudyRM.HelperClasses;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    public class SearchQueryController : Controller
    {
        // GET SearchQuery/Search
        public IActionResult Search()
        {
            var searchG = new SearchQuery();
            return View(searchG);
        }
        
        [HttpPost]
        public IActionResult Search(SearchQuery searchQuery)
        {
            searchQuery.SearchTerm = Request.Form["SearchTerm"];
            searchQuery.MediaType = Request.Form["MediaType"];
            
            var api = new ApiHelper();
            var searchResults = ApiHelper.Search(searchQuery.SearchTerm, searchQuery.MediaType);
            return View("Results", searchResults);
           
        }

        // GET SearchQuery/Results
        // Only works properly when user has searched something
        public IActionResult Results()
        {
            
            return View();
        }
        
        
        
    }
}