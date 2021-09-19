using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{
    public class ValidateFever
    {
        public static bool IsNotNull(float? value)
        {
            if (value.HasValue)
            {
                return false;
            }
            return true;
        }
    }
}
