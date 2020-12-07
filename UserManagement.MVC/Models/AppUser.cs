using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.MVC.Models
{
    public enum Gender  {
        male,
        female
    }
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Notes { get; set; }
        public string PicUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
