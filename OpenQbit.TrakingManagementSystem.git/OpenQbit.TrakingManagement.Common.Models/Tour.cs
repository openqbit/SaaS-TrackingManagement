using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
   public class Tour
    {
        public int TourID { get; set; }

        public string TourType { get; set; }

        public string Location { get; set; }

        public int RouteId { get; set; }

        public int Speed { get; set; }

        public virtual Route Route { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }

        public virtual ICollection<Driver> Driver { get; set; }
    }
}
