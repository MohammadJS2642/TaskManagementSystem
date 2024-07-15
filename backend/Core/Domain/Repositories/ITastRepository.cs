using Domain.Models;

namespace Domain.Repositories;

public interface ITastRepository
{
    Task<IEnumerable<UserTask>> GetAllTasks();
    Task<UserTask> GetById(int id);
    Task<UserTask> InsertTask(UserTask task);
    Task<UserTask> UpdateTask(Int64 id, UserTask task);
    Task<UserTask> DeleteTask(Int64 taskId);
}
