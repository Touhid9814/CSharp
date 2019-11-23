using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Framework
{
    public class ValidationHelper
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return false;

            return true;
        }
        
        public static bool IsIntValid(string value, bool neg = false)
        {
            try
            {
                int k = Int32.Parse(value);

                if (neg)
                    return k >= 0;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
