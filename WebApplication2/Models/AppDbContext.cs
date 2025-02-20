using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;



namespace WebApplication2.Models
{
    //using Microsoft.EntityFrameworkCore;

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //public DbSet<ErrorViewModel> ErrorViewModels { get; set; }

        public virtual DbSet<Todo> Todo{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Todo>().ToTable("Users");
            modelBuilder.Entity<Todo>().HasKey(p => p.user_id);
        }
    }
}
