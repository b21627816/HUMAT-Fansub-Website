#pragma checksum "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f31d38f56353ff2f03b689fbf1a26028b93c97eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manga_Details), @"mvc.1.0.view", @"/Views/Manga/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manga/Details.cshtml", typeof(AspNetCore.Views_Manga_Details))]
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
#line 1 "D:\Staj\StajBlogSolution\StajBlogProject\Views\_ViewImports.cshtml"
using StajBlogProject.Models;

#line default
#line hidden
#line 2 "D:\Staj\StajBlogSolution\StajBlogProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "D:\Staj\StajBlogSolution\StajBlogProject\Views\_ViewImports.cshtml"
using StajBlogProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31d38f56353ff2f03b689fbf1a26028b93c97eb", @"/Views/Manga/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a88f05cba530ddfcf618983dc0b78a5f0961deb", @"/Views/_ViewImports.cshtml")]
    public class Views_Manga_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manga>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manga", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Chapter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: left; word-wrap: break-word;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
  
    ViewBag.Title = "HÜMAT - " + Model.Title;

#line default
#line hidden
            BeginContext(109, 298, true);
            WriteLiteral(@"<div class=""content"">
    <div class=""container"">
        <div class=""box"">
            <div class=""blog-entry"">
                <div class=""entry-header"">
                    <div class=""position-text"">
                        <i class=""fa fa-video-camera""></i>
                        <h2>");
            EndContext();
            BeginContext(408, 11, false);
#line 15 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(419, 37, true);
            WriteLiteral("</h2>\r\n                        <span>");
            EndContext();
            BeginContext(457, 16, false);
#line 16 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                         Write(Model.UploadDate);

#line default
#line hidden
            EndContext();
            BeginContext(473, 86, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"text-center\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 559, "\"", 580, 1);
#line 18 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
WriteAttributeValue("", 565, Model.ImageUrl, 565, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(581, 171, true);
            WriteLiteral(" height=\"720\"></div>\r\n\r\n                </div>\r\n                <div class=\"entry-content\" style=\"word-wrap: break-word;\">\r\n                    <p style=\"font-size: 24px\">");
            EndContext();
            BeginContext(753, 13, false);
#line 22 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                                          Write(Model.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(766, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 23 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                     if (Repository.GetAllChapters(Model.Id).Count() > 0)
                    {

#line default
#line hidden
            BeginContext(870, 112, true);
            WriteLiteral("                        <h2>Bölümler</h2>\r\n                        <div class=\"list-group\" style=\"width: 60%\">\r\n");
            EndContext();
#line 27 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                             foreach (var item in Repository.GetAllChapters(Model.Id).OrderBy(s => s.ChapterNo))
                            {

#line default
#line hidden
            BeginContext(1127, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1159, 353, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f31d38f56353ff2f03b689fbf1a26028b93c97eb7791", async() => {
                BeginContext(1475, 14, false);
#line 33 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                                                                               Write(item.ChapterNo);

#line default
#line hidden
                EndContext();
                BeginContext(1489, 8, true);
                WriteLiteral(". Bölüm ");
                EndContext();
                BeginContext(1498, 10, false);
#line 33 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                                                                                                      Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1512, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(1545, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 36 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(1600, 507, true);
            WriteLiteral(@"
                </div>

            </div>
            <div id=""disqus_thread""></div>

        </div>
    </div>
</div>

<script>

    /**
*  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
*  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables*/

    var disqus_config = function () {
        this.page.url = ""http://localhost:56882/Manga/Details/""+");
            EndContext();
            BeginContext(2108, 8, false);
#line 54 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                                                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2116, 106, true);
            WriteLiteral(";  // Replace PAGE_URL with your page\'s canonical URL variable\r\n        this.page.identifier = \"Manga - \"+");
            EndContext();
            BeginContext(2223, 8, false);
#line 55 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Manga\Details.cshtml"
                                     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2231, 499, true);
            WriteLiteral(@"; // Replace PAGE_IDENTIFIER with your page's unique identifier variable
    };

    (function() { // DON'T EDIT BELOW THIS LINE
        var d = document, s = d.createElement('script');
        s.src = 'https://humat.disqus.com/embed.js';
        s.setAttribute('data-timestamp', +new Date());
        (d.head || d.body).appendChild(s);
    })();
</script>
<noscript>Please enable JavaScript to view the <a href=""https://disqus.com/?ref_noscript"">comments powered by Disqus.</a></noscript>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMangaRepository Repository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manga> Html { get; private set; }
    }
}
#pragma warning restore 1591
