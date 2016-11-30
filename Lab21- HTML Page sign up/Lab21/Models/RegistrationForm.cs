using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class RegistrationForm
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Age")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Please enter a email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
       
        public string EmergencyContactName { get; set; }
        public string EmergencyNumber { get; set; }

        [Required(ErrorMessage = "Please specify whether you want to join")]
        public bool? JoinTheSharks { get; set; }

    }
}