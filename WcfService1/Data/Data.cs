using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfService1.Model;

namespace WcfService1.Data
{
    public class GeneralDbContext : DbContext
    {


        public GeneralDbContext()
            : base("DefaultConnection")
        {
        }

        public static GeneralDbContext Create()
        {
            return new GeneralDbContext();
        }

        public DbSet<User> DBUser { get; set; }
        public DbSet<Review> DBReview { get; set; }
        //public DbSet<Office> DBOffice { get; set; }
    }
}
