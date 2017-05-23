using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.Common.Models
{
    public class RootDetail
    {
        public int RootDetailID { get; set; }

        public string City { get; set; }

        public DateTime Time { get; set; }

        public string RootID { get; set; }

        public virtual Root Root { get; set; }
    }
}
