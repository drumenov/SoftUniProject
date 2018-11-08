using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace SoftUniProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Part> Parts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<UserRepairTask> UsersRepairsTasks { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        public DbSet<ExpertReceipt> ExpertsReceipts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<UserRepairTask>().HasKey(k => new { k.RepairTaskId, k.UserId });
            builder.Entity<ExpertReceipt>().HasKey(k => new { k.UserId, k.ReceiptId });

            base.OnModelCreating(builder);
        }
    }
}
