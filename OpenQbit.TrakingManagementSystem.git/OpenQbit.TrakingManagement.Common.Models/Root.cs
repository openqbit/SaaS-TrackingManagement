using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class Root
    {
        public int RootID { get; set; }

        public virtual ICollection<RootDetail> RootDetail { get; set; }
    }
}
