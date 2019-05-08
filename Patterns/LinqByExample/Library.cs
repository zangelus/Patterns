using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqByExample
{
    static class Library
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> items, Func<T, bool> test)
        {
            foreach (var i in items)
            {
                if (test(i))
                {
                    yield return i;
                }
            }
        }
    }
}
