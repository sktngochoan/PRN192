using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int SubjectId { get; set; }
        public int? LecturerId { get; set; }
        public int? SemesterId { get; set; }
        public int? ClassId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }

        public virtual Class Class { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
