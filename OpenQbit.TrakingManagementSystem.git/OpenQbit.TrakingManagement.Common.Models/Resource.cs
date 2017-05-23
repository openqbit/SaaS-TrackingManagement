using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public abstract class Resource
    {
        public int ResourceID { get; set; }

        public string UserID { get; set; }

        public string GPSLocation { get; set; }

    }
}
