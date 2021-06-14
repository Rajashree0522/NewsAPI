using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsAPI.Web.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAPI.Web.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<HeadlinesCategory> HeadLinesCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<HeadlinesCategory>().HasData(
                new HeadlinesCategory
                {
                    HeadlinesCategoryID = 1,
                    CategoryName = "Business"
                },
                new HeadlinesCategory
                {
                    HeadlinesCategoryID = 2,
                    CategoryName = "Entertainment"
                },
                new HeadlinesCategory
                {
                    HeadlinesCategoryID = 3,
                    CategoryName = "Health"
                },
                new HeadlinesCategory
                {
                    HeadlinesCategoryID = 4,
                    CategoryName = "Science"
                },
                new HeadlinesCategory
                {
                    HeadlinesCategoryID = 5,
                    CategoryName = "Sports"
                },
                new HeadlinesCategory
                {
                    HeadlinesCategoryID = 6,
                    CategoryName = "Technology"
                },new HeadlinesCategory
                {
                    HeadlinesCategoryID = -1,
                    CategoryName = "Default"
                });
        }
    }
}
