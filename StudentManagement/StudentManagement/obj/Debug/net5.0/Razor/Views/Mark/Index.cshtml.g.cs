#pragma checksum "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adda2497b3c6367133c0416a156b334cc188a16b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mark_Index), @"mvc.1.0.view", @"/Views/Mark/Index.cshtml")]
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
#line 4 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adda2497b3c6367133c0416a156b334cc188a16b", @"/Views/Mark/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Mark_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
  
    List<Subject> listSubject = ViewBag.subjectList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adda2497b3c6367133c0416a156b334cc188a16b3672", async() => {
                WriteLiteral("\r\n    <select>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adda2497b3c6367133c0416a156b334cc188a16b3954", async() => {
                    WriteLiteral("--Select Subject--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
         foreach (Subject subject in listSubject)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adda2497b3c6367133c0416a156b334cc188a16b5271", async() => {
                    WriteLiteral("(");
#nullable restore
#line 14 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                Write(subject.SubjectCode);

#line default
#line hidden
#nullable disable
                    WriteLiteral(") - ");
#nullable restore
#line 14 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                        Write(subject.Class.ClassName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </select>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<br />
<div class=""col-md-12"">

    <table class=""table"">
        <thead>
            <tr>
                <td>
                    Student ID
                </td>
                <td>
                    Student Code
                </td>
                <td>
                    Student Name
                </td>



");
#nullable restore
#line 39 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                 foreach (var item in ViewBag.GradeIdList)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                     foreach (Grade grade in ViewBag.grades)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                         if (item == grade.GradeId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 45 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                           Write(grade.GradeCategory.GradeCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n        </thead>\r\n\r\n\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 57 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
             foreach (StudentGrade studentGrade1 in ViewBag.studentGrades2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 60 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                     foreach (Student student in ViewBag.students)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                         if (studentGrade1.StudentId == student.StudentId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 65 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                           Write(studentGrade1.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                           Write(student.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                           Write(student.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 68 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                             foreach (var item in ViewBag.GradeIdList)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                 foreach (Grade grade in ViewBag.grades)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                     if (item == grade.GradeId)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                         if(studentGrade1.Value != null && studentGrade1.GradeId == item)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2315, "\"", 2343, 1);
#nullable restore
#line 76 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
WriteAttributeValue("", 2323, studentGrade1.Value, 2323, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>     \r\n");
#nullable restore
#line 77 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <td><input type=\"text\" /></td>\r\n");
#nullable restore
#line 79 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                         
                                       
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tr>\r\n");
#nullable restore
#line 91 "D:\FRONT-END\Final\StudentManagement (1)\StudentManagement\StudentManagement\Views\Mark\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n\r\n</div>");
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
