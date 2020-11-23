using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public static class MyLinq
    {
        public static int MyCount<T>( this IEnumerable<T> sequence)
        {
            int counter = 0;
            foreach (var item in sequence)
            {
                counter++;
            }

            return (counter);
        }
    }
}
