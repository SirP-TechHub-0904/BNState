using BNState.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BNState.Domain.Dtos
{
    public class LevelDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


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

        public int OgLevel2s { get; set; }
        public string Color { get; set; }
    }
}
