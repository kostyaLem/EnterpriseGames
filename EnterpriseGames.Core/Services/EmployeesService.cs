﻿using EnterpriseGames.Core.Mappers;
using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Models.Context;
using EnterpriseGames.Core.Other;
using System.Collections.Generic;
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

        public Record[] GetAllOrders()
        {
            return _context.Order.Select(x => x.OrderToRecord()).ToArray();
        }

        public void AddOrder(long empID, Record record)
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

            for (int i = 0; i < record.Items.Count; i++)
                order.OrderItem.Add(new OrderItem() { Order = order, Product = _context.ProductPriceHistory.Find(record.Items[i].ProductID) });

            empl.Order.Add(order);

            _context.SaveChanges();
        }

        public void Update(long empID, Record record)
        {
            var empl = Find(empID);

            var order = empl.Order.FirstOrDefault(x => x.Id == record.ID);
            order.DateClosed = record.DateClosed;
            order.OrderState = (int)record.State;
            order.Customer = _context.Customer.Find(record.CustomerID);

            // Добавляем в order те, которых нет в items
            foreach (var item in record.Items)
                if (!order.OrderItem.ToList().Exists(x => x.Product.Id == item.ProductID))
                    order.OrderItem.Add(new OrderItem() { Order = order, Product = _context.ProductPriceHistory.First(x => x.Id == item.ProductID) });

            // Удаляем из order те, которых нет в items
            var removed = new List<OrderItem>();
            foreach (var orderItem in order.OrderItem.Where(x => x.Product != null))
                if (!record.Items.Exists(x => x.ProductID == orderItem.Product.Id))
                    removed.Add(orderItem);

            removed.ForEach(x => order.OrderItem.Remove(x));

            _context.SaveChanges();
        }
    }
}