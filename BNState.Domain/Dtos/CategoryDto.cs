using BNState.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BNState.Domain.Models.Enum;

namespace BNState.Domain.Dtos
{
    public class CategoryDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Biography { get; set; }


        public string Position { get; set; }

        [Display(Name = "Start Date Of Appointment")]
        public string StartOfAppointment { get; set; }

        [Display(Name = "End Date Of Appointment")]
        public string EndOfAppointment { get; set; }

        [Display(Name = "Arrangement Order")]
        public int Order { get; set; }

        [Display(Name = "Fullname")]
        public string Fullname { get; set; }
        public string UserId { get; set; }

        public int SubCategoryCount { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
        public string Image { get; set; }

        [Display(Name = "Show Address")]
        public bool ShowAddress { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Show Email")]
        public bool ShowEmail { get; set; }

        [Display(Name = "Phone Numbers")]
        public string PhoneNumbers { get; set; }

        [Display(Name = "Show Phone Numbers")]
        public bool ShowPhoneNumbers { get; set; }

        
        [Display(Name = "Website")]
        public string Website { get; set; }
        [Display(Name = "Show Website")]
        public bool ShowWebsite { get; set; }
        [Display(Name = "Code")]
        public string Code { get; set; }
        [Display(Name = "Show Code")]
        public bool ShowCode { get; set; }

        public string Color { get; set; }
        [Display(Name = "Activiate Portal")]
        public bool ActiviatePortal { get; set; }

        public string? LogoUrl { get; set; } 

        [Display(Name = "Dashboard Office and Offical Display")]
        public ShowStatus ShowStatus { get; set; }
    }
}
