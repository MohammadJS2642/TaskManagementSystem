using Domain.Entities;
using Domain.Repositories;

namespace Domain.Services;

public class TaskService(ITaskRepository tastRepository)
{
    private readonly ITaskRepository _taskRepository = tastRepository;

    public async Task<UserTask> GetByIdAsync(Int64 id) =>
        await _taskRepository.GetByIdAsync(id);

    public async Task<IEnumerable<UserTask>> GetAllTasksAsync() =>
        await _taskRepository.GetAllTasksAsync();

    public async Task AddTaskAsync(UserTask task) =>
        await _taskRepository.AddTaskAsync(task);

    public async Task UpdateTaskAsync(UserTask task)
    {
        var taskData = await _taskRepository.GetByIdAsync(task.Id) ??
            throw new NullReferenceException(nameof(task));

        task.Update(task.Title, task.Description, task.IsActive);
        await _taskRepository.UpdateTaskAsync(taskData);
    }

    public async Task MarkAsCompleted(long id)
    {
        var taskData = await _taskRepository.GetByIdAsync(id) ??
            throw new NullReferenceException("Task Not found");
        taskData.MarkAsCompleted();
        await _taskRepository.UpdateTaskAsync(taskData);
    }

    public async Task DeleteTaskAsync(Int64 id)
    {
        var taskData = await _taskRepository.GetByIdAsync(id) ??
            throw new NullReferenceException("task with this data not found!");

        await _taskRepository.DeleteTaskAsync(id);
    }
}
