using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public static class StringExtensions
    {

        static public double ToDouble(this string data)
        {
            return Convert.ToDouble(data);
        }

    }
}
