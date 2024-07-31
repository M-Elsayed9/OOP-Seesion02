using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part03
{
    [Flags]
    public enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
    }

    public enum Gender
    {
        M, F
    }

    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HireDate HireDate { get; set; }
        public Gender Gender { get; set; }

        public Employee() { }

        public Employee(Employee _employee)
        {
            Id = _employee.Id;
            Name = _employee.Name;
            Salary = _employee.Salary;
            Gender = _employee.Gender;
            SecurityLevel = _employee.SecurityLevel;
            HireDate = new HireDate(_employee.HireDate);
        }

        public static Employee CreateEmployee(SecurityLevel security)
        {
            Employee employee = new Employee();

            employee.SecurityLevel = security;

            string? input;
            int id;
            do
            {
                Console.Write("Enter Employee ID: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out id));

            employee.Id = id;

            Console.Write("Enter Employee Name: ");
            employee.Name = Console.ReadLine();

            do
            {
                Console.Write("Enter Employee Salary: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out id));
            employee.Salary = id;

            employee.HireDate = new HireDate();

            Gender G;
            do
            {
                Console.Write("Enter Employee Gender: ");
                input = Console.ReadLine();

            } while (!Enum.TryParse(input, out G));
            employee.Gender = G;

            return employee;
        }

        public static Employee[] SortEmployees(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int min_Index = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (HireDate.CompartHiringDate(employees[j].HireDate, employees[min_Index].HireDate))
                    {
                        min_Index = j;
                    }
                }

                if (min_Index != i)
                {
                    Employee temp = new Employee(employees[min_Index]);
                    employees[min_Index] = new Employee(employees[i]);
                    employees[i] = temp;
                }
            }
            return employees;
        }

    public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, SecurityLevel: {2}, Salary: {3:C}, HireDate: {4:d}",
                             Id, Name, SecurityLevel, Salary, HireDate);
        }


    }
}
