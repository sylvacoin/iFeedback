#pragma checksum "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580ae676499c9f3f32f91a09a0e3c784cd611fca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Details), @"mvc.1.0.view", @"/Views/Dashboard/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580ae676499c9f3f32f91a09a0e3c784cd611fca", @"/Views/Dashboard/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14951156846e437a46bf50cac044bfd5595920b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iFeedback.Models.Feedback>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Dashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"welcome-msg pt-3 pb-4\">\r\n    <h1><span class=\"text-primary\">");
#nullable restore
#line 8 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                              Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s</span> feedback</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-5 d-flex flex-column\">\r\n        <div class=\"d-flex justify-content-center align-items-center p-5\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 410, "\"", 468, 2);
            WriteAttributeValue("", 416, "https://www.gravatar.com/avatar/", 416, 32, true);
#nullable restore
#line 14 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
WriteAttributeValue("", 448, ViewData["imgHash"], 448, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-thumbnail img-border w-25 img-rounded"" />
        </div>
        <div class=""d-flex justify-content-around card"">
            <ul class=""list-unstyled card-body"">
                <li class=""p-1 d-flex justify-content-between""><label class=""w-25"">Name:</label> <span class=""w-75"">");
#nullable restore
#line 18 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                               Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\"p-1 d-flex justify-content-between\"><label class=\"w-25\">Email:</label> <span class=\"w-75\">");
#nullable restore
#line 19 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                                Write(Model.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\"p-1 d-flex justify-content-between\"><label classs=\"w-25\">Phone:</label> <span class=\"w-75\">");
#nullable restore
#line 20 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                                 Write(Model.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\"p-1 d-flex justify-content-between\"><label class=\"w-25\">Date</label> <span class=\"w-75\">");
#nullable restore
#line 21 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                              Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-7 p-1 card\">\r\n        <div class=\"card-body d-flex flex-column justify-content-end align-content-between\">\r\n            <p>");
#nullable restore
#line 27 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
          Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <ul class=\"list-unstyled card-body\">\r\n                <li class=\"p-1 d-flex justify-content-between\"><label class=\"w-25\">IP:</label> <span class=\"w-75\">");
#nullable restore
#line 29 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                             Write(Model.Ip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\"p-1 d-flex justify-content-between\"><label classs=\"w-25\">Country:</label> <span class=\"w-75\">");
#nullable restore
#line 30 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                                   Write(Model.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 30 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                                                  Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></li>\r\n                <li class=\"p-1 d-flex justify-content-between\"><label class=\"w-25\">City</label> <span class=\"w-75\">");
#nullable restore
#line 31 "C:\Users\SRMS-IT\source\repos\iFeedback 3.0\iFeedback 3.0\Views\Dashboard\Details.cshtml"
                                                                                                              Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"card-footer\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "580ae676499c9f3f32f91a09a0e3c784cd611fca9821", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iFeedback.Models.Feedback> Html { get; private set; }
    }
}
#pragma warning restore 1591
