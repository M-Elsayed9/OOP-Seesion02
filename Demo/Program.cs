using Demo.Encapsulation;

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

            Phonebook Note = new Phonebook(3);
            
            Note.AddPerson(0, "John", 123456);
            Note.AddPerson(1, "Doe", 654321);
            Note.AddPerson(2, "Jane", 987654);
            
            //int PhoneNumber = Note.GetPersonNumber("Doe");
            //Console.WriteLine(PhoneNumber);
            //Console.WriteLine(PhoneNumber == -1 ? "Person not found" : $"Phone number is {PhoneNumber}");
            
            
            //Note["Ali"] = 123456; // set phone number for Ali using indexer as a setter
            //Console.WriteLine(Note["Ali"]); // get phone number for Ali using indexer as a getter


            for (int i = 0; i < Note.Size; i++)
            {
                Console.WriteLine(Note[i]);
            }
        }
    }
}
