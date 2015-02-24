using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboUnit
{
    public static class Extensions
    {
        public static bool Contains (this string value, string searchTerm, StringComparison strComp)
        {
            return value.IndexOf(searchTerm, strComp) > -1;
        }
    }
}
