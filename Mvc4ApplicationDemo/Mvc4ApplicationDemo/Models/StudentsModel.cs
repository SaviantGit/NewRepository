using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc4ApplicationDemo.Models
{
    //public class StudentsModel
    //{
    public class StudentsModel
        {
            [Required]
            [Display(Name = "Student FirstName")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Student LastName")]
            public string LastName { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [Display(Name = "Qualification")]
            public string Qualification { get; set; }
           
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [Display(Name = "Skill")]
            public string Skill { get; set; }

            [Display(Name = "Experience")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            public string Experience { get; set; }
        }
   // }
}