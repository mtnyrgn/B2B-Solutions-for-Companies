#pragma checksum "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ccd690b6dcadfa2ad8a4c5bdc4c50d652e5ad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__Delete), @"mvc.1.0.view", @"/Views/User/_Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/_Delete.cshtml", typeof(AspNetCore.Views_User__Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ccd690b6dcadfa2ad8a4c5bdc4c50d652e5ad1", @"/Views/User/_Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf3ae5cfae8e6037e0d62d41b89bc83a573569b", @"/Views/_ViewImports.cshtml")]
    public class Views_User__Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/lastik.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
  
    ViewData["Title"] = "_Delete";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(124, 758, true);
            WriteLiteral(@"
<h2>_Delete</h2>

<main role=""main"" class=""col-md-9 ml-sm-auto col-lg-10 px-4"">
    <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"">

        <h1 class=""h2"">Products</h1>
        <div class=""btn-toolbar mb-2 mb-md-0"">
            <div class=""btn-group mr-2"">
                <button class=""btn btn-sm btn-outline-secondary"">Share</button>
                <button class=""btn btn-sm btn-outline-secondary"">Export</button>
            </div>
            <button class=""btn btn-sm btn-outline-secondary dropdown-toggle"">
                <span data-feather=""calendar""></span>
                This week
            </button>
        </div>

    </div>
    <div class=""row"">
");
            EndContext();
#line 26 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(933, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(941, 1029, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "844e3c3c4e814299a41f77b5ddb18320", async() => {
                BeginContext(982, 176, true);
                WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n                <div class=\"card mb-4 box-shadow\">\r\n                    <div class=\"card\" style=\"width: 18rem;\">\r\n                        ");
                EndContext();
                BeginContext(1158, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54a7422175964d82bd061070d480ad70", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
AddHtmlAttributeValue("", 1215, item.ProductName, 1215, 17, false);

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
                BeginContext(1234, 132, true);
                WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            \r\n                            <h5 class=\"card-title\">");
                EndContext();
                BeginContext(1367, 16, false);
#line 36 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
                                              Write(item.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(1383, 90, true);
                WriteLiteral("</h5>\r\n                          \r\n                            <p class=\"card-text\">Price:");
                EndContext();
                BeginContext(1474, 17, false);
#line 38 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
                                                  Write(item.ProductPrice);

#line default
#line hidden
                EndContext();
                BeginContext(1491, 92, true);
                WriteLiteral("</p>\r\n                            \r\n                            <p class=\"card-title\">Count:");
                EndContext();
                BeginContext(1584, 17, false);
#line 40 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
                                                   Write(item.ProductCount);

#line default
#line hidden
                EndContext();
                BeginContext(1601, 94, true);
                WriteLiteral("</p>\r\n                         \r\n                            <p class=\"card-text\">Description:");
                EndContext();
                BeginContext(1696, 16, false);
#line 42 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
                                                        Write(item.ProductDesc);

#line default
#line hidden
                EndContext();
                BeginContext(1712, 34, true);
                WriteLiteral("</p>\r\n                            ");
                EndContext();
                BeginContext(1746, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac6b30573fe469ab5b77379823c1bcf", async() => {
                    BeginContext(1824, 4, true);
                    WriteLiteral("sil ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 43 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
                                                     WriteLiteral(item.ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["cid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1837, 126, true);
                WriteLiteral("\r\n                        </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1970, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\User\_Delete.cshtml"
        }

#line default
#line hidden
            BeginContext(1983, 110, true);
            WriteLiteral("    </div>\r\n\r\n    <!--<canvas class=\"my-4 w-100\" id=\"myChart\" width=\"900\" height=\"380\"></canvas>-->\r\n\r\n</main>");
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
