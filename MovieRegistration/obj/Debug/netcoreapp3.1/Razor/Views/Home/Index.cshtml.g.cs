#pragma checksum "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0660d22271131dd550c3df59fe6c47e6eba3da8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0660d22271131dd550c3df59fe6c47e6eba3da8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0660d22271131dd550c3df59fe6c47e6eba3da83732", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    <input type=\"number\" name=\"ID\" required />\r\n    <label>Movie ID</label>\r\n\r\n    <br />\r\n    <input type=\"text\" name=\"Title\" maxlength=\"50\" required />\r\n    <label>Title</label>\r\n\r\n    <br />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0660d22271131dd550c3df59fe6c47e6eba3da84254", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 13 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Genre);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<Genre>();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!--<select name=\"Genre\">-->\r\n        <!--How can I make this a dynamic list? -->\r\n        <!--<option value=\"");
#nullable restore
#line 17 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                      Write(Genre.Action);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Action</option>\r\n        <option value=\"");
#nullable restore
#line 18 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                  Write(Genre.Children);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Children</option>\r\n        <option value=\"");
#nullable restore
#line 19 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                  Write(Genre.Comedy);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Comedy</option>\r\n        <option value=\"");
#nullable restore
#line 20 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                  Write(Genre.Drama);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 20 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                                Write(Genre.Drama);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n        <option value=\"");
#nullable restore
#line 21 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                  Write(Genre.Horror);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 21 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                                 Write(Genre.Horror);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n        <option value=\"");
#nullable restore
#line 22 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                  Write(Genre.SciFi);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 22 "C:\Users\Butch\source\repos\Labs\Lab21-MovieRegistration\MovieRegistration\MovieRegistration\Views\Home\Index.cshtml"
                                Write(Genre.SciFi);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</option>
    </select>-->
    <label>Genre</label>

    <br />
    <!--Can I make the max be the current year instead of a literal number?-->
    <input type=""number"" name=""Year"" min=""1880"" max=""2021"" required />
    <label>Year</label>

    <br />
    <input type=""text"" name=""Actors"" required />
    <label>Actors</label>

    <br />
    <input type=""text"" name=""Director"" required />
    <label>Director</label>

    <br /> <br />
    <input type=""submit"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
