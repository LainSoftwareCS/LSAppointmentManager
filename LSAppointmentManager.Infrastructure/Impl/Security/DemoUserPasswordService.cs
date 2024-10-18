using LSAppointmentManager.Infrastructure.Contracts.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Infrastructure.Impl.Security
{
    public class DemoUserPasswordService : IUserPasswordService
    {
        public string GenerateSalt()
        {
            return "generic_salt";
        }

        public string HashPassword(string salt, string password)
        {
            return "hashedpassword";
        }

        public (string password, string salt) HashPasswordAndGetSalt(string salt, string password)
        {
            return ("hashedpassword", "genericsalt");
        }

        public bool ValidatePassword(string salt, string password)
        {
            return true;
        }
    }
}
