#pragma checksum "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6cc04450f950b43339fde70907fbf57f24a1c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
#line 1 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\_ViewImports.cshtml"
using CustomMoodle;

#line default
#line hidden
#line 2 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\_ViewImports.cshtml"
using CustomMoodle.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6cc04450f950b43339fde70907fbf57f24a1c62", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2acb3c46cae47d660435fe9cee0966b7c02786d", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Model.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(74, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr/>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(195, 44, false);
#line 14 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(239, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(283, 40, false);
#line 17 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(323, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(367, 45, false);
#line 20 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(412, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(456, 41, false);
#line 23 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(497, 42, true);
            WriteLiteral("\r\n        </dd>\r\n       <dt>\r\n            ");
            EndContext();
            BeginContext(540, 47, false);
#line 26 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Enrollments));

#line default
#line hidden
            EndContext();
            BeginContext(587, 236, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>Course Title</th>\r\n                    <th>Grade</th>\r\n                    <th>Enrollment Date</th>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
                 foreach (var item in Model.Enrollments)
                {

#line default
#line hidden
            BeginContext(900, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(985, 47, false);
#line 39 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Course.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1124, 40, false);
#line 42 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1256, 49, false);
#line 45 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\haykm\Documents\Visual Studio 2017\Projects\CustomMoodle\CustomMoodle\Views\Students\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1384, 67, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1451, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e19a75768fe34cfdb92b9928690c4c9f", async() => {
                BeginContext(1473, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1489, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Model.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
