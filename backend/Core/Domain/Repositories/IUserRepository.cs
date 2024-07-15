using Domain.Models;

namespace Domain.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsers();
    Task<User> GetById(int id);
    Task<User> InsertUser(User user);
    Task<User> UpdateUser(Int64 id, User user);
    Task<User> DeleteUser(Int64 userId);
}
