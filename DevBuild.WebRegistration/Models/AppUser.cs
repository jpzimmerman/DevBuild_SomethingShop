using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DevBuild.WebRegistration.Models
{
    public class AppUser : IdentityUser
    {
        [EmailAddress, Required, DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public override string Email { get => base.Email; set => base.Email = value; }

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:M/d}")]
        public DateTime? Birthday { get; set; }

        [Column]
        public bool SubscribeToEmails { get; set; }

        [Column]
        public bool SubscribeToTextAlerts { get; set; }

        [Column]
        public string UserId { get; set; }

        public AppUser()
        {

        }
    }
}