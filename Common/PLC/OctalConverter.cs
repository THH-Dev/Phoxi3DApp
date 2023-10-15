using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.PLC
{
    public static class OctalConverter
    {
        public static string hex2Octal(string hexvalue)
        {
            return Convert.ToString(Convert.ToInt32(hexvalue, 16), 8);
        }

        public static string octal2hex(string octalvalue)
        {
            return Convert.ToString(Convert.ToInt32(octalvalue, 8), 16);
        }
    }
}
