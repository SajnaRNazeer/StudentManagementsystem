using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementsystem.Models
{
    public partial class Student
    {
        public int Regno { get; set; }
        [Required(ErrorMessage = "This field required")]
        [MaxLength(30, ErrorMessage = "maximum 30 characters only")]
        [StringLength(30, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Please Enter First Letter Capital")]
        public string FullName { get; set; }
        public string CourseJoining { get; set; }
        [Range(10000, 15000, ErrorMessage = "Fee Must be between 10000 to 15000")]
        public string CourseFee { get; set; }
        public string BatchId { get; set; }
        public DateTime Doj { get; set; }
        [Required(ErrorMessage = "This field required")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Enter a Valid Address")]
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid PhoneNumber")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Enter 10 Digits")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string EmailId { get; set; }

        
    }
}
