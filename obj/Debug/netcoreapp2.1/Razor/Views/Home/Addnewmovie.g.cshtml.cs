#pragma checksum "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\Addnewmovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4036ffd7a0dde91f5999eebaf8ed99bde3392ee1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Addnewmovie), @"mvc.1.0.view", @"/Views/Home/Addnewmovie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Addnewmovie.cshtml", typeof(AspNetCore.Views_Home_Addnewmovie))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4036ffd7a0dde91f5999eebaf8ed99bde3392ee1", @"/Views/Home/Addnewmovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f850424b6eadff2e252b7c235411a8e933b2a65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Addnewmovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Addnewmovie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AddNewMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 138, true);
            WriteLiteral("\r\n<h1>dotNet Flix</h1>\r\n<a href=\"/dashboard\">Dashboard!</a>\r\n<a href=\"/new\">Movies!</a>\r\n<a href=\"/logout\">Log out!</a>\r\n<hr>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(158, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8befa596c2bf4550891c4f1587a0296a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 9 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\Addnewmovie.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Movie;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 42, true);
            WriteLiteral("\r\n</div>\r\n<hr>\r\n<h2>Avaiable Movies</h2>\r\n");
            EndContext();
#line 13 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\Addnewmovie.cshtml"
  
    foreach(var x in @Model.AvaiableMovie)
    {

#line default
#line hidden
            BeginContext(307, 23, true);
            WriteLiteral("        <p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 330, "\"", 354, 2);
            WriteAttributeValue("", 337, "movies/", 337, 7, true);
#line 17 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\Addnewmovie.cshtml"
WriteAttributeValue("", 344, x.MovieId, 344, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(357, 7, false);
#line 17 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\Addnewmovie.cshtml"
                               Write(x.Title);

#line default
#line hidden
            EndContext();
            BeginContext(364, 20, true);
            WriteLiteral("</a>\r\n        </p>\r\n");
            EndContext();
#line 19 "C:\Users\little silver\Desktop\C#-stack\Asp.net\Dotnet_Flix\Views\Home\Addnewmovie.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Addnewmovie> Html { get; private set; }
    }
}
#pragma warning restore 1591
