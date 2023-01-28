using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiNhanVien
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;

        private Date birthDate;
        private Date hireDate;

        public Employee(string firstNameValue, string lastNameValue,
            int birthMonth, int birthDay, int birthYear,
            int hireMonth, int hireDay, int hireYear)
        {
            firstName = firstNameValue;
            lastName = lastNameValue;

            birthDate = new Date(birthMonth, birthDay, birthYear);
            hireDate = new Date(hireMonth, hireDay, hireYear);
        }

        public string FirstName
        {
            get => default;
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get => default;
            set
            {
                lastName = value;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName + "\n" +
                $"Hired: {hireDate.ToDateString()}\nBirthday: {birthDate.ToDateString()}";
        }

        public abstract decimal Earnings();
    }
}
