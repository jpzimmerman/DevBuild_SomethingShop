namespace DevBuild.WebRegistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin.Security;


    public partial class SiteUser : IdentityUser
    {
        [Key]
        [EmailAddress, Required, DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public override string Email { get => base.Email; set => base.Email = value; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string PasswordConfirm { get; set; }


        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:M/d}")]
        public DateTime? Birthday { get; set; }

        [Column]
        public bool SubscribeToEmails { get; set; }

        [Column]
        public bool SubscribeToTextAlerts { get; set; }
    }
}
