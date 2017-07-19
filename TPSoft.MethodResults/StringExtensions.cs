using System;

namespace TPSoft.MethodResults
{
    internal static class StringExtensions
    {
        public static bool IsEmpty(this string value)
        {
            return value == null || value.Trim() == string.Empty;
        }

        public static bool AnyChar(this string value)
        {
            return !value.IsEmpty();
        }

        public static bool EqualsIgnoreCase(this string value, string comparable)
        {
            return value.Equals(comparable, StringComparison.OrdinalIgnoreCase);
        }

        public static bool NotEqualsIgnoreCase(this string value, string comparable)
        {
            return !value.EqualsIgnoreCase(comparable);
        }
    }
}