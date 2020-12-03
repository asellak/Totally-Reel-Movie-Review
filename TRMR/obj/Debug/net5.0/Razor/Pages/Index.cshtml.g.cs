#pragma checksum "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1185a533499bc9bb6df4fb94a099394c3afd297d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TRMR.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace TRMR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1185a533499bc9bb6df4fb94a099394c3afd297d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d955fd7e8ecdc9278170b6dcb71143be6eee19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav class=""nav2"">
	<ul class=""list-unstyled components"">
		<li><a href=""/MovieList#Suspense"">Suspense </a></li>
		<li><a href=""/MovieList#RomCom"">RomCom</a></li>
		<li><a href=""/MovieList#Horror"">Horror</a></li>
		<li><a href=""/MovieList#Action"">Action</a></li>
		<li><a href=""/MovieList#SciFi"">SciFi</a></li>
		<li><a href=""/MovieList#Drama""> Drama </a></li>
		<li><a href=""/MovieList#Romance""> Romance </a></li>
		<li><a href=""/MovieList#Thriller""> Thriller </a></li>
		<li><a href=""/MovieList#Documentary""> Documentary </a></li>
		<li><a href=""/MovieList#Adventure"">Adventure</a></li>
		<li><a href=""/MovieList#Musical""> Musical</a></li>
		<li><a href=""/MovieList#Mystery""> Mystery </a></li>
		<li><a href=""/MovieList#Comedy"">Comedy</a></li>
		<li><a href=""/MovieList#Sport""> Sport</a></li>
		<li><a href=""/MovieList#ShortFilm""> Short Film </a></li>
	</ul>
</nav>

");
#nullable restore
#line 27 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
  
   var highestReviewed = new List<(string, string, int)>();
   var lolXDsoRandom = new List<(string, string, int)>();
   double avg = 0;
   double rating = 0;
   int nullcount = 0;
   int notSameMovies = 0;
   bool noReviews = true;
   foreach(var movie in Model.Movies)
   {
      foreach (var rev in Model.Reviews)
      {
         if(rev.Movie_Id == movie.Id)
         {
            if(rev.Rating != null)
            {
               Double.TryParse(rev.Rating, out rating);
               avg += rating;
               noReviews = false;
            }
            else
            {
               nullcount ++;
            }
         }
         else
            notSameMovies++;
      }
      if(Model.Reviews.Count() - nullcount - notSameMovies != 0)
         avg /= (Model.Reviews.Count() - nullcount - notSameMovies);
      else
         avg = 0;
      nullcount = 0;
      notSameMovies = 0;
      if(!noReviews)
         highestReviewed.Add((movie.Title, Math.Abs(avg).ToString(), movie.Id));
      lolXDsoRandom.Add((movie.Title, Math.Abs(avg).ToString(), movie.Id));
      avg = 0;
      noReviews = true;

   }
   highestReviewed = highestReviewed.OrderByDescending (t => t.Item2).ToList();
   lolXDsoRandom = lolXDsoRandom.OrderBy(a => Guid.NewGuid()).ToList();

   var mostReviewed = new List<(string, string, int)>();
   int reviewCount = 0;
   foreach(var movie in Model.Movies)
   {
      foreach (var rev in Model.Reviews)
      {
         if(rev.Movie_Id == movie.Id)
         {
            reviewCount++;
         }
      }
      mostReviewed.Add((movie.Title, reviewCount.ToString(), movie.Id));
      reviewCount = 0;
   }
   mostReviewed = mostReviewed.OrderByDescending (t => t.Item2).ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""Welcome"">
	<main role=""main"">
		<div class=""row"">
			<div class=""col "">
				<div class=""col title"">
					<h1>TOTALLY REEL </h1>
					<h2>MOVIE REVIEW</h2> </div>
               <div class=""row"">
                  <div class=""col"">
                     <div class=""swiper-container"">
                        <div class=""swiper-wrapper""> 
");
#nullable restore
#line 100 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                              int slideNum = 1; 
                              string slideNumString = null; 
                              string srcString = null; 
                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                            foreach (var movie in Model.Movies) { 
                              {slideNumString = slideNum.ToString(); 
                              srcString = @movie.Title + ".png"; }

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <div class=\"swiper-slide flip-card\">\r\n                                 <a");
            BeginWriteAttribute("href", " href=\"", 3619, "\"", 3652, 2);
            WriteAttributeValue("", 3626, "MovieTemplate?id=", 3626, 17, true);
