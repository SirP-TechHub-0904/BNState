using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BNState.Domain.Models
{
    public class CategoryAppointment
    {
        public long Id { get; set; }
        public string Position { get; set; }

        [Display(Name = "Start Date Of Appointment")]
        public DateTime StartOfAppointment { get; set; }

        [Display(Name = "End Date Of Appointment")]
        public DateTime EndOfAppointment { get; set; }

        [Display(Name = "Arrangement Order")]
        public int Order { get; set; }

        public string ProfileId { get; set; }
        public Profile Profile { get; set; }

        public long? Category1Id { get; set; }
        public Category1 Category1 { get; set; }

        public long? Category2Id { get; set; }
        public Category2 Category2 { get; set; }

        public long? Category3Id { get; set; }
        public Category3 Category3 { get; set; }

        public long? Category4Id { get; set; }
        public Category4 Category4 { get; set; }


        public long? Category5Id { get; set; }
        public Category5 Category5 { get; set; }

        public long? Category6Id { get; set; }
        public Category6 Category6 { get; set; }

        public long? Category7Id { get; set; }
        public Category7 Category7 { get; set; }


        public long? Category8Id { get; set; }
        public Category8 Category8 { get; set; }

        public long? Category9Id { get; set; }
        public Category9 Category9 { get; set; }
    }
}
