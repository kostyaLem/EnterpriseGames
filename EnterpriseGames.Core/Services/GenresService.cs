using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Models.Context;

namespace EnterpriseGames.Core.Services
{
    public class GenresService : BaseService<Genre>
    {
        public GenresService(EnterpriseContext context) : base(context)
        {
        }
    }
}
