using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace Student_Management.Controllers
{
    public class ViewAttendanceController : Controller
    {
        student_managementContext db = new student_managementContext();
        public IActionResult Index()
        {
            var session = HttpContext.Session;
            string jsonaccount = session.GetString("account");
            Student student = new Student();
            if (jsonaccount != null)
            {
                student = JsonConvert.DeserializeObject<Student>(jsonaccount);
            }
            var studentId = student.StudentId;
            var listSubject = (from st in db.Students
                               join su in db.Subjects on st.ClassId equals su.ClassId
                               where st.StudentId == studentId
                               select su).ToList();
            ViewBag.listSubject = listSubject;
            return View();
        }

        public IActionResult ViewAttendanceDetail(int subjectId)
        {
            var session = HttpContext.Session;
            string jsonaccount = session.GetString("account");
            Student student = new Student();
            if (jsonaccount != null)
            {
                student = JsonConvert.DeserializeObject<Student>(jsonaccount);
            }
            var studentId = student.StudentId;

            var listSubject = (from st in db.Students
                               join su in db.Subjects on st.ClassId equals su.ClassId
                               where st.StudentId == studentId
                               select su).ToList();
            ViewBag.listSubject = listSubject;

            int total = (from s in db.Schedules
                         where s.SubjectId == subjectId
                         select s).Count();
            int absent = (from s in db.Schedules
                          where s.SubjectId == subjectId && s.Status == false
                          select s).Count();
            int percent = (int)(absent / total * 100);

            ViewBag.Percent = percent;
            ViewBag.Total = total;
            ViewBag.Absent = absent;

            List<Slot> slots = db.Slots.ToList();
            List<Room> rooms = db.Rooms.ToList();
            List<Lecturer> lecturers = db.Lecturers.ToList();
            List<Class> classes = db.Classes.ToList();
            List<Schedule> schedule = (from s in db.Schedules
                                       where s.SubjectId == subjectId
                                       select s).ToList();
            return View(schedule);
        }
    }
}