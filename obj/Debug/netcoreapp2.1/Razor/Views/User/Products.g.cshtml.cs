#pragma checksum "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54891ef0493109b298de04c3ae94c2a5884e710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Products), @"mvc.1.0.view", @"/Views/User/Products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Products.cshtml", typeof(AspNetCore.Views_User_Products))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54891ef0493109b298de04c3ae94c2a5884e710", @"/Views/User/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf3ae5cfae8e6037e0d62d41b89bc83a573569b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/temsa_logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
      
        ViewData["Title"] = "Products";
        Layout = "~/Views/Shared/_UserLayout.cshtml";
    

#line default
#line hidden
            BeginContext(142, 278, true);
            WriteLiteral(@"
    <h2>Products</h2>

    <main role=""main"" class=""col-md-9 ml-sm-auto col-lg-10 px-4"">
        <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"">


        </div>
        
        <div class=""row"">
");
            EndContext();
#line 17 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
             foreach (var item in Model)

            {

#line default
#line hidden
            BeginContext(479, 134, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card mb-4 shadow-sm\">\r\n                   \r\n\r\n                        ");
            EndContext();
            BeginContext(613, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "78d0ea49ac384f8690b9d31ef621c0ca", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
AddHtmlAttributeValue("", 698, item.ProductName, 698, 17, false);

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
            BeginContext(717, 104, true);
            WriteLiteral("\r\n                        <div class=\"card-body\">\r\n\r\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(822, 16, false);
#line 27 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
                                              Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(838, 64, true);
            WriteLiteral("</h5>\r\n\r\n                            <p class=\"card-text\">Price:");
            EndContext();
            BeginContext(903, 17, false);
#line 29 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
                                                  Write(item.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(920, 64, true);
            WriteLiteral("$</p>\r\n\r\n                            <p class=\"card-text\">Count:");
            EndContext();
            BeginContext(985, 17, false);
#line 31 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
                                                  Write(item.ProductCount);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 68, true);
            WriteLiteral("</p>\r\n\r\n                            <p class=\"card-text\">Desciption:");
            EndContext();
            BeginContext(1071, 16, false);
#line 33 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
                                                       Write(item.ProductDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 98, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 37 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\Products.cshtml"
            
                }

#line default
#line hidden
            BeginContext(1218, 144, true);
            WriteLiteral("            </div>\r\n            \r\n\r\n\r\n            <!--<canvas class=\"my-4 w-100\" id=\"myChart\" width=\"900\" height=\"380\"></canvas>-->\r\n\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
