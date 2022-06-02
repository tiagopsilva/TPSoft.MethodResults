using System.Collections.Generic;
using System.Linq;

namespace MethodResults
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }
    }
}