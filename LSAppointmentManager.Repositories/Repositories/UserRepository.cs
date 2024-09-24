using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LSAppointmentManager.Persistance.Repositories
{
    public class UserRepository
    {
        private readonly LSAppointmentManagerContext _context;

        public UserRepository(LSAppointmentManagerContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserAsync(string username)
        {
            return await _context.Users.FirstAsync(x => x.Username.Equals(username));
        }

        public async Task<User> SaveUserAsync(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return user;    
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
