using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiNhanVien
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int theMonth, int theDay, int theYear)
        {
            if (theMonth > 0 && theMonth <= 12)
                month = theMonth;
            else
            {
                month = 1;
                Console.WriteLine($"Thang {theMonth} khong hop le. Tam thoi dua ve 1.");
            }
            year = theYear;
            day = CheckDay(theDay);
        }

        private int CheckDay(int theDay)
        {
            int[] daysPerMonth =
                {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (theDay > 0 && theDay <= daysPerMonth[month])
                return theDay;
            if (month == 2 && theDay == 29 &&
                (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                return theDay;

            Console.WriteLine($"Ngay {theDay} khong hop le. Tam thoi dua ve 1.");
            return 1;
        }

        public string ToDateString()
        {
            return month + "/" + day + '/' + year;
        }
    }
}
