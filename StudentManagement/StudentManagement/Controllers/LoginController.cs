using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StudentManagement.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Student_Management.Controllers
{
    public class LoginController : Controller
    {
        student_managementContext db = new student_managementContext();


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            var session = HttpContext.Session;

            int countStudent = 0;
            var liststudent = db.Students.ToList();
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
            var listlecture = db.Lecturers.ToList();
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
    }
}