#nullable restore
#line 108 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
WriteAttributeValue("", 3643, movie.Id, 3643, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"flip-card-inner\">\r\n                                       <div class=\"flip-card-front \"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1185a533499bc9bb6df4fb94a099394c3afd297d8314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3803, "~/images/", 3803, 9, true);
#nullable restore
#line 110 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
AddHtmlAttributeValue("", 3812, srcString, 3812, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3829, "slide", 3829, 5, true);
#nullable restore
#line 110 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
AddHtmlAttributeValue(" ", 3834, slideNumString, 3835, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n                                       <div class=\"flip-card-back\" style=\"margin:0 text-align: center;\">\r\n                                          <h3>");
#nullable restore
#line 112 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                         Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> <b>Age Rating:</b> ");
#nullable restore
#line 112 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                                                              Write(movie.Age_Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; &nbsp; &nbsp; <b>Genre:</b> ");
#nullable restore
#line 112 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                                                                                                                   Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                          <br>\r\n                                          <br>\r\n                                          <p>");
#nullable restore
#line 115 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                        Write(movie.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                       </div>\r\n                                    </div>\r\n                                 </a>\r\n                              </div> ");
#nullable restore
#line 119 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                     {slideNum++;} 
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           </div>
                        <div class=""swiper-button-prev""></div>
                        <div class=""swiper-button-next""></div>
                     </div>

					<div class=""row lists .col-container"">
							<div class=""col rank"">
								<h2> <div class=""ranking"">Top 10 Movies</div> </h2>
								<ul>
");
#nullable restore
#line 130 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                     for(int i = 0; i < 10 && i < highestReviewed.Count; i++)
                           			{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \t\t  <li><a");
            BeginWriteAttribute("href", " href = \"", 4978, "\"", 5029, 2);
            WriteAttributeValue("", 4987, "MovieTemplate?id=", 4987, 17, true);
#nullable restore
#line 132 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
WriteAttributeValue("", 5004, highestReviewed[i].Item3, 5004, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>");
#nullable restore
#line 132 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                                                                                Write(highestReviewed[i].Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" scores a ");
#nullable restore
#line 132 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                                                                                                                   Write(highestReviewed[i].Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" out of 10! </h3></a></li>\r\n");
#nullable restore
#line 133 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                           			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col rank\">\r\n\t\t\t\t\t\t\t\t<h2> <div class=\"ranking\">Featured Films</div> </h2>\r\n\t\t\t\t\t\t\t\t<ul>\r\n");
#nullable restore
#line 139 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                        for(int i = 0; i < 10; i++)
                           			{

#line default
#line hidden
#nullable disable
            WriteLiteral("                              \t\t\t<li><a");
            BeginWriteAttribute("href", " href = \"", 5425, "\"", 5474, 2);
            WriteAttributeValue("", 5434, "MovieTemplate?id=", 5434, 17, true);
#nullable restore
#line 141 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
WriteAttributeValue("", 5451, lolXDsoRandom[i].Item3, 5451, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>");
#nullable restore
#line 141 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                                                                                  Write(lolXDsoRandom[i].Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3></a></li>\r\n");
#nullable restore
#line 142 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                           			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col rank\">\r\n\t\t\t\t\t\t\t\t<h2><div class=\"Hottest Hits\">Fan Favorites</div></h2>\r\n\t\t\t\t\t\t\t\t<ul>\r\n");
#nullable restore
#line 148 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                     for(int i = 0; i < 10; i++)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href = \"", 5759, "\"", 5807, 2);
            WriteAttributeValue("", 5768, "MovieTemplate?id=", 5768, 17, true);
#nullable restore
#line 150 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
WriteAttributeValue("", 5785, mostReviewed[i].Item3, 5785, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>");
#nullable restore
#line 150 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                                                                               Write(mostReviewed[i].Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has ");
#nullable restore
#line 150 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
                                                                                                                          Write(mostReviewed[i].Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Reel Reviews!</h3></a></li>\r\n");
#nullable restore
#line 151 "/mnt/c/Users/MHOLCOMB/repos/blah/Totally-Reel-Movie-Review/TRMR/Pages/Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n             </div>\r\n\t\t   </div>\r\n\t   </main>\r\n\t</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
