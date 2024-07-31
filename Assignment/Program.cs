using Assignment.Part03;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 2

            //Person[] Persons = new Person[3];

            //Person person1 = new Person();
            //person1.Name = "John";
            //person1.Age = 25;

            //Person person2 = new Person("Mohamed", 26);

            //Person person3 = new Person("ali", 27);

            //Persons[0] = person1;
            //Persons[1] = person2;
            //Persons[2] = person3;

            //for (int i = 0; i < Persons.Length; i++)
            //{
            //    Console.WriteLine(Persons[i].ToString());
            //}

            //Person[] Persons = new Person[3];

            //for (int i = 0; i < Persons.Length; i++)
            //{
            //    Console.WriteLine("Enter the name of the person: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter the age of the person: ");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Persons[i] = new Person(name, age);
            //}

            //for (int i = 0; i < Persons.Length; i++)
            //{
            //    Console.WriteLine("Name: " + Persons[i].Name + " Age: " + Persons[i].Age);
            //} 
            #endregion

            #region Part 3

            //Employee[] employees = new Employee[3];

            //employees[0] = new Employee(employees.Length, "John", SecurityLevel.Guest, 1000, new HireDate(1, 1, 1), Gender.M);
            //employees[1] = new Employee(employees.Length, "Mohamed", SecurityLevel.DBA, 2000, new HireDate(2, 2, 2), Gender.M);
            //employees[2] = new Employee(employees.Length, "Ali", SecurityLevel.DBA | SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary, 3000, new HireDate(3, 3, 3) , Gender.M);

            Employee[] employees = new Employee[3];

            employees[0] = Employee.CreateEmployee(SecurityLevel.DBA);
            employees[1] = Employee.CreateEmployee(SecurityLevel.Guest);
            employees[2] = Employee.CreateEmployee(SecurityLevel.DBA | SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            #endregion

            #region Q7

            employees = Employee.SortEmployees(employees);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

    #endregion
}
   
