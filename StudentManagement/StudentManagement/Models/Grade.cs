using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Grade
    {
        public int GradeId { get; set; }
        public int? GradeCategoryId { get; set; }
        public string GradeName { get; set; }

        public virtual GradeCategory GradeCategory { get; set; }
    }
}
