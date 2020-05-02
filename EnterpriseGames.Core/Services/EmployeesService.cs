using EnterpriseGames.Core.Mappers;
using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Models.Context;
using EnterpriseGames.Core.Other;
using System.Linq;

namespace EnterpriseGames.Core.Services
{
    public class EmployeesService : BaseService<Employee>
    {
        public EmployeesService(EnterpriseContext context) : base(context) { }

        public Record[] GetOrders(long employeeId)
        {
            var empl = Find(employeeId);

            if (empl != null)
                return empl.Order.Select(x => x.OrderToRecord()).ToArray();

            return default;
        }

        public void SetOrders(long employeeId, Record[] orders)
        {
            var empl = Find(employeeId);

            if (empl != null)
            {





            }
        }
    }
}