#pragma checksum "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\checkAttendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205fa2f11385244ff831ba3bdda9eb4a297eeb80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_checkAttendance), @"mvc.1.0.view", @"/Views/Student/checkAttendance.cshtml")]
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
#line 1 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\checkAttendance.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\checkAttendance.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205fa2f11385244ff831ba3bdda9eb4a297eeb80", @"/Views/Student/checkAttendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_checkAttendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Schedule>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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

<h3>Class Detail</h3>
<div class=""container-fluid"">
");
#nullable restore
#line 39 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\checkAttendance.cshtml"
     foreach (var item in ViewBag.check)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 42 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\checkAttendance.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 44 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\checkAttendance.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
