using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Models.Context;
using EnterpriseGames.Core.Other;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

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
                .UseLazyLoadingProxies().Options);
        }

        internal static ListViewItem MapToItem(this Genre genre)
        {
            return new ListViewItem(genre.Name) { Tag = genre };
        }
    }
}
