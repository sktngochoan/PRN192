#pragma checksum "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57134b4db6c8dc714ebc80404a21fbb1bc009c83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Student), @"mvc.1.0.view", @"/Views/Login/Student.cshtml")]
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
#line 1 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57134b4db6c8dc714ebc80404a21fbb1bc009c83", @"/Views/Login/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Hello Student</h1>\r\n");
#nullable restore
#line 8 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentId);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.ClassId);

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentCode);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentBofd);

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentAddress);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentEmail);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentPass);

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentImg);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Login\Student.cshtml"
Write(ViewBag.Student.StudentGender);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
