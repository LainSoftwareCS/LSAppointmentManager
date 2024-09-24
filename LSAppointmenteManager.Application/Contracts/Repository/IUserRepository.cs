
using LSAppointmentManager.Entities;

namespace LSAppointmenteManager.Application.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string username);
        Task<User> UpdateUserAsync(User user);
        Task<User> SaveUserAsync(User user);
        Task<List<User>> GetAllAsync();
    }
}
