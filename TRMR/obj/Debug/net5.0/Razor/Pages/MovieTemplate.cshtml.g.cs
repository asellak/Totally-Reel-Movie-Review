#pragma checksum "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc6d874ea41c3b82b4b5047e744458d407015175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TRMR.Pages.Pages_MovieTemplate), @"mvc.1.0.razor-page", @"/Pages/MovieTemplate.cshtml")]
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
#line 1 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc6d874ea41c3b82b4b5047e744458d407015175", @"/Pages/MovieTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d955fd7e8ecdc9278170b6dcb71143be6eee19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MovieTemplate : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Movie_Poster_Pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Movie Poster Pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("266"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("in"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter your review..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("in2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("step", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("max", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter a rating 0-10..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("review"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_19 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_20 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
  
   ViewData["Title"] = Model.CurrentMovie.Title;
   string reelName = "";
   string userId = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 12 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
 if (SignInManager.IsSignedIn(User)){ 
   ApplicationUser appUser = await UserManager.GetUserAsync(User); 
   reelName = appUser.ReelName; 
   userId = appUser.Id;
   }

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
		<div id=""MovieDetails"">
			<main role=""main"" class=""pb-3"">
				<div class=""row content"">
					<div class=""col"">");
            WriteLiteral(" ");
#nullable restore
#line 40 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                        string link = @Model.CurrentMovie.Title + ".png";

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc6d874ea41c3b82b4b5047e744458d40701517512972", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1529, "~/images/", 1529, 9, true);
#nullable restore
#line 40 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
AddHtmlAttributeValue("", 1538, link, 1538, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t<h2>");
#nullable restore
#line 41 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                       Write(Model.CurrentMovie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\t\t\t\t\t\t<div class=\"MovieFactList\">\n\t\t\t\t\t\t\t<ul>\n\t\t\t\t\t\t\t\t<li>Movie Title: ");
#nullable restore
#line 44 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                            Write(Model.CurrentMovie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\t\t\t\t\t\t\t\t<li>Director: ");
#nullable restore
#line 45 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                         Write(Model.CurrentMovie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\t\t\t\t\t\t\t\t<li>Starring: ");
#nullable restore
#line 46 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                         Write(Model.CurrentMovie.Starring);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\t\t\t\t\t\t\t\t<li>Genre: ");
#nullable restore
#line 47 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                      Write(Model.CurrentMovie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\t\t\t\t\t\t\t\t<li>Age Rating: ");
#nullable restore
#line 48 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                           Write(Model.CurrentMovie.Age_Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\t\t\t\t\t\t\t\t<li>Cast</li>\n\t\t\t\t\t\t\t\t<ul>");
#nullable restore
#line 50 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                      foreach (var actor in Model.CurrentMovie.Cast) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li>");
#nullable restore
#line 51 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                   Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> ");
#nullable restore
#line 51 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </ul>\n\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t<h2>Movie Description</h2>\n\t\t\t\t\t\t<p>");
#nullable restore
#line 55 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                      Write(Model.CurrentMovie.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t<div class=\"reviewList\">\n\t\t\t\t\t\t\t<h2>Reel Reviews</h2> ");
#nullable restore
#line 57 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                   if(Model.Reviews.Count() == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<p>Don\'t be shy... be the first to write a reel review!</p> ");
#nullable restore
#line 58 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<ul class=\"list-unstyled\"> ");
#nullable restore
#line 59 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                        foreach (var rev in Model.Reviews) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"media\">\n\t\t\t\t\t\t\t\t\t<div class=\"media-body\">\n\t\t\t\t\t\t\t\t\t\t<h5 class=\"mt-0 mb-1\">User <a");
            BeginWriteAttribute("href", " href=\"", 2532, "\"", 2570, 2);
            WriteAttributeValue("", 2539, "Profile?userName=", 2539, 17, true);
#nullable restore
#line 62 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
WriteAttributeValue("", 2556, rev.User_Name, 2556, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                                                        Write(rev.User_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> <i>gives ");
#nullable restore
#line 62 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                                                                                    Write(Model.CurrentMovie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" a ");
#nullable restore
#line 62 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                                                                                                                Write(rev.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /10 </i> </h5>\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-10\" style=\"background-color: white;\">\n\t\t\t\t\t\t\t\t\t\t\t<p style=\"margin-left:15px;\"> ");
#nullable restore
#line 64 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                     Write(rev.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t</li>");
#nullable restore
#line 67 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </ul>\n\t\t\t\t\t\t\t<h3 style=\"background-color: #3D7070;\"> Share Your Reel Review</h3> \n");
#nullable restore
#line 69 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                      if (SignInManager.IsSignedIn(User)){ //for testing you can just replace the conditional with "true" to see the page as if you were a signed in user 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc6d874ea41c3b82b4b5047e744458d40701517521731", async() => {
                WriteLiteral("\n                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc6d874ea41c3b82b4b5047e744458d40701517522013", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 71 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TheReview.User_Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                         WriteLiteral(reelName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc6d874ea41c3b82b4b5047e744458d40701517524441", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 72 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TheReview.Movie_Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                        WriteLiteral(Model.CurrentMovie.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                           <div class=\"form-group row\">\n                              <label class=\"col-sm-2 col-form-label\"> Leave a Reel Review!</label>\n                              <div class=\"col-sm-6\">\n                                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc6d874ea41c3b82b4b5047e744458d40701517527103", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 76 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TheReview.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" </div> <small class=""form-text text-muted"">All reviews will be monitored for ...? Please make sure to follow the rules in link</small> </div>
                           <div class=""form-group row"">
                              <label class=""col-sm-2 col-form-label"">And a rating</label>
                              <div class=""col-sm-5"">
                                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc6d874ea41c3b82b4b5047e744458d40701517529439", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#nullable restore
#line 80 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TheReview.Rating);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" </div>
                              <div class=""col-sm-5"">
                                 <button AutoPostBack=""true"" type=""submit"" value=""MovieTemplate"" class=""btn btn-primary"">Submit</button>
                              </div>
                           </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_18.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_18);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/MovieTemplate?id=");
#nullable restore
#line 70 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                                             WriteLiteral(Model.CurrentMovie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/MovieTemplate?id=");
#nullable restore
#line 70 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                                                                                                                                                             WriteLiteral(Model.CurrentMovie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n");
#nullable restore
#line 86 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                     } 
                     else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc6d874ea41c3b82b4b5047e744458d40701517535614", async() => {
                WriteLiteral("Login To Post Your Reel Review!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_19);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_18.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_18);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_20.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_20);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n");
#nullable restore
#line 89 "/Users/assyasellak/final/Totally-Reel-Movie-Review/TRMR/Pages/MovieTemplate.cshtml"
                     } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</main>\n\t\t</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TRMR.Pages.MovieTemplateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TRMR.Pages.MovieTemplateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TRMR.Pages.MovieTemplateModel>)PageContext?.ViewData;
        public TRMR.Pages.MovieTemplateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
