using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace footballcode.Models
{
    public class FootBallContext : DbContext
    {
        public FootBallContext()
            : base("name = FBConnection")
        {

        }
        public DbSet<Football> FootballTable { get; set; }
    }
}