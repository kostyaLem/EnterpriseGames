using System;

namespace EnterpriseGames.Core.Other
{
    public class User
    {
        public string Surname { get; internal set; }
        public string Name { get; internal set; }
        public string Patronymic { get; internal set; }
        public string Phone { get; internal set; }
        public string Email { get; internal set; }
        public byte[] Photo { get; internal set; }
        public DateTime Birthday { get; internal set; }
        public UserType UserType { get; internal set; }
    }
}
