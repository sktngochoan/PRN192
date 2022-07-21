using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            var session = HttpContext.Session;

            int countStudent = 0;
            var liststudent = context.Students.ToList();
            var student = new Student();
            foreach (var s in liststudent)
            {
                if (s.StudentEmail.ToString().Equals(email) && s.StudentPass.ToString().Equals(pass))
                {
                    countStudent++;
                    student = s;
                }
            }

            int countLecturer = 0;
            var listlecture = context.Lecturers.ToList();
            var lecturer = new Lecturer();
            foreach (var l in listlecture)
            {
                if (l.LecturerEmail.ToString().Equals(email) && l.LecturerPass.ToString().Equals(pass))
                {
                    countLecturer++;
                    lecturer = l;
                }
            }

            if (countStudent != 0)
            {
                string jsonaccount = JsonConvert.SerializeObject(student);
                session.SetString("account", jsonaccount);
                return RedirectToAction("Student");
            }

            if (countLecturer != 0)
            {
                string jsonaccount = JsonConvert.SerializeObject(lecturer);
                session.SetString("account", jsonaccount);
                return RedirectToAction("Lecturer");
            }
            else
            {
                ViewBag.Message = "Login Fail";
                return RedirectToAction("Login");
            }

        }

        public IActionResult Student()
        {
            var session = HttpContext.Session;
            string jsonaccount = session.GetString("account");
            Student student = new Student();
            if (jsonaccount != null)
            {
                student = JsonConvert.DeserializeObject<Student>(jsonaccount);
            }
            ViewBag.Student = student;
            return View();
        }

        public IActionResult Lecturer()
        {
            var session = HttpContext.Session;
            string jsonaccount = session.GetString("account");
            Lecturer lecturer = new Lecturer();
            if (jsonaccount != null)
            {
                lecturer = JsonConvert.DeserializeObject<Lecturer>(jsonaccount);
            }
            ViewBag.Lecturer = lecturer;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult TimeTable()
        {
            // getDate
            List<Week> listWeek1 = context.Weeks.ToList();
            int weekid = 0;
            foreach (var item in listWeek1)
            {
                if (DateTime.Compare(DateTime.Now, (DateTime)item.EndDate)<0)
                {
                    weekid = item.WeekId;
                    break;
                }
            }
            List<Schedule> ls = context.Schedules.
                Where(p => p.WeekId == weekid).ToList();
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
                            where Schedule.WeekId == weekid
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
            for (int i = 0; i<listDay.Count; i++)
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
            for (int i = 0; i<listWeek.Count; i++)
            {
                if (i == 0 || i % 2 == 0)
                    Weeks.Add(listWeek[i] + "-" + listWeek[i+1]);
            }
            List<StudentAttended> listAttend = (from StudentAttended in context.StudentAttendeds
                                                where StudentAttended.StudentId == 1
                                                select StudentAttended
                                                ).ToList();
            ViewBag.studentAttend = listAttend;
            List<int> attendance = new List<int>();
            Dictionary<int, int> attended = new Dictionary<int, int>();
            for (int i = 0; i<ls.Count; i++)
            {
                for (int j = 0; j<listAttend.Count; j++)
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
            for (int i = 0; i<ls.Count; i++)
            {
                if (!attended.ContainsKey(ls[i].ScheduleId))
                {
                    attended.Add(ls[i].ScheduleId, 0);
                }
            }
            ViewBag.Count = ls.Count();
            ViewBag.Subject = context.Subjects.ToList();
            ViewBag.Room = context.Rooms.ToList();
            ViewBag.slot = listSlot;
            ViewBag.week = context.Weeks.ToList();
            ViewBag.attend = attended;
            ViewBag.Date = listDate;
            ViewBag.selectedWeek = weekid;
            ViewBag.IsAttend = 1;
            return View();
        }
        [HttpPost]
        public IActionResult TimeTable(int weekid)
        {
            List<Week> listWeek1 = context.Weeks.ToList();
            int weekid_check = 0;
            foreach (var item in listWeek1)
            {
                if (DateTime.Compare(DateTime.Now, (DateTime)item.EndDate)<0)
                {
                    weekid_check = item.WeekId;
                    break;
                }
            }
            if (weekid == weekid_check)
            {
                ViewBag.IsAttend = 1;
            }
            List<Schedule> ls = context.Schedules.
                Where(p => p.WeekId == weekid).ToList();
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
                            where Schedule.WeekId == weekid
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
            for (int i = 0; i<listDay.Count; i++)
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
            for (int i = 0; i<listWeek.Count; i++)
            {
                if (i == 0 || i % 2 == 0)
                    Weeks.Add(listWeek[i] + "-" + listWeek[i+1]);
            }
            List<StudentAttended> listAttend = (from StudentAttended in context.StudentAttendeds
                                                where StudentAttended.StudentId == 1
                                                select StudentAttended
                                                ).ToList();
            ViewBag.studentAttend = listAttend;
            List<int> attendance = new List<int>();
            Dictionary<int, int> attended = new Dictionary<int, int>();
            for (int i = 0; i<ls.Count; i++)
            {
                for (int j = 0; j<listAttend.Count; j++)
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
            for (int i = 0; i<ls.Count; i++)
            {
                if (!attended.ContainsKey(ls[i].ScheduleId))
                {
                    attended.Add(ls[i].ScheduleId, 0);
                }
            }
            ViewBag.Count = ls.Count();
            ViewBag.Subject = context.Subjects.ToList();
            ViewBag.Room = context.Rooms.ToList();
            ViewBag.slot = listSlot;
            ViewBag.week = context.Weeks.ToList();
            ViewBag.attend = attended;
            ViewBag.Date = listDate;
            ViewBag.selectedWeek = weekid;
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
        public IActionResult EditAttendance(int classId, int scheduleId)
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
            Schedule schedule = context.Schedules.SingleOrDefault(s => s.ScheduleId == scheduleId);
            schedule.Status = true;
            context.SaveChanges();
            if (listStudent.Count() == attendance.Count())
            {
                for (int i = 0; i<listStudent.Count(); i++)
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
                for (int i = 0; i<listStudent.Count(); i++)
                {
                    for (int j = 0; j<attendance.Count(); j++)
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
        public IActionResult CheckEditAttendance(List<int> attendance, int scheduleId, int classId)
        {
            List<Student> listStudent = (from Student in context.Students
                                         where Student.ClassId == classId
                                         select Student).ToList();
            if (listStudent.Count() == attendance.Count())
            {
                for (int i = 0; i<listStudent.Count(); i++)
                {
                    StudentAttended studentAttended1 = context.StudentAttendeds.
                        FirstOrDefault(x => x.StudentId == listStudent[i].StudentId
                        && x.ScheduleId == scheduleId);
                    studentAttended1.StudentStatus = 2;
                    context.SaveChanges();
                    i++;
                }
            }
            else
            {
                for (int i = 0; i<listStudent.Count(); i++)
                {
                    for (int j = 0; j<attendance.Count(); j++)
                    {
                        if (listStudent[i].StudentId == attendance[j])
                        {
                            StudentAttended studentAttended1 = context.StudentAttendeds.
                                FirstOrDefault(x => x.StudentId == listStudent[i].StudentId
                                && x.ScheduleId == scheduleId);
                            studentAttended1.StudentStatus = 2;
                            context.SaveChanges();
                            i++;
                        }

                    }
                    StudentAttended studentAttended = context.StudentAttendeds.
                        FirstOrDefault(x => x.StudentId == listStudent[i].StudentId
                        && x.ScheduleId == scheduleId);
                    studentAttended.StudentStatus = 1;
                    context.SaveChanges();
                }
            }
            ViewBag.check = attendance;
            return RedirectToAction("TimeTable");
        }

        public IActionResult Profile()
        {
            var session = HttpContext.Session;
            string jsonaccount = session.GetString("account");
            Student student = new Student();
            if (jsonaccount != null)
            {
                student = JsonConvert.DeserializeObject<Student>(jsonaccount);
            }
            ViewBag.Student = student;
            return View();
        }
    }

}
