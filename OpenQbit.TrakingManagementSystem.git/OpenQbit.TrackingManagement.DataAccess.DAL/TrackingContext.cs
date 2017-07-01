using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using OpenQbit.TrakingManagement.Common.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OpenQbit.TrackingManagement.DataAccess.DAL
{
    public class TrackingContext : DbContext
    {
        public TrackingContext() : base("DBTracking")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<Root> Root { get; set; }
        public DbSet<RootDetail> RootDetail { get; set; }
        public DbSet<Tour> Tour { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
