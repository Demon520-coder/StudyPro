using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficApp
{
    public static class StringExt
    {
        public static int TryToInt(this string str)
        {
            int temp;
            int.TryParse(str, out temp);
            return temp;
        }
    }
}
