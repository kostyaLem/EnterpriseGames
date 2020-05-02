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

        public void SetOrder(long empID, Record record)
        {
            var empl = Find(empID);

            var order = new Order()
            {
                Id = record.ID,
                DateClosed = record.DateClosed,
                DateCreated = record.DateCreated,
                OrderState = (int)record.State,
                Employee = empl,
                Customer = _context.Customer.Find(record.CustomerID)
            };

            // order.OrderItem.Add(new OrderItem() { Order = order, Product = _context.ProductPriceHistory.First() });

            for (int i = 0; i < record.Items.Count; i++)
            {
                order.OrderItem.Add(new OrderItem() { Order = order, Product = _context.ProductPriceHistory.Find(record.Items[i].ProductID) });
            }
            empl.Order.Add(order);

            _context.Attach(empl).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }
    }
}