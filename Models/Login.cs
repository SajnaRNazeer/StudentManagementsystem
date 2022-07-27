using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementsystem.Models
{
    public partial class Login
    {
        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Userpassword { get; set; }
    }
}
