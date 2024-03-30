using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Chain2
    {
        public static string ChainStrings(string? a, string? b)
        {
            if (a == null)
            {
                throw new ArgumentNullException(nameof(a), "given strings must not be null");
            }
            if (b == null)
            {
                throw new ArgumentNullException(nameof(b), "given strings must not be null");
            }
            return a + b;
        }
    }
}
