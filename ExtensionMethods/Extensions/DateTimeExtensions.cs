using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now - thisObj;
            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F2",CultureInfo.InvariantCulture) + " horas.";
            }
            else
            {
                return duration.TotalDays.ToString("F2", CultureInfo.InvariantCulture) + " Dias.";
            }
        }
    }
}
