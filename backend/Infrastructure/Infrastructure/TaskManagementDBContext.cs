using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TaskManagementDBContext(DbContextOptions<TaskManagementDBContext> options)
    : DbContext(options)
{
    public DbSet<UserTask> UserTasks { get; set; }
    public DbSet<User> Users { get; set; }
}
