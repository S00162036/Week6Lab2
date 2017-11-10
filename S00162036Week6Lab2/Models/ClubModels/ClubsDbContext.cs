using Rad2016SampleWepApp.Models.ClubModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace S00162036Week6Lab2.Models.ClubModels
{
    public class ClubsDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public ClubsDbContext() 
            : base("DefaultConnection")
        { }
    }
}