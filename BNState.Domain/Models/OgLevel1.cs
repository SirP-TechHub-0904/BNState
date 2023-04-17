using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Models
{
    public class OgLevel1
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public ICollection<OgLevel2> OgLevel2s { get; set; }
        public ICollection<OgAppointment> Appointments { get; set; }
        public string Color { get; set; }

    }
}
