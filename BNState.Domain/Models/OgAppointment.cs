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
    public class OgAppointment
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

        public long? OgLevel1Id { get; set; }
        public OgLevel1 OgLevel1 { get; set; }

        public long? OgLevel2Id { get; set; }
        public OgLevel2 OgLevel2 { get; set; }

        public long? OgLevel3Id { get; set; }
        public OgLevel3 OgLevel3 { get; set; }

        public long? OgLevel4Id { get; set; }
        public OgLevel4 OgLevel4 { get; set; }


        public long? OgLevel5Id { get; set; }
        public OgLevel5 OgLevel5 { get; set; }

        public long? OgLevel6Id { get; set; }
        public OgLevel6 OgLevel6 { get; set; }

        public long? OgLevel7Id { get; set; }
        public OgLevel7 OgLevel7 { get; set; }


        public long? OgLevel8Id { get; set; }
        public OgLevel8 OgLevel8 { get; set; }

        public long? OgLevel9Id { get; set; }
        public OgLevel9 OgLevel9 { get; set; }
    }
}
