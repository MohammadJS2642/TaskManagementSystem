namespace Domain.Entities;

public class UserTask
{
    public Int64 Id { get; set; }
    public bool IsActive { get; set; }
    public bool IsCompleted { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Int64? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Int64? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public UserTask()
    {

    }

    public UserTask(string title, string description)
    {
        Title = title;
        Description = description;
        IsCompleted = false;
        IsActive = true;
        CreatedAt = DateTime.Now;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public void Update(string? title, string? description, bool isActive)
    {
        Title = title;
        Description = description;
        IsCompleted = false;
        IsActive = isActive;
        ModifiedAt = DateTime.Now;
    }
}
