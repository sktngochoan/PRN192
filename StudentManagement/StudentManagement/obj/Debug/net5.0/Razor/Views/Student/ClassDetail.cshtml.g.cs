#pragma checksum "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f73a31db637b12ab706dc5289f15c792b44e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ClassDetail), @"mvc.1.0.view", @"/Views/Student/ClassDetail.cshtml")]
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
#line 1 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f73a31db637b12ab706dc5289f15c792b44e43", @"/Views/Student/ClassDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_ClassDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Schedule>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
  
    int count = 1;

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

<h3>Class Detail</h3>
<div class=""container-fluid"">
    <table class=""table"">
        <thead>
            <tr>
                <td>
                    INDEX
                </td>
                <td>
                    IMAGE
                </td>
                <td>
                    MEMBER
                </td>
                <td>
                    CODE
                </td>
                <td>
                    SURNAME
                </td>
");
            WriteLiteral("                <td>\r\n                    MIDDLE NAME\r\n                </td>\r\n                <td>\r\n                    GIVEN NAME\r\n                </td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 66 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
             foreach (var item in ViewBag.student)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2639, "\"", 2670, 2);
            WriteAttributeValue("", 2645, "/lib/img/", 2645, 9, true);
#nullable restore
#line 73 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
WriteAttributeValue("", 2654, item.StudentImg, 2654, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\" height=\"90px\">\r\n                    \r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
                Write(item.StudentName.Split(" ")[2]+item.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
               Write(item.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 84 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
               Write(item.StudentName.Split(" ")[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
               Write(item.StudentName.Split(" ")[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
               Write(item.StudentName.Split(" ")[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\n");
#nullable restore
#line 93 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\ClassDetail.cshtml"
            count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
