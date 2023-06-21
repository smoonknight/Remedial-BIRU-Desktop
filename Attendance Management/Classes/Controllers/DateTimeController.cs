using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management.Classes.Controllers
{
    class DateTimeController
    {
        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day)) // Map each day to a date
                             .ToList(); // Load dates into a list
        }

        public static string GetIndonesianMonth(int month)
        {
            CultureInfo indonesianFormatted = new CultureInfo("id-ID");
            
            return indonesianFormatted.DateTimeFormat.GetMonthName(month);
        }
    }
}
