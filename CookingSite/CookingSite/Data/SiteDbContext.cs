using CookingSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data
{
    public class SiteDbContext : DbContext
    {
        public SiteDbContext(DbContextOptions<SiteDbContext> options) : base(options)
        {
            //Database.Migrate();
        }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Image> Images { get; set; }
        public DbSet<Like> Likes { get; set; }
        //public DbSet<QA> QAs { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
