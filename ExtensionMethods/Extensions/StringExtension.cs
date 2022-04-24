using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    static class StringExtension
    {
        public static string Cut(this string thisObj,int value)
        {
            if(thisObj.Length <= value)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0,value);
            }
        }

    }
}
