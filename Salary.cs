using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiNhanVien
{
    public class Salary
    {
        // tinh luong boss
        public static decimal tinhLuong (decimal salaryValue)
        {
            decimal salary = salaryValue;
            return salary;
        }

        // tinh luong commission worker
        public static decimal tinhLuong (decimal salaryValue, decimal commissionValue, int quantityValue)
        {
            decimal salary = salaryValue + commissionValue * quantityValue;
            return salary;
        }

        // tinh luong hours worker
        public static decimal tinhLuong (decimal wageValue, double hoursWorkedValue)
        {
            if (hoursWorkedValue <= 40)
                return wageValue * Convert.ToDecimal(hoursWorkedValue);
            else
            {
                decimal basePay = wageValue * Convert.ToDecimal(40);
                decimal overtimePay = wageValue * 1.5M * Convert.ToDecimal(hoursWorkedValue - 40);
                return basePay + overtimePay;
            }
        }

        // tinh luong piece worker 
        public static decimal tinhLuong(decimal wagePerPieceValue, int quantityValue)
        {
            decimal salary = wagePerPieceValue * quantityValue;
            return salary;
        }
    }
}
