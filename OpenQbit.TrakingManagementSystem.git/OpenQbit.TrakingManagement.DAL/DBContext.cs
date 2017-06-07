using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OpenQbit.TrakingManagement.Common.Models;

namespace OpenQbit.TrakingManagement.DAL
{
    public class DBContext : DbContext

    {
        public DBContext() : base("TrackinDB")
        {
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
