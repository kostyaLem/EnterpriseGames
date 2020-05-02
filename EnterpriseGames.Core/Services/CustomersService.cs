using EnterpriseGames.Core.Mappers;
using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Models.Context;
using EnterpriseGames.Core.Other;
using System.Linq;

namespace EnterpriseGames.Core.Services
{
    public class CustomersService : BaseService<Customer>
    {
        public CustomersService(EnterpriseContext context) : base(context)
        {
        }

        public CustomerDto[] GetCustomers()
        {
            return GetAll().Select(x => x.CustomerToDto()).ToArray();
        }
    }
}
