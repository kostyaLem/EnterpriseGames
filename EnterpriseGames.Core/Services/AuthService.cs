using EnterpriseGames.Core.Mappers;
using EnterpriseGames.Core.Models.Context;
using EnterpriseGames.Core.Other;
using System.Linq;

namespace EnterpriseGames.Core.Services
{
    public class AuthService
    {
        private readonly EnterpriseContext _context;

        public AuthService(EnterpriseContext context)
        {
            _context = context;
        }

        public bool LogIn(string login, byte[] password, out User user)
        {
            var employee = _context.Employee.FirstOrDefault(e => e.Login == login && e.PasswordHash == password);

            if (employee != null)
            {
                user = employee.EmployeeToUser();
                return true;
            }

            user = default;
            return false;
        }
    }
}
