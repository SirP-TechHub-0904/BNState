using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel6
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public long OgLevel5Id { get; set; }
        public OgLevel5 OgLevel5 { get; set; }

        public ICollection<OgLevel7> OgLevel7s { get; set; }
        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
