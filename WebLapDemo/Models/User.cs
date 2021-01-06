using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjectMVC5.Models
{
    public class User
    {
       
    /*    [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }*/
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]

        public string Password { get; set; }

        public void setEmail(object v)
        {
            this.Email = (string)v;
        }

        public void setPassword(object v)
        {
            this.Password = (string)v;
        }

        public void setLastName(object v)
        {
            this.LastName = (string)v;
        }
    }
}