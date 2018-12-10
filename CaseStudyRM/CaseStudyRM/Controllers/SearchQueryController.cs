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
    
        [HttpGet]
        public ActionResult Create()
        {
       
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(SearchQuery searchQuery)
        {
            if (!string.IsNullOrWhiteSpace(searchQuery.SearchTerm))
            {
                string url = searchQuery.urlBuilder(searchQuery.SearchTerm, searchQuery.MediaType);
                var client = new ApiHelper();
                var searchResults = ApiHelper.Search(searchQuery.SearchTerm ?? string.Empty);
                
               
                
            }
            return View();
        }

    }
}