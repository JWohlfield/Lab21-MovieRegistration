#pragma checksum "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f476e60a4dd84b5e5e298ff5f085d3c349b67ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieSummary), @"mvc.1.0.view", @"/Views/Home/MovieSummary.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f476e60a4dd84b5e5e298ff5f085d3c349b67ad3", @"/Views/Home/MovieSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been successfully registered!</h1>\r\n<br />\r\n<p>Movie ID: ");
#nullable restore
#line 5 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml"
        Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Title : ");
#nullable restore
#line 6 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Genre : ");
#nullable restore
#line 7 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml"
      Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Year : ");
#nullable restore
#line 8 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml"
     Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Actors: ");
#nullable restore
#line 9 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml"
      Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Director: ");
#nullable restore
#line 10 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\MovieSummary.cshtml"
        Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591