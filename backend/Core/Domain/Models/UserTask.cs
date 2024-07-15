namespace Domain.Models;

public class UserTask
{
    public Int64 Id { get; set; }
    public bool IsActive { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Int64 CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Int64 ModifiedBy { get; set; }
    public DateTime ModifiedAt { get; set; }
}
