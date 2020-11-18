
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wBees.Data.Models;

namespace wBees.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Industry> Industries { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobKeyword> JobKeywords { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<SubIndustry> SubIndustries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<JobKeyword>()
                .HasKey(jk => new { jk.JobId, jk.KeywordId });

            modelBuilder
                .Entity<Job>()
                .Property(j => j.ApplicantsCount)
                .UsePropertyAccessMode(PropertyAccessMode.Field);

            //modelBuilder
            //    .Entity<Job>()
            //    .HasOne(j=>j.Location)
            //    .WithMany(l=>l.Jobs)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder
            //    .Entity<Industry>()
            //    .HasMany(i => i.Jobs)
            //    .WithOne(j => j.Industry)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder
            //    .Entity<Industry>()
            //    .HasMany(i => i.SubIndustries)
            //    .WithOne(si => si.Industry)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder
            //    .Entity<SubIndustry>()
            //    .HasMany(si => si.Jobs)
            //    .WithOne(j => j.SubIndustry)
            //    .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
