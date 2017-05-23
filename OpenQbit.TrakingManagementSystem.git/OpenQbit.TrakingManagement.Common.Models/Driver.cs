using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class Driver : Resource
    {
        public int DriverID { set; get; }

        public string DriverName { get; set; }

        public int Dnic { get; set; }

        public string TourID { get; set; }

        public virtual Tour Tour { get; set; }
    }
}