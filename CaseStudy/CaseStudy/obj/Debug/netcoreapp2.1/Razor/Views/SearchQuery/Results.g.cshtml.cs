#pragma checksum "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142f569b9a98a3fb413f32adf9bc4d041ecd6079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchQuery_Results), @"mvc.1.0.view", @"/Views/SearchQuery/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SearchQuery/Results.cshtml", typeof(AspNetCore.Views_SearchQuery_Results))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/_ViewImports.cshtml"
using CaseStudy;

#line default
#line hidden
#line 1 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
using CaseStudy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142f569b9a98a3fb413f32adf9bc4d041ecd6079", @"/Views/SearchQuery/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973beee1fe3009b6c0d4352098e7aadb4fc3bfbc", @"/Views/_ViewImports.cshtml")]
    public class Views_SearchQuery_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Threading.Tasks.Task<IEnumerable<Result>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
  
    ViewBag.Title = "title";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 937, true);
            WriteLiteral(@"
<h2>Search Results </h2>
<hr />

<div class=""col-8"">
    <div class=""row"">
        <div class=""table-responsive"">
            <table class=""table table-bordered table-condensed table-striped table-hover sortable"" data-toggle=""table"" data-pagination=""true"" data-search=""true"">
                <thead>
                <tr class=""secondary"">
                    <th class=""col-sm-2"" data-defaultsign=""AZ"">Artwork</th>
                    <th class=""col-sm-2"" data-sortable=""true"" data-field=""ArtistName"" data-defaultsign=""AZ"">Artist</th>
                    <th class=""col-sm-3"" data-sortable=""true"" data-field=""CollectionName"" data-defaultsign=""AZ"">Collection</th>
                    <th class=""col-sm-3"" data-sortable=""true"" data-field=""Track"" data-defaultsign=""AZ"">Track</th>
                    <th class=""col-sm-2"" data-sortable=""true"" data-field=""Kind"" data-defaultsign=""AZ"">Kind</th>
                </tr>
                </thead>
");
            EndContext();
#line 25 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
                 if (@Model.Result == null || @Model.Result.Count() == 0)
                {

#line default
#line hidden
            BeginContext(1190, 114, true);
            WriteLiteral("                    <tr>\n                        <td colspan=\"5\">No Records found.</td>\n                    </tr>\n");
            EndContext();
#line 30 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
                }
                else
                {
                    foreach (var item in @Model.Result.OrderBy(x => x.artistName))
                    {

#line default
#line hidden
            BeginContext(1466, 98, true);
            WriteLiteral("                        <tr>\n                            <td>\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1564, "\"", 1589, 1);
#line 37 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
WriteAttributeValue("", 1570, item.artworkUrl100, 1570, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1590, 102, true);
            WriteLiteral("/>\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1693, 15, false);
#line 40 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
                           Write(item.artistName);

#line default
#line hidden
            EndContext();
            BeginContext(1708, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1809, 19, false);
#line 43 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
                           Write(item.collectionName);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1929, 14, false);
#line 46 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
                           Write(item.trackName);

#line default
#line hidden
            EndContext();
            BeginContext(1943, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2044, 9, false);
#line 49 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
                           Write(item.kind);

#line default
#line hidden
            EndContext();
            BeginContext(2053, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 52 "/Users/Juan/RiderProjects/CaseStudyRM/CaseStudy/CaseStudy/Views/SearchQuery/Results.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2158, 53, true);
            WriteLiteral("            </table>\n        </div>\n    </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Threading.Tasks.Task<IEnumerable<Result>>> Html { get; private set; }
    }
}
#pragma warning restore 1591