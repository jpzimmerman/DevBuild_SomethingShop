using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace DevBuild.WebRegistration.Models {
    public class RegistrationData {
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a First Name")]
        [MaxLength(20, ErrorMessage ="String too long")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Last Name")]
        public string LastName { get; set; }

        [Key]
        [Required, EmailAddress, MaxLength(50)]
        public string EmailAddress { get; set; }

        public byte[] CellPhoneNumber { get; set; } = new byte[10];
        public string CellPhoneAreaCode { get; set; }
        public string CellPhoneExchange { get; set; }
        public string CellPhoneExtension { get; set; }
        [DisplayFormat(DataFormatString ="{0:M/d}")]
        public DateTime Birthday { get; set; }
        public bool UserSubscribedToEmails { get; set; } = false;
        public bool UserSubscribedToTextAlerts { get; set; } = false;
    }
}