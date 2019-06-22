using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Extensions
{
    public static class DateTimeExtension
    {
        public static bool SameMonthOfSameYear(this DateTime dateTime, DateTime targetTime)
        {
            return dateTime.Year == targetTime.Year && dateTime.Month == targetTime.Month;
        }
    }
}
