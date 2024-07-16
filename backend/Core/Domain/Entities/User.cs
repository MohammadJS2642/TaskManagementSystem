namespace Domain.Models;

public class User
{
    public Int64 Id { get; set; }
    public required string Username { get; set; }
    public bool IsActive { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public Int64 CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Int64 ModifiedBy { get; set; }
    public DateTime ModifiedAt { get; set; }

    public List<Task>? Tasks { get; set; }
}
