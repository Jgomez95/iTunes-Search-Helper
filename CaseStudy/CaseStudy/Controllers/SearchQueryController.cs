using CaseStudy.Models;
using CaseStudyRM.HelperClasses;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    public class SearchQueryController : Controller
    {
        // GET
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
            //var searchResults = ApiHelper.Search(searchQuery.MediaType, searchQuery.SearchTerm);
            //ViewData.Add("SearchResults",searchResults.Result);
            return View("Results", searchResults);
           
        }

        public IActionResult Results()
        {
            
            return View();
        }
        
        
        
    }
}