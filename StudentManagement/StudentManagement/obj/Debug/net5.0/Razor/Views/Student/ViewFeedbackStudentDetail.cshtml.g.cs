#pragma checksum "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbfc98244bdd14af25ee274a4525642b071df0b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ViewFeedbackStudentDetail), @"mvc.1.0.view", @"/Views/Student/ViewFeedbackStudentDetail.cshtml")]
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
#line 1 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbfc98244bdd14af25ee274a4525642b071df0b7", @"/Views/Student/ViewFeedbackStudentDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_ViewFeedbackStudentDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Subject>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClassDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditInfoFeedBack", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
  
    Subject subject = ViewBag.Subject;
    Feedback feedback = ViewBag.feedback;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbfc98244bdd14af25ee274a4525642b071df0b75787", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div>
                    <h2>Add Feedback</h2>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div>
                                Batch(Lớp):");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbfc98244bdd14af25ee274a4525642b071df0b76378", async() => {
#nullable restore
#line 23 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                                                                                                Write(subject.Class.ClassName);

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
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-classId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                                                                       WriteLiteral(subject.ClassId);

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
                WriteLiteral("\r\n                            </div>\r\n                            <div>\r\n                                Subejct(Môn học):");
#nullable restore
#line 26 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                            Write(subject.SubjectCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div>
                                Month(Tháng):5
                            </div>
                            <div>
                                Teacher(Giảng viên):");
#nullable restore
#line 34 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                               Write(subject.Lecturer.LecturerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbfc98244bdd14af25ee274a4525642b071df0b710584", async() => {
                    WriteLiteral("\r\n            <input  type=\"hidden\" name=\"subjectId\"");
                    BeginWriteAttribute("value", " value=\"", 2023, "\"", 2049, 1);
#nullable restore
#line 42 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
WriteAttributeValue("", 2031, subject.SubjectId, 2031, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n            <input  type=\"hidden\" name=\"lecturerId\"");
                    BeginWriteAttribute("value", " value=\"", 2105, "\"", 2132, 1);
#nullable restore
#line 43 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
WriteAttributeValue("", 2113, subject.LecturerId, 2113, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@"/>
            <div class=""row"">
                <div><i style=""font-weight:bold"">Tick the phrase, which best suits the teacher (Đánh dấu vào ô thích hợp)</i></div>
                <div style=""border:1px solid black"" class=""col-md-12"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <span style=""font-weight:bold"">Regarding the teacher's punctuality</span><br />
                            <i> (Sự đúng giờ của giảng viên trong giờ học)</i>
                            <fieldset id=""tb"">
                            <input disabled type=""radio"" ");
#nullable restore
#line 52 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherPunctuality==4 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"4\" name=\"tb\"><span style=\"font-weight:bold\">Always punctual (Luôn đúng giờ)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 53 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherPunctuality==3 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"3\" name=\"tb\"><span style=\"font-weight:bold\">Mostly punctual (Phần lớn đúng giờ)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 54 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherPunctuality==2 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"2\" name=\"tb\"><span style=\"font-weight:bold\">Rarely punctual (Ít khi đúng giờ)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 55 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherPunctuality==1 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" value=""1"" name=""tb""><span style=""font-weight:bold"">Not at all punctual (Không bao giờ đúng giờ)</span>
                            </fieldset>
                        </div>
                        <div class=""col-md-6"">
                            <span style=""font-weight:bold"">Teaching skills of teacher</span><br />
                             <i>
                                 (Kỹ năng sư phạm của giảng viên)
                             </i>
                            <fieldset id=""tsk"">
                            <input disabled type=""radio"" ");
#nullable restore
#line 64 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSkill==4 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"4\" name=\"tsk\"><span style=\"font-weight:bold\">Very Good (Tốt)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 65 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSkill==3 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"3\" name=\"tsk\"><span style=\"font-weight:bold\">Good (Khá)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 66 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSkill==2 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"2\" name=\"tsk\"><span style=\"font-weight:bold\">Average (Trung bình)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 67 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSkill==1 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" value=""1"" name=""tsk""><span style=""font-weight:bold"">Poor (Kém)</span>
                            </fieldset>
                        </div>
                        <div class=""col-md-6"">
                            <span style=""font-weight:bold"">The teacher adequately covers the topics required by the syllabus</span><br />
                            <i>
                                (Đảm bảo khối lượng môn học theo chương trình)
                            </i>
                            <fieldset id=""tac"">
                            <input disabled type=""radio"" ");
#nullable restore
#line 76 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherCoverTopics==4 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"4\" name=\"tac\"><span style=\"font-weight:bold\">Fully covered (Đảm bảo hoàn toàn)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 77 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherCoverTopics==3 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"3\" name=\"tac\"><span style=\"font-weight:bold\">Mostly covered (Đảm bảo phần lớn)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 78 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherCoverTopics==2 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"2\" name=\"tac\"><span style=\"font-weight:bold\">Partially covered (Chỉ đảm bảo một phần)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 79 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherCoverTopics==1 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" value=""1"" name=""tac""><span style=""font-weight:bold"">Not at all covered (Không đảm bảo)</span>
                            </fieldset>
                        </div>
                        <div class=""col-md-6"">
                            <span style=""font-weight:bold"">Support from the teacher - guidance for practical exercises, answering questions out side of class</span><br />
                              <i>
                                  (Hỗ trợ của giảng viên trong và ngoài giờ - trả lời Email, hướng dẫn thực hành, giải đáp thắc mắc…)
                              </i>
                            <fieldset id=""tsg"">
                            <input disabled type=""radio"" ");
#nullable restore
#line 88 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSupport==4 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"4\" name=\"tsg\"><span style=\"font-weight:bold\">Very Good (Tốt)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 89 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSupport==3 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"3\" name=\"tsg\"><span style=\"font-weight:bold\">Good (Khá)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 90 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSupport==2 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"2\" name=\"tsg\"><span style=\"font-weight:bold\">Average (Trung bình)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 91 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherSupport==1 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" value=""1"" name=""tsg""><span style=""font-weight:bold"">Poor (Kém)</span>
                            </fieldset>
                        </div>
                        <div class=""col-md-6"">
                            <span style=""font-weight:bold"">Teacher's response to student's questions in class</span><br />
                              <i>
                                  (Đáp ứng của giảng viên về những thắc mắc của học viên trong giờ học)
                              </i>
                            <fieldset id=""trt"">
                            <input disabled type=""radio"" ");
#nullable restore
#line 100 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherRespond==4 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"4\" name=\"trt\"><span style=\"font-weight:bold\">Answered immediately or just after the session (Trả lời ngay hoặc trả lời vào cuối buổi học)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 101 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherRespond==3 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"3\" name=\"trt\"><span style=\"font-weight:bold\">Answered in the next session (Trả lời vào buổi học sau)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 102 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherRespond==2 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" value=\"2\" name=\"trt\"><span style=\"font-weight:bold\">Some queries left unanswered (Một số câu hỏi không được trả lời)</span><br />\r\n                            <input disabled type=\"radio\" ");
#nullable restore
#line 103 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                     Write(feedback.TeacherRespond==1 ? "checked":"");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" value=""1"" name=""trt""><span style=""font-weight:bold"">Most queries left unanswered (Phần lớn câu hỏi không được trả lời)</span>
                            </fieldset>
                        </div>
                    </div>
                </div>
                <div style=""margin-top:20px"">
                    <textarea readonly name=""comment"" style=""width:475px;height:130px"">");
#nullable restore
#line 109 "D:\FPT\Semester_5\PRN211\Project_Final\PRN192\StudentManagement\StudentManagement\Views\Student\ViewFeedbackStudentDetail.cshtml"
                                                                                  Write(feedback.Comment);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</textarea>\r\n                </div>\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagement.Models.Subject> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
