using System;
using Microsoft.EntityFrameworkCore;
using NewsAPI.WebApi.Data.Model;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NewsAPI.WebApi.Data.Access.DAL
{
    public partial class NewsAPIOrgContext : DbContext
    {
        public NewsAPIOrgContext()
        {
        }

        public NewsAPIOrgContext(DbContextOptions<NewsAPIOrgContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<HeadLinesCategory> HeadLinesCategory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=NewsAPIOrg;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.HasIndex(e => e.HeadlinesCategoryId);

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.HeadlinesCategoryId).HasColumnName("HeadlinesCategoryID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UrltoImage).HasColumnName("URLToImage");

                entity.HasOne(d => d.HeadlinesCategory)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.HeadlinesCategoryId);
            });

            modelBuilder.Entity<HeadLinesCategory>(entity =>
            {
                entity.Property(e => e.HeadlinesCategoryId).HasColumnName("HeadlinesCategoryID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
