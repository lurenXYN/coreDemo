#pragma checksum "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Shared\Components\MovieCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e48f6aa1c119a2ce777e1321f16e21dfbb3b1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MovieCount_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MovieCount/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MovieCount/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MovieCount_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e48f6aa1c119a2ce777e1321f16e21dfbb3b1b", @"/Views/Shared/Components/MovieCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d877d338002dcd446a71cec55741d8d01a43289c", @"/_ViewImports.cshtml")]
    public class Views_Shared_Components_MovieCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 29, true);
            WriteLiteral("\r\n<h2>Movie Count:</h2>\r\n<h2>");
            EndContext();
            BeginContext(42, 5, false);
#line 4 "C:\Users\wt\source\repos\coreDemo\coreDemo\Views\Shared\Components\MovieCount\Default.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(47, 5, true);
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
