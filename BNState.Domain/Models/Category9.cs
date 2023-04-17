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
    public class Category9
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }

        public string Description { get; set; }
        [Display(Name = "Logo")]
        public string? LogoUrl { get; set; }
        public string? Key { get; set; }


        [Display(Name = "Dashboard Office and Offical Display")]
        public ShowStatus ShowStatus { get; set; }


        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Display(Name = "Show Address")]
        public bool ShowAddress { get; set; }

        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Display(Name = "Show Email")]
        public bool ShowEmail { get; set; }

        [Display(Name = "Phone Numbers")]
        public string? PhoneNumbers { get; set; }

        [Display(Name = "Show Phone Numbers")]
        public bool ShowPhoneNumbers { get; set; }


        [Display(Name = "Website")]
        public string? Website { get; set; }
        [Display(Name = "Show Website")]
        public bool ShowWebsite { get; set; }
        [Display(Name = "Code")]
        public string? Code { get; set; }
        [Display(Name = "Show Code")]
        public bool ShowCode { get; set; }
        public long Category8Id { get; set; }
        public Category8 Category8 { get; set; }

        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }
        [Display(Name = "Activiate Portal")]
        public bool ActiviatePortal { get; set; }
        [Display(Name = "Add To Dashboard")]
        public bool AddToDashboard { get; set; }
        [Display(Name = "Use People Count")]
        public bool UserCount { get; set; }

        [Display(Name = "Use Office Count")]
        public bool OfficeCount { get; set; }
        [Display(Name = "Dashboard Sort Order")]
        public int DashboardOrder { get; set; }
    }
}
