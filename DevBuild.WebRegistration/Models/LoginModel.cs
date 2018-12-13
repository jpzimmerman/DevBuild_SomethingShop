using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DevBuild.WebRegistration.Models
{
    public class LoginModel
    {
        [Key, EmailAddress, Required]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password field cannot be empty")]
        public string Password { get; set; }

    }
}