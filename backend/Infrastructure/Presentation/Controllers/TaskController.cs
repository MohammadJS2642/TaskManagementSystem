using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation;

[ApiController]
[Route("api/[controller]")]
public class TaskController(TaskService taskService) : ControllerBase
{
    private readonly TaskService _taskService = taskService;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTaskById(long id)
    {
        var taskData = await _taskService.GetByIdAsync(id);
        if (taskData == null)
            return NotFound();
        return Ok(taskData);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var taskData = await _taskService.GetAllTasksAsync();
        return Ok(taskData);
    }

    [HttpPost]
    public async Task<IActionResult> GetTaskByName([FromBody] UserTask userTask)
    {
        await _taskService.AddTaskAsync(userTask);
        return Ok();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateTask(UserTask userTask)
    {
        await _taskService.UpdateTaskAsync(userTask);
        return NoContent();
    }

    [HttpPut("{id}/complete")]
    public async Task<IActionResult> MarkTaskAsComplete(long id)
    {
        var taskData = await _taskService.GetByIdAsync(id);
        if (taskData == null)
            return NotFound();
        await _taskService.MarkAsCompleted(taskData);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTask(long id)
    {
        await _taskService.DeleteTaskAsync(id);
        return NoContent();
    }
}
