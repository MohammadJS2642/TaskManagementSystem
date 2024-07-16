using System.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TaskManagementDBContext(DbContextOptions<TaskManagementDBContext> options)
    : DbContext(options)
{
    public DbSet<UserTask> UserTasks { get; set; }
    // public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserTask>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
        });
    }
}
