using System;
using System.Collections.Generic;

namespace EnterpriseGames.Core.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductGenre = new HashSet<ProductGenre>();
            ProductPriceHistory = new HashSet<ProductPriceHistory>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Created { get; set; }
        public byte[] Instituted { get; set; }

        public virtual ICollection<ProductGenre> ProductGenre { get; set; }
        public virtual ICollection<ProductPriceHistory> ProductPriceHistory { get; set; }
    }
}
