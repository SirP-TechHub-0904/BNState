using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BNState.Domain.Dtos
{
    public class DashboardDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int UserNumbers { get; set; }
        public int OfficeNumbers { get; set; }
        public string ModelString { get; set; }
        [Display(Name = "Use People Count")]
        public bool UserCount { get; set; }
        public string Color { get; set; }

        [Display(Name = "Use Office Count")]
        public bool OfficeCount { get; set; }

        [Display(Name = "Dashboard Sort Order")]
        public int DashboardOrder { get; set; }
    }
}
