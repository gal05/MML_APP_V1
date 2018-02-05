using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP_MML_V1.Utilities
{
    public class Util
    {
        public static string noNullString(string val)
        {
            if (val == null)
            {
                return "null";
            }
            return val;
        }
    }
}