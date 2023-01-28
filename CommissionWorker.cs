using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiNhanVien
{
    public class CommissionWorker : Employee
    {
        private decimal commission;
        private int quantity;
        private decimal salary;

        public CommissionWorker(string firstNameValue, string lastNameValue, decimal salaryValue, decimal commissionValue, int quantityValue,
            int birthMonth, int birthDay, int birthYear,
            int hireMonth, int hireDay, int hireYear) : base(firstNameValue, lastNameValue, birthMonth, birthDay, birthYear, hireMonth, hireDay, hireYear)
        {
            salary = salaryValue;
            commission = commissionValue;
            quantity = quantityValue;
        }


        public override decimal Earnings()
        {
            return Salary.tinhLuong(salary, commission, quantity);
        }

        public override string ToString()
        {
            return "CommissionWorker: " + base.ToString();
        }
    }
}
