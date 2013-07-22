using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCA.Migration
{
    public sealed class Configuration : DbMigrationsConfiguration<MVCA.DB>
    {
        public Configuration()
        {

        }
        protected override void Seed(MVCA.DB context)
        {

            try
            {
                context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX  ON entry (personname)");

            }
            catch (Exception)
            {
            }

        }
    }
}