using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.CommonLib.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}
