using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class Route
    {
        public int RouteID { get; set; }

        public virtual ICollection<RouteDetail> RouteDetail { get; set; }

    }
}
