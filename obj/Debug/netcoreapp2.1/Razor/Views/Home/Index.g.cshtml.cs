#pragma checksum "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a1a09444647c9e102c351e62d7b1c52619e39a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a1a09444647c9e102c351e62d7b1c52619e39a9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf3ae5cfae8e6037e0d62d41b89bc83a573569b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\metin\Desktop\System Analysis and Design\b2b\b2b\b2b\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(92, 556, true);
            WriteLiteral(@"<h1>You are welcome!</h1>
<br />
<pre style=""font-size:22px;"">You can access to Products,Orders,Admin Panel using menu.

In Orders tab,you can see all product which you was give an order and you can 
finish your order.

In Products tab,you can see all product information which you can give an order.

In Customers tab,you can see all partner of TEMSA.

In Admin Panel tab,you can access to Add User,Delete User,Update User,
Add Partner,Delete Partner,Update Partner page and with these page, 
you can manage your system.



</pre>

    ");
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
