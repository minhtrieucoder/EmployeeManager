using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiNhanVien
{
    public class HourlyWorker : Employee
    {
        private decimal wage;
        private double hoursWorked;

        public HourlyWorker(string firstNameValue, string lastNameValue, decimal wageValue, double hoursWorkedValue,
            int birthMonth, int birthDay, int birthYear,
            int hireMonth, int hireDay, int hireYear) : base(firstNameValue, lastNameValue, birthMonth, birthDay, birthYear, hireMonth, hireDay, hireYear)
        {
            wage = wageValue;
            hoursWorked = hoursWorkedValue;
        }

        public double HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                if (value > 0)
                    hoursWorked = value;
            }
        }

        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value > 0)
                    wage = value;
            }
        }

        public override decimal Earnings()
        {
            return Salary.tinhLuong(wage, hoursWorked);
        }

        public override string ToString()
        {
            return "HourlyWorker: " + base.ToString();
        }
    }
}
