using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.RepositoriesImp;

public class TaskRepository(TaskManagementDBContext context) : ITaskRepository
{
    private readonly TaskManagementDBContext _context = context;

    public async Task<UserTask> GetByIdAsync(long id)
    {
        return await _context.UserTasks.FindAsync(id) ?? new UserTask();
    }

    public async Task<IEnumerable<UserTask>> GetAllTasksAsync()
    {
        return await _context.UserTasks.ToListAsync();
    }

    public async Task AddTaskAsync(UserTask task)
    {
        await _context.UserTasks.AddAsync(task);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTaskAsync(UserTask task)
    {
        _context.UserTasks.Update(task);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTaskAsync(long id)
    {
        var taskData = await _context.UserTasks.FindAsync(id) ??
            throw new NullReferenceException("Not Found");
        _context.UserTasks.Remove(taskData);
        await _context.SaveChangesAsync();
    }

}
