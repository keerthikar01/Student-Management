using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management
{
    public static class extension
    {
        public static bool is_lesser(this int value)
        {
            //bool result = false;
            if (value <= 18)
            {
                return true;
            }
            return false;
        }
    }
}
