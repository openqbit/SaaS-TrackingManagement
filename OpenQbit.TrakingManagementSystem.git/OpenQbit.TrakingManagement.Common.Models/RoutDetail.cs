using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class RoutDetail
    {
        public int RoutDetailID { get; set; }

        public string City { get; set; }

        public DateTime Time { get; set; }

        public string RoutID { get; set; }

        public virtual Rout Rout { get; set; }
    }
}
