using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace MVCA.Configuration
{
    public class sheetconfig : EntityTypeConfiguration<User>
    {
           public UserConfig()
            {
            }
        
    }
}