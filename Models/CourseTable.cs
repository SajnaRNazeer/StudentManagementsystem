using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementsystem.Models
{
    public partial class CourseTable
    {
        public CourseTable()
        {
            Student = new HashSet<Student>();
        }

        public string CourseJoining { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
