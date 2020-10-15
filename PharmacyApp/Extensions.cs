using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    static class Extensions
    {
        public static bool IsEmpty(string[]arr,string text)
        {
            foreach (var array in arr)
            {
                if (array==text)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
