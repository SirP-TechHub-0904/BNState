using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel5
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public long OgLevel4Id { get; set; }
        public OgLevel4 OgLevel4 { get; set; }

        public ICollection<OgLevel6> OgLevel6s { get; set; }
        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
