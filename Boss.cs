using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiNhanVien
{
    public class Boss : Employee
    {
        private decimal salary;

        public Boss(string firstNameValue, string lastNameValue, decimal salaryValue,
            int birthMonth, int birthDay, int birthYear,
            int hireMonth, int hireDay, int hireYear) : base(firstNameValue, lastNameValue, birthMonth, birthDay, birthYear, hireMonth, hireDay, hireYear)
        {
            salary = salaryValue;
        }

        public override decimal Earnings()
        {
            return Salary.tinhLuong(salary);
        }

        public override string ToString()
        {
            return "Boss: " + base.ToString();
        }
    }
}
