using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BNState.Domain.Models.Enum;

namespace BNState.Domain.Models
{
    public class Profile : IdentityUser
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Surname")]
        public string SurName { get; set; }
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }
        [Display(Name = "Lastname")]


        public string LastName { get; set; }


        [Display(Name = "Biography")]
        public string? Biography { get; set; }

        [Display(Name = "FullName")]
        public string Fullname
        {
            get
            {
                return Title +" "+ SurName + " " + FirstName + " " + LastName;
            }
        }

        [Display(Name = "Alternative Phone Number")]
        public string? AltPhone { get; set; }


        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Full Address")]
        public string? Address { get; set; }

        [Display(Name = "Passport")]
        public string? PhotoUrl { get; set; }
        public string? Key { get; set; }


        public GenderStatus Gender { get; set; }
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }
        [Display(Name = "Religious Status")]
        public ReligionStatus ReligionStatus { get; set; }
    }
}
