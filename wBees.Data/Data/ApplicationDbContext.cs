﻿
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
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<SeniorityLevel> SeniorityLevels { get; set; }
        public DbSet<UserJobs> UserJobs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<JobKeyword>()
                .HasKey(jk => new { jk.JobId, jk.KeywordId });

            modelBuilder
                .Entity<UserJobs>()
                .HasKey(uj => new { uj.UserId, uj.JobId });

            //modelBuilder
            //    .Entity<Job>()
            //    .Property(j => j.ApplicantsCount)
            //    .UsePropertyAccessMode(PropertyAccessMode.Field);


        }

    }
}
