using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Infrastructure.Contracts.Security
{
    public interface IUserPasswordService
    {
        string GenerateSalt();
        string HashPassword(string salt, string password);
        (string password, string salt) HashPasswordAndGetSalt(string salt, string password);
        bool ValidatePassword(string salt, string password);
    }
}
