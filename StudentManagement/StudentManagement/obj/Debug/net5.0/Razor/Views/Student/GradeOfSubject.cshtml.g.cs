#pragma checksum "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d838d71532ca9fe31c13bb985b3a43e57365adf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GradeOfSubject), @"mvc.1.0.view", @"/Views/Student/GradeOfSubject.cshtml")]
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
#line 3 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d838d71532ca9fe31c13bb985b3a43e57365adf0", @"/Views/Student/GradeOfSubject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_GradeOfSubject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentGrade>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentGrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GradeOfSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
  
    var listTerm = @ViewBag.listSemeters;
    var listgrades = @ViewBag.grades;
    bool check = true;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">

<div class=""main"">
    <div class=""container"">
        <div class=""row"">
            <h1>Grade report for Nguyễn Phong Hào (HE153346)</h1>
            <div class=""col-md-12"">
                <h6>Select a term, course ...</h6>
            </div>
            <div class=""col-md-2"">
                <h6>TERM</h6>
");
#nullable restore
#line 25 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                 foreach (var item in listTerm)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838d71532ca9fe31c13bb985b3a43e57365adf05715", async() => {
#nullable restore
#line 27 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                                                                                   Write(item.SemesterName);

#line default
#line hidden
#nullable disable
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                                                           WriteLiteral(item.SemesterId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 30 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-5\">\r\n\r\n");
#nullable restore
#line 34 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                 foreach (Subject item in @ViewBag.listSubjects)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838d71532ca9fe31c13bb985b3a43e57365adf09119", async() => {
#nullable restore
#line 36 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                                                                                           Write(item.SubjectName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + ");
#nullable restore
#line 36 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                                                                                                               Write(item.SubjectCode);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-SubjectId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                                                                    WriteLiteral(item.SubjectId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SubjectId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-SubjectId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SubjectId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 39 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <div class=""col-md-5"">

                <table class=""table"">
                    <thead>
                        <tr>
                            <td>
                                GRADE CATEGORY
                            </td>
                            <td>
                                GRADE ITEM
                            </td>
                            <td>
                                WEIGHT
                            </td>
                            <td>
                                VALUE
                            </td>
                            <td>
                                COMMENT
                            </td>

                        </tr>
                    </thead>
                    
");
#nullable restore
#line 66 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                     if (Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n\r\n");
#nullable restore
#line 70 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                             foreach (StudentGrade studentGrade in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                \r\n");
#nullable restore
#line 74 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                 foreach (Grade grade in ViewBag.grades)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                     if (grade.GradeId == studentGrade.GradeId)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                            ");
#nullable restore
#line 80 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                       Write(grade.GradeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 82 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                   Write(grade.GradeCategory.GradeCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 83 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                   Write(grade.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                                    <td>");
#nullable restore
#line 84 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                   Write(studentGrade.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 85 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                             if(studentGrade.Value == null)
                                            {
                                                check = false;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td> </td>\r\n");
#nullable restore
#line 90 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 93 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <tr>\r\n                                    <td>COURSE TOTAL</td>\r\n                                    <td>AVERAGE</td>\r\n                                    <td>");
#nullable restore
#line 97 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                                   Write(ViewBag.avgDiem);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td> </td>
                                    <td>STATUS</td>
                                    <td>STUDYING</td>
                                </tr>


                        </tbody>
");
#nullable restore
#line 107 "D:\PROJECT FINAL PRN291\project_prn211\StudentManagement\StudentManagement\Views\Student\GradeOfSubject.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentGrade>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591