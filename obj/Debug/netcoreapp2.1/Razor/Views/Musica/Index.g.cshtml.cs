#pragma checksum "C:\Users\47218167829\Desktop\WebMVC\Views\Musica\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82342f69b448b7e0fa1bf0aa82029fbf11f02bd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musica_Index), @"mvc.1.0.view", @"/Views/Musica/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Musica/Index.cshtml", typeof(AspNetCore.Views_Musica_Index))]
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
#line 1 "C:\Users\47218167829\Desktop\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#line 2 "C:\Users\47218167829\Desktop\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82342f69b448b7e0fa1bf0aa82029fbf11f02bd5", @"/Views/Musica/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Musica_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\47218167829\Desktop\WebMVC\Views\Musica\Index.cshtml"
  
    ViewData["Title"] = "MUSIC APP"; 

#line default
#line hidden
            BeginContext(46, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(53, 17, false);
#line 5 "C:\Users\47218167829\Desktop\WebMVC\Views\Musica\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(70, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(82, 16, false);
#line 6 "C:\Users\47218167829\Desktop\WebMVC\Views\Musica\Index.cshtml"
Write(ViewData["Nome"]);

#line default
#line hidden
            EndContext();
            BeginContext(98, 50, true);
            WriteLiteral(", Seja Bem-Vindo(a)!</h3>\r\n\r\n<p>Sua Playlist</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
