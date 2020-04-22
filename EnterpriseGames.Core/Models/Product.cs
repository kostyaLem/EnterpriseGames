using System;
using System.Collections.Generic;

namespace EnterpriseGames.Core.Models
{
    public partial class Product
    {
        public Product()
        {
            Order = new HashSet<Order>();
            ProductGenre = new HashSet<ProductGenre>();
            ProductPriceHistory = new HashSet<ProductPriceHistory>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string Created { get; set; }
        public string Instituted { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<ProductGenre> ProductGenre { get; set; }
        public virtual ICollection<ProductPriceHistory> ProductPriceHistory { get; set; }
    }
}
