#pragma checksum "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7506a9558b863ad1d371af6b7bf22d1be1faae5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ActivityDetail), @"mvc.1.0.view", @"/Views/Student/ActivityDetail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7506a9558b863ad1d371af6b7bf22d1be1faae5c", @"/Views/Student/ActivityDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_ActivityDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Schedule>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClassDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
  
    var schedule = ViewBag.schedule;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">

<nav class=""navbar navbar-expand-md navbar-dark bg-dark"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""home"">Schedule</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExampleDefault"" aria-controls=""navbarsExampleDefault"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navba");
            WriteLiteral(@"r-collapse justify-content-end"" id=""navbarsExampleDefault"">
            <ul class=""navbar-nav m-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Manager Admin</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Hello Ngoc Hoan</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Login</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<h3>Activity Detail</h3>
<div class=""container-fluid"">
    <table class=""table"">
        <tr>
            <td>Date:</td>
");
#nullable restore
#line 42 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
             foreach (var item in ViewBag.schedule)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 45 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
               Write(Convert.ToDateTime(item.ScheduleDate).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n");
#nullable restore
#line 48 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n        <tr>\r\n            <td>Slot:</td>\r\n");
#nullable restore
#line 53 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
             foreach (var item in ViewBag.schedule)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 55 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
               Write(item.SlotId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 56 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>Student group:</td>\r\n");
#nullable restore
#line 60 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
             foreach (var item in ViewBag.schedule)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7506a9558b863ad1d371af6b7bf22d1be1faae5c8084", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 64 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
                   Write(item.Class.ClassName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-classId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
                                                                               WriteLiteral(item.ClassId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["classId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-classId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["classId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 67 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>Instructor:</td>\r\n");
#nullable restore
#line 71 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
             foreach (var item in ViewBag.schedule)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 73 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
               Write(item.Lecturer.LecturerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 74 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>Course:</td>\r\n");
#nullable restore
#line 78 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
             foreach (var item in ViewBag.schedule)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 80 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
               Write(item.Subject.SubjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 81 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tr>
        <tr>
            <td>Course session number:</td>
            <td>1</td>
        </tr>
        <tr>
            <td>Course session type:</td>
            <td></td>
        </tr>
        <tr>
            <td>Course session description:</td>
            <td></td>
        </tr>
        <tr>
            <td>Campus/Programme:</td>
            <td>FU-HL</td>
        </tr>
        <tr>
            <td>Attendance:</td>
            <td>
");
#nullable restore
#line 102 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
                 foreach (var item in ViewBag.schedule)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
                     if (@item.Status == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color:green\">\r\n                            Attend\r\n                        </span>\r\n");
#nullable restore
#line 109 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color:red\">\r\n                            Not yet\r\n                        </span>\r\n");
#nullable restore
#line 115 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ActivityDetail.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Booker:</td>\r\n            <td>hoannn</td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td>Record time:</td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagement.Models.Schedule> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
