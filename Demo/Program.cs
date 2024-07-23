using Demo.Encapsulation;
using System.Net.Http.Headers;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            //Employee emp = new Employee(1, "John Doe", 50000);

            //Employee emp = new Employee(name: "John", id: 10, salary: 2000);

            //Console.WriteLine(emp);

            //emp.Id = 100; // set id directly through attributes
            //Console.WriteLine(emp.Id); // get id directly through attributes

            //Employee.name = "Mona"; // invalid after making it private
            //emp.SetName("Mona");

            //Console.WriteLine(emp.GetName());

            //emp.Salary = 3000; // set salary using property as a setter 
            //Console.WriteLine(emp.Salary); recomendded way to get salary using property as a getter
            // as it easy to use 

            //Employee emp = new Employee(10, "aliaa", 6000, 30);

            //Console.WriteLine(emp);

            //Console.WriteLine(emp.Deducation); 
            #endregion

            Phonebook phonebook = new Phonebook(20);       
        
        }
    }
}
