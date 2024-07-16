using Domain.Entities;

namespace Domain.Repositories;

public interface ITaskRepository
{
    Task<UserTask> GetByIdAsync(Int64 id);
    Task<IEnumerable<UserTask>> GetAllTasksAsync();
    Task AddTaskAsync(UserTask task);
    Task UpdateTaskAsync(UserTask task);
    Task DeleteTaskAsync(Int64 id);
}
