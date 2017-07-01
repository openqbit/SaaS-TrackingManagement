using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.TrakingManagement.DataAccess.DAL
{
    class TrakingContext : DbContext
    {
        public TrackingContext() : base("DBTracking")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<Rout> Rout { get; set; }
        public DbSet<RoutDetail> RoutDetail { get; set; }
        public DbSet<Tour> Tour { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
