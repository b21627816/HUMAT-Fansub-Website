#pragma checksum "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca0af28b38f397f554200f2b9b7673345eba46b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Episode), @"mvc.1.0.view", @"/Views/Anime/Episode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Anime/Episode.cshtml", typeof(AspNetCore.Views_Anime_Episode))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca0af28b38f397f554200f2b9b7673345eba46b", @"/Views/Anime/Episode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a88f05cba530ddfcf618983dc0b78a5f0961deb", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Episode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EpisodeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Episode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Anime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(27, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
  
    ViewBag.Title = "HÜMAT - " + Model.AnimeName + " - " + Model.EpNo + ".Bölümü İzle";
    var links = Model.Links.Split(",");

#line default
#line hidden
            BeginContext(168, 179, true);
            WriteLiteral("\r\n<style>\r\n    iframe#episodeFrame{ width: 100%; height: 516px;}\r\n</style>\r\n\r\n<div class=\"content\">\r\n    <div class=\"container\">\r\n        <ul class=\"post-selection text-center\">\r\n");
            EndContext();
#line 17 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
             if (Model.PrevEpisode != null)
            {

#line default
#line hidden
            BeginContext(407, 64, true);
            WriteLiteral("                <li class=\"prev-article \">\r\n                    ");
            EndContext();
            BeginContext(471, 285, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eca0af28b38f397f554200f2b9b7673345eba46b5225", async() => {
                BeginContext(603, 149, true);
                WriteLiteral("\r\n                        Önceki<br />\r\n                        Bölüm\r\n                        <i class=\"fa fa-angle-left\"></i>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                         WriteLiteral(Model.PrevEpisode.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(756, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 28 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
            }

#line default
#line hidden
            BeginContext(796, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 29 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
             if (Model.NextEpisode != null)
            {

#line default
#line hidden
            BeginContext(856, 63, true);
            WriteLiteral("                <li class=\"next-article\">\r\n                    ");
            EndContext();
            BeginContext(919, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eca0af28b38f397f554200f2b9b7673345eba46b8501", async() => {
                BeginContext(1051, 151, true);
                WriteLiteral("\r\n                        Sonraki<br />\r\n                        Bölüm\r\n                        <i class=\"fa fa-angle-right\"></i>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                         WriteLiteral(Model.NextEpisode.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1206, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 40 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
            }

#line default
#line hidden
            BeginContext(1246, 415, true);
            WriteLiteral(@"        </ul>
        <div class=""row"">
            <div class=""col-md-1""></div>
            <div class=""col-md-10"">
                <div class=""box"">
                    <div class=""blog-entry"">
                        <div class=""entry-header"">
                            <div class=""position-text"">
                                <i class=""fa fa-video-camera""></i>
                                <h3>");
            EndContext();
            BeginContext(1661, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eca0af28b38f397f554200f2b9b7673345eba46b11865", async() => {
                BeginContext(1716, 15, false);
#line 50 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                                                                                     Write(Model.AnimeName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                                                              WriteLiteral(Model.AnimeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1735, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1739, 10, false);
#line 50 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                                                                                                            Write(Model.EpNo);

#line default
#line hidden
            EndContext();
            BeginContext(1749, 10, true);
            WriteLiteral(". Bölüm - ");
            EndContext();
            BeginContext(1760, 11, false);
#line 50 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                                                                                                                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1771, 166, true);
            WriteLiteral("</h3>\r\n                            </div>\r\n                            <div class=\"js-video\" id=\"js-video\">\r\n                                <iframe id=\'episodeFrame\'");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 1937, "\'", 1952, 1);
#line 53 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
WriteAttributeValue("", 1943, links[0], 1943, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1953, 180, true);
            WriteLiteral(" frameborder=\'0\' allowfullscreen></iframe>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-8\">\r\n");
            EndContext();
#line 57 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                                     for (int i = 1; i <= links.Length && links[i - 1] != string.Empty; i++)
                                    {


#line default
#line hidden
            BeginContext(2284, 88, true);
            WriteLiteral("                                        <a class=\"btn btn-secondary js-alternative ml-3\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                                           href=\"", 2372, "\"", 2445, 1);
#line 61 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
WriteAttributeValue("", 2423, links.GetValue(i - 1), 2423, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2446, 143, true);
            WriteLiteral("\r\n                                           onclick=\"return changeVideo(this.href);\">\r\n                                            Alternatif ");
            EndContext();
            BeginContext(2590, 1, false);
#line 63 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                                                  Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2591, 48, true);
            WriteLiteral("\r\n                                        </a>\r\n");
            EndContext();
#line 65 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"

                                    }

#line default
#line hidden
            BeginContext(2680, 695, true);
            WriteLiteral(@"                                </div>

                            </div>

                        </div>

                    </div>
                    <div id=""disqus_thread""></div>
                </div>
            </div>
            <div class=""col-md-1""></div>

        </div>
        
    </div>
</div>


<script>

    /**
*  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
*  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables*/

var disqus_config = function () {
this.page.url = ""http://localhost:56882/Anime/Episode/""+");
            EndContext();
            BeginContext(3376, 8, false);
#line 92 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3384, 100, true);
            WriteLiteral(";  // Replace PAGE_URL with your page\'s canonical URL variable\r\nthis.page.identifier = \"Episode - \"+");
            EndContext();
            BeginContext(3485, 8, false);
#line 93 "D:\Staj\StajBlogSolution\StajBlogProject\Views\Anime\Episode.cshtml"
                               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3493, 750, true);
            WriteLiteral(@"; // Replace PAGE_IDENTIFIER with your page's unique identifier variable
};

    (function() { // DON'T EDIT BELOW THIS LINE
        var d = document, s = d.createElement('script');
        s.src = 'https://humat.disqus.com/embed.js';
        s.setAttribute('data-timestamp', +new Date());
        (d.head || d.body).appendChild(s);
    })();
</script>
<noscript>Please enable JavaScript to view the <a href=""https://disqus.com/?ref_noscript"">comments powered by Disqus.</a></noscript>


<script>

    function changeVideo(url) {
        var $iframe = $("".js-video #episodeFrame"");
        if ($iframe.length) {
            $iframe.attr('src', url);
            return false;
        }
        return true;
    };

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EpisodeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
