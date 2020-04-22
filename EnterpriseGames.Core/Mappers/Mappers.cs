using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Other;
using System;

namespace EnterpriseGames.Core.Mappers
{
    internal static class Mappers
    {
        internal static User EmployeeToUser(this Employee emp)
        {
            return new User()
            {
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
