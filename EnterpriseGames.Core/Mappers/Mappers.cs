using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Other;
using System;
using System.Linq;

namespace EnterpriseGames.Core.Mappers
{
    internal static class Mappers
    {
        internal static Record OrderToRecord(this Order order)
        {
            var customer = order.Customer;
            var employee = order.Employee;

            var record = new Record()
            {
                ID = order.Id,
                DateCreated = order.DateCreated,
                DateClosed = order.DateClosed,
                CustomerFullName = string.Join(" ", customer.Surname, customer.Name),
                EmployeeFullName = string.Join(" ", employee.Surname, employee.Name, employee.Patronymic),
                
            };

            record.Items = order.OrderItem.Select(x =>
                                               new Item()
                                               {
                                                   ID = x.Id,
                                                   Name = x.Product.Product.Title,
                                                   Price = x.Product.Price
                                               }).ToArray();

            return record;
        }

        internal static User EmployeeToUser(this Employee emp)
        {
            return new User()
            {
                ID = emp.Id,
                Name = emp.Name,
                Surname = emp.Surname,
                Patronymic = emp.Patronymic,
                Birthday = DateTime.Parse(emp.Birthday),
                Email = emp.Email,
                Phone = emp.Phone,
                Photo = emp.Photo,
                UserType = (UserType)emp.UserType
            };
        }
    }
}
