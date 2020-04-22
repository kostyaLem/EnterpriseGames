using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EnterpriseGames.UI.Utility
{
    internal static class Helpers
    {
        internal static bool IsAnyEmpty<T>(Predicate<T> predicate, params T[] values)
        {
            return values.Any(value => predicate(value));
        }

        internal static byte[] CreateHash(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));

            var provider = MD5.Create();
            return provider.ComputeHash(Encoding.Default.GetBytes(value.Trim()));
        }
    }
}
