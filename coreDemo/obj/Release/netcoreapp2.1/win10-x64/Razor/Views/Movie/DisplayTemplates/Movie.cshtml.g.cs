#pragma checksum "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Movie\DisplayTemplates\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2a85f2151c77bb69dcc2c09d9214844a767953"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DisplayTemplates_Movie), @"mvc.1.0.view", @"/Views/Movie/DisplayTemplates/Movie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/DisplayTemplates/Movie.cshtml", typeof(AspNetCore.Views_Movie_DisplayTemplates_Movie))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2a85f2151c77bb69dcc2c09d9214844a767953", @"/Views/Movie/DisplayTemplates/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d877d338002dcd446a71cec55741d8d01a43289c", @"/_ViewImports.cshtml")]
    public class Views_Movie_DisplayTemplates_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<coreDemo.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 38, true);
            WriteLiteral("\r\n\r\n    <tr>\r\n        <th scope=\"row\">");
            EndContext();
            BeginContext(69, 8, false);
#line 5 "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Movie\DisplayTemplates\Movie.cshtml"
                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(77, 19, true);
            WriteLiteral("</th>\r\n        <td>");
            EndContext();
            BeginContext(97, 10, false);
#line 6 "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Movie\DisplayTemplates\Movie.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(107, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(127, 14, false);
#line 7 "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Movie\DisplayTemplates\Movie.cshtml"
       Write(Model.CinemaId);

#line default
#line hidden
            EndContext();
            BeginContext(141, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(161, 14, false);
#line 8 "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Movie\DisplayTemplates\Movie.cshtml"
       Write(Model.Starring);

#line default
#line hidden
            EndContext();
            BeginContext(175, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(195, 17, false);
#line 9 "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Movie\DisplayTemplates\Movie.cshtml"
       Write(Model.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(212, 33, true);
            WriteLiteral("</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(245, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552eb720703b4caea5454069056a0553", async() => {
                BeginContext(319, 2, true);
                WriteLiteral("编辑");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MovieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Movie\DisplayTemplates\Movie.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MovieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MovieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MovieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(325, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<coreDemo.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
