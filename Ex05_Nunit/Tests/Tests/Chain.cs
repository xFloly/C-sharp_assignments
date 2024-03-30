using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Chain
    {
        public static string? ChainStrings(string? a, string? b)
        {
            if (a == null || b == null) return null;
            return a + b;
        }
    }
}
