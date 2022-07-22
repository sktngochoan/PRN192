using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Controllers
{
    public class MarkController : Controller
    {
        student_managementContext context = new student_managementContext();
        public IActionResult Index()
        {
            int lecturersId = 2;
            int subjectId = 4;
            int classId = 2;
            
            //--This is non List
            List<Grade> grades = context.Grades.ToList();
            List<GradeCategory> gradeCategories = context.GradeCategories.ToList();

            List<Student> students = context.Students.Distinct().ToList();
            ViewBag.grades = grades;
            List<Subject> subjectList1 = context.Subjects.ToList();
            List<Class> classes = context.Classes.ToList();
            List<StudentGrade> studentList = context.StudentGrades.ToList();
            ViewBag.students = students;


            List<int> GradeIdList = new List<int>();

            //--End non List

            //1. List subject
            List<Subject> subjectList = context.Subjects.Where(s => s.SubjectId == subjectId && s.LecturerId == lecturersId).ToList();
            ViewBag.subjectList = subjectList;

            //2. List StudentGrade
            List<StudentGrade> studentGrades = context.StudentGrades.Where(s => s.SubjectId == subjectId && s.Subject.LecturerId == lecturersId && s.Subject.Class.ClassId == classId).OrderBy(s => s.GradeId).OrderBy(s => s.Grade.GradeCategoryId).ToList();
            var studentGrades1 = studentGrades.GroupBy(x => x.GradeId).Select(g => g.First());
            var studentGrades2 = studentGrades.GroupBy(x => x.StudentId).Select(g => g.First());
            ViewBag.studentGrades = studentGrades;
            ViewBag.studentGrades1 = studentGrades1;
            ViewBag.studentGrades2 = studentGrades2.OrderBy(x => x.StudentId);

            //3. List Grade
            foreach (var studentGrade in studentGrades1)
            {
                foreach (Grade grade in grades)
                {
                    if (studentGrade.GradeId == grade.GradeId)
                    {
                        GradeIdList.Add(grade.GradeId);
                    }
                }
            }
            ViewBag.GradeIdList = GradeIdList;

            return View();
        }
        public IActionResult MarkManager(int classId, int studentId)
        {
            int lecturersId = 2;
            int subjectId = 4;
            ViewBag.classId = classId;


            //1. List subject
            List<Class> classes = context.Classes.ToList();
            List<Subject> subjectList = context.Subjects.Where(s => s.SubjectId == subjectId && s.LecturerId == lecturersId).ToList();
            ViewBag.subjectList = subjectList;

            //2. List Student Grade
            Dictionary<int, List<StudentGrade>> map = new Dictionary<int, List<StudentGrade>>();
            List<StudentGrade> studentGrades = context.StudentGrades.Where(s => s.SubjectId == subjectId && s.Subject.LecturerId == lecturersId && s.Subject.Class.ClassId == classId).OrderBy(s => s.GradeId).OrderBy(s => s.Grade.GradeCategoryId).ToList();
            var studentGrades2 = studentGrades.GroupBy(x => x.StudentId).Select(g => g.First());

            List<Student> students = context.Students.Distinct().ToList();
            ViewBag.students = students;
            foreach (Student student in students)
            {
                foreach (StudentGrade studentGrade in studentGrades2)
                {
                    if (studentGrade.StudentId == student.StudentId)
                    {
                        List<StudentGrade> studentGradeList = context.StudentGrades.Where((x) => x.StudentId == student.StudentId).ToList();
                        map.Add((int)studentGrade.StudentId, studentGradeList);
                    }
                }
            }
            ViewBag.map = map;

            List<GradeCategory> gradeCategories = context.GradeCategories.ToList();
            List<Grade> gr = context.Grades.ToList();
            ViewBag.gr = gr;

            //3. List
            var studentGrades1 = studentGrades.GroupBy(x => x.GradeId).Select(g => g.First());
            ViewBag.studentGrades1 = studentGrades1;

            //4. Mark
            if (studentId != null)
            {
                List<StudentGrade> listStudentGrade = context.StudentGrades.Where(x => x.StudentId == studentId && x.SubjectId == subjectId).ToList();
                ViewBag.listStudentGrade = listStudentGrade;

            }
            return View();
        }
        public IActionResult EditMark(int classId, int studentId)
        {
            int lecturersId = 2;
            int subjectId = 4;
            ViewBag.classId = classId;


            //1. List subject
            List<Class> classes = context.Classes.ToList();
            List<Subject> subjectList = context.Subjects.Where(s => s.SubjectId == subjectId && s.LecturerId == lecturersId).ToList();
            ViewBag.subjectList = subjectList;

            //2. List Student Grade
            Dictionary<int, List<StudentGrade>> map = new Dictionary<int, List<StudentGrade>>();
            List<StudentGrade> studentGrades = context.StudentGrades.Where(s => s.SubjectId == subjectId && s.Subject.LecturerId == lecturersId && s.Subject.Class.ClassId == classId).OrderBy(s => s.GradeId).OrderBy(s => s.Grade.GradeCategoryId).ToList();
            var studentGrades2 = studentGrades.GroupBy(x => x.StudentId).Select(g => g.First());

            List<Student> students = context.Students.Distinct().ToList();
            ViewBag.students = students;
            foreach (Student student in students)
            {
                foreach (StudentGrade studentGrade in studentGrades2)
                {
                    if (studentGrade.StudentId == student.StudentId)
                    {
                        List<StudentGrade> studentGradeList = context.StudentGrades.Where((x) => x.StudentId == student.StudentId).ToList();
                        map.Add((int)studentGrade.StudentId, studentGradeList);
                    }
                }
            }
            ViewBag.map = map;

            List<GradeCategory> gradeCategories = context.GradeCategories.ToList();
            List<Grade> gr = context.Grades.ToList();
            ViewBag.gr = gr;

            //3. List
            var studentGrades1 = studentGrades.GroupBy(x => x.GradeId).Select(g => g.First());
            ViewBag.studentGrades1 = studentGrades1;

            //4. Mark
            if (studentId != null)
            {
                List<StudentGrade> listStudentGrade = context.StudentGrades.Where(x => x.StudentId == studentId && x.SubjectId == subjectId).ToList();
                ViewBag.listStudentGrade = listStudentGrade;

            }
            //////////////////////////////////////////////////////////
            
            string[] mark = Request.Form["mark"];
            string[] gradeCateId = Request.Form["gradeCateId"];
            string[] stdId = Request.Form["StudentId"];
            string[] subjId = Request.Form["SubjectId"];
            int SubjectId = int.Parse(subjId[0]);
            int StudentId = int.Parse(stdId[0]);
           
            int i = 0;
            foreach(string CateId in gradeCateId)
            {      
                for (int j = 0; j < mark.Length; j++)
                {
                    if (i == j)
                    {
                        StudentGrade studentGrade = context.StudentGrades.Where(x => x.GradeId == int.Parse(CateId) && x.StudentId == StudentId && x.SubjectId == SubjectId).FirstOrDefault();
                        if (studentGrade != null)
                        {
                            studentGrade.Value = float.Parse(mark[j]);
                            context.SaveChanges();
                        }
                    }
                }
                i = i + 1;
            }
            return View("MarkManager");
        }
    }
}
