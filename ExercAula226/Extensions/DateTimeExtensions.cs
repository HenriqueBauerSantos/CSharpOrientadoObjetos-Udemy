using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercAula226 {
    static class DateTimeExtensions {
        public static string ElapsedTime(this DateTime date) {
            TimeSpan result = DateTime.Now.Subtract(date);
            if (result.TotalHours < 24)
            {
                return result.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else {
                return result.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
