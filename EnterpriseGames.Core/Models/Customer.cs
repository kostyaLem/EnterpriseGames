﻿using System;
using System.Collections.Generic;

namespace EnterpriseGames.Core.Models
{
    public partial class Customer
    {
        public long Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public long? Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Additional { get; set; }
    }
}