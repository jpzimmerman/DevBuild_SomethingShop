﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevBuild.WebRegistration.Models {
    public class RegistrationData {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Last Name")]
        public string LastName { get; set; }

        [Required, EmailAddress, MaxLength(50)]
        public string EmailAddress { get; set; }

        public string FavoriteCoffee { get; set; }
        public byte[] CellPhoneNumber { get; set; } = new byte[10];

        [DisplayFormat(DataFormatString ="{0:M/d}")]
        public DateTime Birthday { get; set; }
        public bool UserSubscribedToEmails { get; set; } = false;
    }
}