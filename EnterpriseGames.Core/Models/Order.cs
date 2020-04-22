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
        public long? EmployeeId { get; set; }
        public string Instituted { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductPriceHistory ProductPrice { get; set; }
    }
}
