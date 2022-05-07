using System;

namespace Tekrar5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Mustafa",
                Surname = "Qasimzade",
                Salary = 2000
            };

            Department department = new Department()
            {
                Name = "Af Business",
                EmployeeLimit = 2


            };

            try
            {
                department.AddEmployee(employee);
            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.Message);

            }
        }

    }
}