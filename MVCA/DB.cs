using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using MVCA.Models;
using MVCA.Config;



namespace MVCA
{
    public class DB:DbContext 
    {
        public DB()
            : base("name=DefaultConnection")
        {
        }
        public DbSet<timesheet> timeentry { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); 

            modelBuilder.Configurations.Add(new timeConfig());
        }
    }
}