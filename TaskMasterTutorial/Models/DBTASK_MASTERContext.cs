using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TaskMasterTutorial.Models
{
    public partial class DBTASK_MASTERContext : DbContext
    {

        public DBTASK_MASTERContext()
        {
        }

        public DBTASK_MASTERContext(DbContextOptions<DBTASK_MASTERContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=DBTASK_MASTER;user=root", x => x.ServerVersion("10.4.14-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Taskes { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
