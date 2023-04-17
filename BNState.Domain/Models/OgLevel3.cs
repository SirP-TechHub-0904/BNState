using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel3
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public long OgLevel2Id { get; set; }
        public OgLevel2 OgLevel2 { get; set; }

        public ICollection<OgLevel4> OgLevel4s { get; set; }
        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
