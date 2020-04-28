using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Models.Context;

namespace EnterpriseGames.Core.Services
{
    public class ProductsService : BaseService<Product>
    {
        public ProductsService(EnterpriseContext context) : base(context)
        {
        }
    }
}
