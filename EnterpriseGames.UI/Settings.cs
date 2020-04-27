using EnterpriseGames.Core.Models.Context;
using EnterpriseGames.Core.Other;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseGames.UI
{
    internal static class Settings
    {
        internal static EnterpriseContext Context;
        internal static User CurrentUser;

        static Settings()
        {
            Context = new EnterpriseContext(new DbContextOptionsBuilder<EnterpriseContext>()
                .UseSqlite("Filename=desktop_games.db")
                .UseLazyLoadingProxies().EnableSensitiveDataLogging().Options);
        }
    }
}
