using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel4
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public long OgLevel3Id { get; set; }
        public OgLevel3 OgLevel3 { get; set; }

        public ICollection<OgLevel5> OgLevel5s { get; set; }
        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
