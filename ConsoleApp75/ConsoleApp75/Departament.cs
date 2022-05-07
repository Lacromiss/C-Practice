using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar5
{
    internal class Department
    {
        public string Name;
        public int EmployeeLimit;
        public double SalaryLimit;
        public Employee[] Employees = new Employee[0];



        public void AddEmployee(Employee employee)
        {
            if (EmployeeLimit > Employees.Length)
            {

                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;

                return;
            }

            throw new Exception("Isci limitini kecdiniz");
        }
    }
}