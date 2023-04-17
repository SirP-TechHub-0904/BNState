using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel2
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public long OgLevel1Id { get; set; }
        public OgLevel1 OgLevel1 { get; set; }

        public ICollection<OgLevel3> OgLevel3s { get; set; }
        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
