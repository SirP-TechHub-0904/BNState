using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel9
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public long OgLevel8Id { get; set; }
        public OgLevel8 OgLevel8 { get; set; }

        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
