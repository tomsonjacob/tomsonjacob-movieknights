#pragma checksum "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2213f099a20a02867923b7ff9a4b9ae8325fe6e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MovieKnights.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(MovieKnights.Pages.Pages_Index), null)]
namespace MovieKnights.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\_ViewImports.cshtml"
using MovieKnights;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2213f099a20a02867923b7ff9a4b9ae8325fe6e5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b1d47184232139fb10d69d584b4824de4394c8e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Cast", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 57, true);
            WriteLiteral("\r\n<!-- Search Results -->\r\n<div id=\"searchResults\">\r\n    ");
            EndContext();
            BeginContext(83, 891, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2213f099a20a02867923b7ff9a4b9ae8325fe6e54487", async() => {
                BeginContext(147, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
         for(int i = 0; i < Model.posterPath.Count; i++)
        {
            if(Model.posterPath[i] != "")
            {
                if(Model.posterPath[i].Length > 4)
                {
                    string style = "background: url(https://image.tmdb.org/t/p/w500/" + @Model.posterPath[i] + ");";
                    style += " background-size: cover; background-position: center;";
                    style += " width: 18%; display: inline-block; margin: 1%;";
                    style += " border-radius: 16px; border: 2px solid #444;";
                    

#line default
#line hidden
                BeginContext(732, 19, true);
                WriteLiteral("<div name=\"movieID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 751, "\"", 771, 1);
#line 17 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
WriteAttributeValue("", 759, Model.id[i], 759, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 772, "\"", 786, 1);
#line 17 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
WriteAttributeValue("", 780, style, 780, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(787, 79, true);
                WriteLiteral(">\r\n                        <input class=\"thumbBtn\" type=\"submit\" name=\"movieID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 866, "\"", 886, 1);
#line 18 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
WriteAttributeValue("", 874, Model.id[i], 874, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(887, 31, true);
                WriteLiteral(">\r\n                    </div>\r\n");
                EndContext();
#line 20 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
                }
            }
        }

#line default
#line hidden
                BeginContext(963, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(974, 61, true);
            WriteLiteral("\r\n</div>\r\n\r\n<!-- Movie Details -->\r\n<div id=\"movieDetails\">\r\n");
            EndContext();
#line 28 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
     if(Model.description.Length > 300)
    {

#line default
#line hidden
            BeginContext(1083, 29, true);
            WriteLiteral("        <p class=\"movieDesc\">");
            EndContext();
            BeginContext(1113, 35, false);
#line 30 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
                        Write(Model.description.Substring(0, 297));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 9, true);
            WriteLiteral("...</p>\r\n");
            EndContext();
#line 31 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1181, 29, true);
            WriteLiteral("        <p class=\"movieDesc\">");
            EndContext();
            BeginContext(1211, 17, false);
#line 34 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
                        Write(Model.description);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 35 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1241, 79, true);
            WriteLiteral("</div>\r\n\r\n<!-- Video Output -->\r\n<div id=\"video\">\r\n    <div class=\"frameDiv\">\r\n");
            EndContext();
#line 41 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
         for(int i = 0; i < Model.VidClips.Count; i++)
        {
            

#line default
#line hidden
#line 43 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
             if(i < 4)
            {

#line default
#line hidden
            BeginContext(1426, 23, true);
            WriteLiteral("                <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1449, "\"", 1503, 2);
            WriteAttributeValue("", 1455, "https://www.youtube.com/embed/", 1455, 30, true);
#line 45 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
WriteAttributeValue("", 1485, Model.VidClips[i], 1485, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1504, 174, true);
            WriteLiteral("\r\n                    class=\"frame\" frameborder=\"3\" \r\n                    allow=\"autoplay; encrypted-media\"\r\n                    allowfullscreen>\r\n                </iframe>\r\n");
            EndContext();
#line 50 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
            }

#line default
#line hidden
#line 50 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1704, 63, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<!-- cast info -->\r\n<div id=\"cast\">\r\n    ");
            EndContext();
            BeginContext(1767, 914, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2213f099a20a02867923b7ff9a4b9ae8325fe6e512004", async() => {
                BeginContext(1811, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
         for(int i=0;i < Model.CastImages.Count; i++)
        {
            

#line default
#line hidden
#line 60 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
             if(i < 12)
            {
                

#line default
#line hidden
#line 62 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
                 if(Model.CastImages[i].Length > 4)
                {
                    string cID = Model.CastIDs[i];
                    string style ="background: url(https://image.tmdb.org/t/p/w500/" + @Model.CastImages[i] + ");";

                    style += "background-size: cover; background-position: center;";
                    style += "width: 175px; height: 175px; display: inline-block;";
                    

#line default
#line hidden
                BeginContext(2353, 18, true);
                WriteLiteral("<div name=\"castID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2371, "\"", 2383, 1);
#line 69 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
WriteAttributeValue("", 2379, cID, 2379, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2384, 16, true);
                WriteLiteral(" class=\"castPic\"");
                EndContext();
                BeginWriteAttribute("style", "\r\n                    style=\"", 2400, "\"", 2435, 1);
#line 70 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
WriteAttributeValue("", 2429, style, 2429, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2436, 73, true);
                WriteLiteral(">\r\n                    <input type=\"submit\" name=\"castID\" class=\"castBtn\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2509, "\"", 2521, 1);
#line 71 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
WriteAttributeValue("", 2517, cID, 2517, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2522, 103, true);
                WriteLiteral("\r\n                        style=\"min-width: 175px; min-height: 175px;\" />\r\n                    </div>\r\n");
                EndContext();
#line 74 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
                }

#line default
#line hidden
#line 74 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
                 
            }

#line default
#line hidden
#line 75 "c:\Users\tomso\Desktop\Trios\dotnetCore\MovieKnights\Pages\Index.cshtml"
             
        }

#line default
#line hidden
                BeginContext(2670, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591