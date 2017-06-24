using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class Driver 
    {
        public int DriverID { set; get; }

        public string DriverName { get; set; }

        public int DriverNIC { get; set; }

        public int TourID { get; set; }

        public int ResourceId { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual Resource Resource { get; set; }
    }
}