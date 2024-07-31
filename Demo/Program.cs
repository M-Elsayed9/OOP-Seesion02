using Demo.Encapsulation;
using Demo.Inheritance;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation / Indexer
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

            Phonebook Note = new Phonebook(3);

            //Note.AddPerson(0, "John", 123456);
            //Note.AddPerson(1, "Doe", 654321);
            //Note.AddPerson(2, "Jane", 987654);

            ////int PhoneNumber = Note.GetPersonNumber("Doe");
            ////Console.WriteLine(PhoneNumber);
            ////Console.WriteLine(PhoneNumber == -1 ? "Person not found" : $"Phone number is {PhoneNumber}");

            ////Note["Ali"] = 123456; // set phone number for Ali using indexer as a setter
            ////Console.WriteLine(Note["Ali"]); // get phone number for Ali using indexer as a getter


            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}
            #endregion

            #region Class

            ///Car C1;
            // Declare reference from type Car
            // can reer to an object from type Car
            // or an object from any class derived from Car
            // CLR will allocated 4 bytes in the stack to store the reference C1
            // Zero bytes allocated in the heap

            ///C1 = new Car();
            // New => 
            // 1- Allocate memory in the heap to store the object [16 bytes for this object]
            // 2- initialize the allocated bytes with default values 
            // 3- call user defined constructor if exists
            // 4- assign the reference to the object in the heap to the reference in the stack

            //Car C1 = new Car(10, "BMW", 290);

            //Console.WriteLine(C1);

            //Car C2 = new Car(20, "byd");

            //Console.WriteLine(C2);

            //Car C3 = new Car(30);

            //Console.WriteLine(C3);
            #endregion

            #region Inheritance
            Parent P = new Parent(10, 20);

            Console.WriteLine(P);

            Console.WriteLine(P.Product());

            Child C = new Child(10, 20, 30);
            Console.WriteLine(C);
            Console.WriteLine(C.Product());

            #endregion

        }
    }
}
