using System;
using System.Collections.Generic;

namespace EnterpriseGames.Core.Models
{
    public partial class Order
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long ProductPriceId { get; set; }
        public long CustomerId { get; set; }
        public byte[] Instituted { get; set; }
    }
}
