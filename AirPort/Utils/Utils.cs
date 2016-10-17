using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.Utils
{
    static class Utils
    {
        public static string TrimValueOrConcatSpace(string ch, int sizeTrim)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return "";
            if (ch.Length > sizeTrim)
            {
                ch = ch.Remove(sizeTrim);
            }
            else
            {
                var tmp = new string(' ', (sizeTrim - ch.Length));
                return ch + tmp;
            }
            return ch;
        }
    }
}
