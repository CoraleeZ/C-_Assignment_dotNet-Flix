#pragma checksum "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14151c6d87294337be1f3bf65cc3a544fd29b69b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dashboard), @"mvc.1.0.view", @"/Views/Home/dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/dashboard.cshtml", typeof(AspNetCore.Views_Home_dashboard))]
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
#line 1 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\_ViewImports.cshtml"
using Dotnet_Flix;

#line default
#line hidden
#line 2 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\_ViewImports.cshtml"
using Dotnet_Flix.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14151c6d87294337be1f3bf65cc3a544fd29b69b", @"/Views/Home/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f850424b6eadff2e252b7c235411a8e933b2a65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dashboard_wrapper>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 155, true);
            WriteLiteral("<h1>dotNet Flix</h1>\r\n<a href=\"/new\">Movies!</a>\r\n<a href=\"/logout\">Log out!</a>\r\n<hr>\r\n<h2>Stats</h2>\r\n<div class=\"form-group sm-3 border\">\r\n    <p>Name: ");
            EndContext();
            BeginContext(182, 20, false);
#line 8 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
        Write(Model.User.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(202, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(204, 19, false);
#line 8 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
                              Write(Model.User.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(223, 34, true);
            WriteLiteral("</p>\r\n    <p># of Watched Movies: ");
            EndContext();
            BeginContext(258, 13, false);
#line 9 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
                       Write(Model.Watched);

#line default
#line hidden
            EndContext();
            BeginContext(271, 25, true);
            WriteLiteral(" </p>\r\n    <p>Join Date: ");
            EndContext();
            BeginContext(297, 20, false);
#line 10 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
             Write(Model.User.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(317, 42, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n");
            EndContext();
#line 14 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
      
        foreach(var x in Model.User.MoviesInHand)
        {

#line default
#line hidden
            BeginContext(429, 37, true);
            WriteLiteral("            <div>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 466, "\"", 497, 2);
            WriteAttributeValue("", 473, "/movies/", 473, 8, true);
#line 18 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
WriteAttributeValue("", 481, x.Movie.MovieId, 481, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(498, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(501, 13, false);
#line 18 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
                                               Write(x.Movie.Title);

#line default
#line hidden
            EndContext();
            BeginContext(514, 58, true);
            WriteLiteral(" </a>\r\n                <span>  </span>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 572, "\"", 607, 2);
            WriteAttributeValue("", 579, "/returnpage/", 579, 12, true);
#line 20 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
WriteAttributeValue("", 591, x.Movie.MovieId, 591, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(608, 35, true);
            WriteLiteral("> Return </a>\r\n            </div>\r\n");
            EndContext();
#line 22 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\dashboard.cshtml"
        }
    

#line default
#line hidden
            BeginContext(661, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dashboard_wrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
