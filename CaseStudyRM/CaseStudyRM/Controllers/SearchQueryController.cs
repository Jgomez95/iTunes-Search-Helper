using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading.Tasks;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using CaseStudyRM.HelperClasses;
using CaseStudyRM.Models;
using Microsoft.Ajax.Utilities;

namespace CaseStudyRM.Controllers
{
    public class SearchQueryController : Controller
    {
        // GET: SearchQuery/Search
        
        public ActionResult Search()
        {
            var searcG = new SearchQuery();
            
            return View(searcG);
        }
    
        [HttpPost]
        public ActionResult Search(SearchQuery searchQuery)
        {
            searchQuery.SearchTerm = Request.Form["SearchTerm"];
            searchQuery.MediaType = Request.Form["MediaType"];
            
            var api = new ApiHelper();
            var searchResults = ApiHelper.Search("Kid Cudi", "Music");
            //var searchResults = ApiHelper.Search(searchQuery.MediaType, searchQuery.SearchTerm);
            //ViewData.Add("SearchResults",searchResults.Result);
            return View("Results", searchResults);
           
        }

        public ActionResult Results()
        {
            
            return View();
        }

    }
}