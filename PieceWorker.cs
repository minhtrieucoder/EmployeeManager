using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiNhanVien
{
    public class PieceWorker : Employee
    {
        private decimal wagePerPiece;
        private int quantity;

        public PieceWorker(string firstNameValue, string lastNameValue, decimal wagePerPieceValue, int quantityValue,
            int birthMonth, int birthDay, int birthYear,
            int hireMonth, int hireDay, int hireYear) : base(firstNameValue, lastNameValue, birthMonth, birthDay, birthYear, hireMonth, hireDay, hireYear)
        {
            wagePerPiece = wagePerPieceValue;
            quantity = quantityValue;
        }

        public int Quantity
        {
            get => default;
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public decimal WagePerPiece
        {
            get => default;
            set
            {
                if (value > 0)
                    wagePerPiece = value;
            }
        }

        public override decimal Earnings()
        {
            return Salary.tinhLuong(wagePerPiece, quantity);
        }

        public override string ToString()
        {
            return "PieceWorker: " + base.ToString();
        }
    }
}
