#pragma checksum "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3c0cbcaa8a1a6bd25a1dc36341e9d396bc0603"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UsersList), @"mvc.1.0.view", @"/Views/Admin/UsersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UsersList.cshtml", typeof(AspNetCore.Views_Admin_UsersList))]
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
#line 1 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker;

#line default
#line hidden
#line 2 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\_ViewImports.cshtml"
using Plagiarism_Checker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3c0cbcaa8a1a6bd25a1dc36341e9d396bc0603", @"/Views/Admin/UsersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4629291b9607b6f696e738bdc026a069f08427a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plagiarism_Checker.Models.AdminDTO.AllUsers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
  
    ViewData["Title"] = "UsersList";

#line default
#line hidden
            BeginContext(97, 24, true);
            WriteLiteral("\r\n<h1>UsersList</h1>\r\n\r\n");
            EndContext();
            BeginContext(121, 780, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3c0cbcaa8a1a6bd25a1dc36341e9d396bc06034543", async() => {
                BeginContext(184, 26, true);
                WriteLiteral("\r\n    <h2>Teachers:</h2>\r\n");
                EndContext();
#line 10 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
     foreach (var i in Model.allTeachers)
    {

#line default
#line hidden
                BeginContext(260, 31, true);
                WriteLiteral("        <h4 style=\"float:left\">");
                EndContext();
                BeginContext(292, 6, false);
#line 12 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
                          Write(i.name);

#line default
#line hidden
                EndContext();
                BeginContext(298, 35, true);
                WriteLiteral("</h4>\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 333, "\"", 346, 1);
#line 13 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
WriteAttributeValue("", 341, i.id, 341, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(347, 186, true);
                WriteLiteral(" />\r\n        <div style=\"margin-left:auto; margin-right:0\">\r\n            <input type=\"submit\" value=\"Delete\" />\r\n        </div>\r\n        <div style=\"clear:both;\"></div>\r\n        <hr />\r\n");
                EndContext();
#line 19 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
    }

#line default
#line hidden
                BeginContext(540, 24, true);
                WriteLiteral("    <h2>Students:</h2>\r\n");
                EndContext();
#line 21 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
     foreach (var i in Model.allStudents)
    {

#line default
#line hidden
                BeginContext(614, 31, true);
                WriteLiteral("        <h4 style=\"float:left\">");
                EndContext();
                BeginContext(646, 6, false);
#line 23 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
                          Write(i.name);

#line default
#line hidden
                EndContext();
                BeginContext(652, 35, true);
                WriteLiteral("</h4>\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 687, "\"", 700, 1);
#line 24 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
WriteAttributeValue("", 695, i.id, 695, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(701, 186, true);
                WriteLiteral(" />\r\n        <div style=\"margin-left:auto; margin-right:0\">\r\n            <input type=\"submit\" value=\"Delete\" />\r\n        </div>\r\n        <div style=\"clear:both;\"></div>\r\n        <hr />\r\n");
                EndContext();
#line 30 "D:\3 курс\_Net\Experiments\Plagiarism-Checker\Plagiarism-Checker\Views\Admin\UsersList.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plagiarism_Checker.Models.AdminDTO.AllUsers> Html { get; private set; }
    }
}
#pragma warning restore 1591
