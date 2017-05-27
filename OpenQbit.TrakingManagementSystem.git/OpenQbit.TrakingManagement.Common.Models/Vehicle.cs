using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class Vehicle : Resource
    {
        public int VehicleID { get; set; }

        public string VehicleType { get; set; }

        public string VehicleNO { get; set; }

        public int TourNO { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
