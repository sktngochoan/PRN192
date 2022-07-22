using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        student_managementContext context = new student_managementContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TimeTable()
        {
            List<Schedule> ls = context.Schedules.
                Where(p => p.Day == "1").ToList();
            Dictionary<int, List<Schedule>> map = new Dictionary<int, List<Schedule>>();
            for (int i = 1; i <= 8; i++)
            {
                List<Schedule> schedules = new List<Schedule>();
                foreach (var s in ls)
                {
                    if (s.SlotId == i)
                    {
                        schedules.Add(s);
                    }
                }
                map.Add(i, schedules);
            }
            Dictionary<int, Dictionary<string, Schedule>> map2 = new Dictionary<int, Dictionary<string, Schedule>>();
            foreach (var m in map)
            {
                int key = m.Key;
                List<Schedule> schedules = m.Value;
                Dictionary<string, Schedule> map3 = new Dictionary<string, Schedule>();
                foreach (var item in schedules)
                {
                    map3.Add(Convert.ToDateTime(item.ScheduleDate).ToString("dd/MM/yyyy"), item);
                }
                map2.Add(key, map3);
            }

            var date_raw = (from Schedule in context.Schedules
                            where Schedule.Day == "1"
                            select Schedule.ScheduleDate)
                            .Distinct().ToList();
            List<String> listDate = new List<String>();
            for (int i = 0; i < date_raw.Count; i++)
            {
                listDate.Add(Convert.ToDateTime(date_raw[i]).ToString("dd/MM/yyyy"));
            }

            ViewBag.TimeTable = map2;
            List<Slot> listSlot = context.Slots.ToList();

            var listDay = (from Schedule in context.Schedules
                           select Schedule.ScheduleDate)
                            .Distinct().ToList();
            List<string> listWeek = new List<string>();
            List<string> Weeks = new List<string>();
            int count = 1;
            for (int i = 0; i < listDay.Count; i++)
            {
                if (count == 1 || count % 7 == 0)
                {
                    String[] listElement = Convert.ToDateTime(listDay[i]).ToString("dd/MM/yyyy").Split("/");
                    listWeek.Add(listElement[0] + "/" + listElement[1]);
                    if (count == 7)
                    {
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                else
                {
                    count++;
                }
            }
            for (int i = 0; i < listWeek.Count; i++)
            {
                if (i == 0 || i % 2 == 0)
                    Weeks.Add(listWeek[i] + "-" + listWeek[i + 1]);
            }
            List<StudentAttended> listAttend = (from StudentAttended in context.StudentAttendeds
                                                where StudentAttended.StudentId == 1
                                                select StudentAttended
                                                ).ToList();
            ViewBag.studentAttend = listAttend;
            List<int> attendance = new List<int>();
            Dictionary<int, int> attended = new Dictionary<int, int>();
            for (int i = 0; i < ls.Count; i++)
            {
                for (int j = 0; j < listAttend.Count; j++)
                {
                    if (ls[i].ScheduleId == listAttend[j].ScheduleId)
                    {
                        if (listAttend[j].StudentStatus == 2)
                        {
                            attended.Add(ls[i].ScheduleId, 2);
                            i++;
                        }
                        else
                        {
                            attended.Add(ls[i].ScheduleId, 1);
                            i++;
                        }
                    }
                }
            }
            for (int i = 0; i < ls.Count; i++)
            {
                if (!attended.ContainsKey(ls[i].ScheduleId))
                {
                    attended.Add(ls[i].ScheduleId, 0);
                }
            }
            ViewBag.Subject = context.Subjects.ToList();
            ViewBag.Room = context.Rooms.ToList();
            ViewBag.slot = listSlot;
            ViewBag.week = Weeks;
            ViewBag.attend = attended;
            ViewBag.Date = listDate;
            ViewBag.selectedWeek = Convert.ToInt32("1");
            return View();
        }
        [HttpPost]
        public IActionResult TimeTable(String weekid)
        {
            var ls = context.Schedules.
                Where(p => p.Day == weekid);
            Dictionary<int, List<Schedule>> map = new Dictionary<int, List<Schedule>>();
            for (int i = 1; i <= 8; i++)
            {
                List<Schedule> schedules = new List<Schedule>();
                foreach (var s in ls)
                {
                    if (s.SlotId == i)
                    {
                        schedules.Add(s);
                    }
                }
                map.Add(i, schedules);
            }
            Dictionary<int, Dictionary<string, Schedule>> map2 = new Dictionary<int, Dictionary<string, Schedule>>();
            foreach (var m in map)
            {
                int key = m.Key;
                List<Schedule> schedules = m.Value;
                Dictionary<string, Schedule> map3 = new Dictionary<string, Schedule>();
                foreach (var item in schedules)
                {
                    map3.Add(Convert.ToDateTime(item.ScheduleDate).ToString("dd/MM/yyyy"), item);
                }
                map2.Add(key, map3);
            }

            var date_raw = (from Schedule in context.Schedules
                            where Schedule.Day == weekid
                            select Schedule.ScheduleDate)
                            .Distinct().ToList();
            List<String> listDate = new List<String>();
            for (int i = 0; i < date_raw.Count; i++)
            {
                listDate.Add(Convert.ToDateTime(date_raw[i]).ToString("dd/MM/yyyy"));
            }

            ViewBag.TimeTable = map2;
            List<Slot> listSlot = context.Slots.ToList();

            var listDay = (from Schedule in context.Schedules
                           select Schedule.ScheduleDate)
                            .Distinct().ToList();
            List<string> listWeek = new List<string>();
            List<string> Weeks = new List<string>();
            int count = 1;
            for (int i = 0; i < listDay.Count; i++)
            {
                if (count == 1 || count % 7 == 0)
                {
                    String[] listElement = Convert.ToDateTime(listDay[i]).ToString("dd/MM/yyyy").Split("/");
                    listWeek.Add(listElement[0] + "/" + listElement[1]);
                    if (count == 7)
                    {
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                else
                {
                    count++;
                }
            }
            for (int i = 0; i < listWeek.Count; i++)
            {
                if (i == 0 || i % 2 == 0)
                    Weeks.Add(listWeek[i] + "-" + listWeek[i + 1]);
            }
            ViewBag.Subject = context.Subjects.ToList();
            ViewBag.Class = context.Classes.ToList();
            ViewBag.slot = listSlot;
            ViewBag.week = Weeks;
            ViewBag.selectedWeek = Convert.ToInt32(weekid);
            ViewBag.Date = listDate;
            return View();
        }

        public IActionResult ActivityDetail(int scheduleId)
        {
            var schedule = (from Schedule in context.Schedules
                            where Schedule.ScheduleId == scheduleId
                            select Schedule);

            ViewBag.schedule = schedule;
            ViewBag.Class = context.Classes.ToList();
            ViewBag.Lecture = context.Lecturers.ToList();
            ViewBag.Subject = context.Subjects.ToList();
            return View();
        }
        public IActionResult ClassDetail(int classId)
        {
            var listStudent = (from Student in context.Students
                               where Student.ClassId == classId
                               select Student).ToList();
            ViewBag.student = listStudent;
            return View();
        }

        public IActionResult Attendance(int classId, int scheduleId)
        {
            var ListStudent = (from Student in context.Students
                               where Student.ClassId == classId
                               select Student);
            ViewBag.student = ListStudent;
            ViewBag.scheduleId = scheduleId;
            ViewBag.classId = classId;
            return View();
        }

        public IActionResult CheckAttendance(List<int> attendance, int scheduleId, int classId)
        {
            List<Student> listStudent = (from Student in context.Students
                                         where Student.ClassId == classId
                                         select Student).ToList();
            if (listStudent.Count() == attendance.Count())
            {
                for (int i = 0; i < listStudent.Count(); i++)
                {
                    StudentAttended studentAttended1 = new StudentAttended();
                    studentAttended1.StudentId = listStudent[i].StudentId;
                    studentAttended1.ScheduleId = scheduleId;
                    studentAttended1.StudentStatus = 2;
                    studentAttended1.StudentAttendedDate = DateTime.Now;
                    context.StudentAttendeds.Add(studentAttended1);
                    context.SaveChanges();
                    i++;

                }
            }
            else
            {
                for (int i = 0; i < listStudent.Count(); i++)
                {
                    for (int j = 0; j < attendance.Count(); j++)
                    {
                        if (listStudent[i].StudentId == attendance[j])
                        {
                            StudentAttended studentAttended1 = new StudentAttended();
                            studentAttended1.StudentId = listStudent[i].StudentId;
                            studentAttended1.ScheduleId = scheduleId;
                            studentAttended1.StudentStatus = 2;
                            studentAttended1.StudentAttendedDate = DateTime.Now;
                            context.StudentAttendeds.Add(studentAttended1);
                            context.SaveChanges();
                            i++;
                        }

                    }
                    StudentAttended studentAttended = new StudentAttended();
                    studentAttended.StudentId = listStudent[i].StudentId;
                    studentAttended.ScheduleId = scheduleId;
                    studentAttended.StudentStatus = 1;
                    studentAttended.StudentAttendedDate = DateTime.Now;
                    context.StudentAttendeds.Add(studentAttended);
                    context.SaveChanges();

                }
            }

            ViewBag.check = attendance;

            return RedirectToAction("TimeTable");
        }
        public IActionResult StudentDetails(int StudentID)
        {
            StudentID = 4;
            Student student = context.Students.Where(x => x.StudentId == StudentID).FirstOrDefault();
            if (student == null)
            {
                return View("Error");
            }

            return View(student);
        }
        public IActionResult StudentGrade(int StudentId)
        {
            StudentId = 5;
            //List semester
            List<Semester> listSemeters = context.Semesters.ToList();
            ViewBag.listSemeters = listSemeters;
            //List Grade
            List<Grade> grades = context.Grades.ToList();
            //List Grade Category
            List<GradeCategory> gradeCategories = context.GradeCategories.ToList();
            //List Subject
            var listSubject = (from st in context.Students
                               join su in context.Subjects on st.ClassId equals su.ClassId
                               where st.StudentId == StudentId
                               select su).ToList();
            ViewBag.listSubjects = listSubject;

            return View();
        }

        public IActionResult GradeOfSubject(int SubjectId)
        {
int 
            StudentId = 5;
            //List semester
            List<Semester> listSemeters = context.Semesters.ToList();
            ViewBag.listSemeters = listSemeters;
            //List Grade
            List<Grade> grades = context.Grades.ToList();
            ViewBag.grades = grades;
            //List Grade Category
            List<GradeCategory> gradeCategories = context.GradeCategories.ToList();
            //List Subject
            var listSubject = (from st in context.Students
                               join su in context.Subjects on st.ClassId equals su.ClassId
                               where st.StudentId == StudentId
                               select su).ToList();
            ViewBag.listSubjects = listSubject;
            List<StudentGrade> studentGrades = context.StudentGrades.Where(x => x.SubjectId == SubjectId && x.StudentId == StudentId).OrderBy(x => x.GradeId).OrderBy(x => x.Grade.GradeCategoryId).ToList();
            ViewBag.studentGrades = studentGrades;

            float avgDiem = 0;
            int count = 0;
            foreach(StudentGrade grade in studentGrades)
            {
                foreach(Grade grade1 in grades)
                {
                    if(grade.GradeId == grade1.GradeId)
                    {

                        avgDiem = avgDiem + (float)((grade.Value * grade1.Weight) / 100);

                        count = count + 1;
                    }
                }
            }
            avgDiem /= count;
            ViewBag.avgDiem = avgDiem;

            return View(studentGrades);
        }
    }
}
