#pragma checksum "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Shared\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37f94495c6833b8d8b966d80933eea58f657067"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AuthLayout), @"mvc.1.0.view", @"/Views/Shared/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\_ViewImports.cshtml"
using iFeedback;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\_ViewImports.cshtml"
using iFeedback.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37f94495c6833b8d8b966d80933eea58f657067", @"/Views/Shared/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14951156846e437a46bf50cac044bfd5595920b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Shared\_AuthLayout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-signup-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs nav-justified"">
                    <li class=""nav-item"">
                        <a href=""/Identity/Account/Login"" class=""nav-link"">Sign In</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Identity/Account/Register"" class=""nav-link"">Sign Up</a>
                    </li>
                    
                </ul>
            </div>
            <div class=""card-body"">
                ");
#nullable restore
#line 20 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Shared\_AuthLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Shared\_AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <script type=""text/javascript"">
        $(function() {
            var current = location.pathname;
            $('.nav-tabs li a').each(function () {
                var $this = $(this);
                if (current.indexOf($this.attr('href')) !== -1) {
                    $this.addClass('active');
                }
            })
        })
    </script>
");
            }
            );
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
