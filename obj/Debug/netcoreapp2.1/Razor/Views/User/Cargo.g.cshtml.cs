#pragma checksum "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6957c86aec39ed6114fe02db5859954d87b9b649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Cargo), @"mvc.1.0.view", @"/Views/User/Cargo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Cargo.cshtml", typeof(AspNetCore.Views_User_Cargo))]
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
#line 1 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\_ViewImports.cshtml"
using b2b;

#line default
#line hidden
#line 2 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\_ViewImports.cshtml"
using b2b.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6957c86aec39ed6114fe02db5859954d87b9b649", @"/Views/User/Cargo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf3ae5cfae8e6037e0d62d41b89bc83a573569b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Cargo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/lastik.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
  
    ViewData["Title"] = "Cargo";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(94, 247, true);
            WriteLiteral("\r\n<h2>Cargo</h2>\r\n\r\n<main role=\"main\" class=\"col-md-9 ml-sm-auto col-lg-10 px-4\">\r\n    <div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom\">\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
         foreach (var item in Model)

        {

#line default
#line hidden
            BeginContext(392, 134, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card mb-4 box-shadow\">\r\n                    \r\n                        ");
            EndContext();
            BeginContext(526, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f647239bc8a8492db809d1a890902ff7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
AddHtmlAttributeValue("", 583, item.ProductName, 583, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(602, 104, true);
            WriteLiteral("\r\n                        <div class=\"card-body\">\r\n\r\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(707, 16, false);
#line 25 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
                                              Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(723, 64, true);
            WriteLiteral("</h5>\r\n\r\n                            <p class=\"card-text\">Price:");
            EndContext();
            BeginContext(788, 17, false);
#line 27 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
                                                  Write(item.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(805, 63, true);
            WriteLiteral("</p>\r\n\r\n                            <p class=\"card-text\">Count:");
            EndContext();
            BeginContext(869, 17, false);
#line 29 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
                                                  Write(item.ProductCount);

#line default
#line hidden
            EndContext();
            BeginContext(886, 68, true);
            WriteLiteral("</p>\r\n\r\n                            <p class=\"card-text\">Desciption:");
            EndContext();
            BeginContext(955, 16, false);
#line 31 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
                                                       Write(item.ProductDesc);

#line default
#line hidden
            EndContext();
            BeginContext(971, 92, true);
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 36 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Cargo.cshtml"
              
        }

#line default
#line hidden
            BeginContext(1090, 114, true);
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n    <!--<canvas class=\"my-4 w-100\" id=\"myChart\" width=\"900\" height=\"380\"></canvas>-->\r\n\r\n</main>");
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
