using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
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
        public ActionResult Create(SearchQuery searchQuery)
        {
            return View();
        }
        
        

        
        
       
    }
}