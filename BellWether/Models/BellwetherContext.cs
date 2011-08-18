using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Web;

namespace BellWether.Models
{
    public class BellwetherContext : DbContext
    {
        public DbSet<Bell> Bells { get; set; }
        public DbSet<User> Users { get; set; }


        public ObjectContext UnderlyingContext
        {

            get { return ((IObjectContextAdapter)this).ObjectContext; }

        }
 



    }
}