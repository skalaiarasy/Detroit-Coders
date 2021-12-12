﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExperienceIT.Web.Models
{
    public class StudentMaster
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string LinkedIn { get; set; }
        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(30)]
        public string State { get; set; }

        [StringLength(15)]
        public string Zipcode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        public int AgeStatus { get; set; }

        [Display(Name = "About Me")]
        public string Aboutme { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }
    }
}
