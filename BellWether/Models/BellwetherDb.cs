using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BellWether.Models
{
    public class BellwetherDb : DbContext
    {
        public DbSet<Bell> Bells { get; set; }
        public DbSet<User> Users { get; set; }
    }
}