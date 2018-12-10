using System.Collections.Generic;
using CaseStudyRM.Models;

namespace CaseStudyRM.ViewModels
{
    public class SearchQueryViewModel
    {
        public SearchQuery SearchQuery { get; set; }
        public List<SearchQuery> SearchQueries { get; set; }
    }
}