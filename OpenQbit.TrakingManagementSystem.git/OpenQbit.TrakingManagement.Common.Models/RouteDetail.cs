using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class RouteDetail
    {
        public int RouteDetailID { get; set; }

        public string City { get; set; }

        public DateTime Time { get; set; }

        public string RouteID { get; set; }

        public virtual Route Route { get; set; }
    }
}
