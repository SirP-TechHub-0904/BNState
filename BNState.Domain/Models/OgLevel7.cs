using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel7
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public long OgLevel6Id { get; set; }
        public OgLevel6 OgLevel6 { get; set; }

        public ICollection<OgLevel8> OgLevel8s { get; set; }
        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
