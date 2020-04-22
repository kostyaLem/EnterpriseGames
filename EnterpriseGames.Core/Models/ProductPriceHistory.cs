using System;
using System.Collections.Generic;

namespace EnterpriseGames.Core.Models
{
    public partial class ProductPriceHistory
    {
        public ProductPriceHistory()
        {
            Order = new HashSet<Order>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Instituted { get; set; }
        public double Price { get; set; }
        public long IsDeleted { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
