using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentAttendeds = new HashSet<StudentAttended>();
        }

        public int StudentId { get; set; }
        public int? ClassId { get; set; }
        public string StudentName { get; set; }
        public DateTime? StudentBofd { get; set; }
        public string StudentAddress { get; set; }
        public string StudentEmail { get; set; }
        public bool? StudentGender { get; set; }
        public string StudentImg { get; set; }
        public string StudentCode { get; set; }
        public string StudentPass { get; set; }

        public virtual Class Class { get; set; }
        public virtual ICollection<StudentAttended> StudentAttendeds { get; set; }
    }
}
