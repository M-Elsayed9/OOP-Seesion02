using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {

        #region Properties
        public int Id { get; set; }

        public string Model { get; set; }
        
        public double Speed { get; set; }

        #endregion

        #region Constructors


        public Car()
        {

        }
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("Car constructor with 3 parameters");
        }

        // Consutructor chaining
        public Car(int id, string model): this(id, model, 190)
        {
           //Id = id;
           //Model = model;
           //Speed = 190; 
           Console.WriteLine("Car constructor with 2 parameters");
        }

        public Car(int id):this(id, "Audi", 200)
        {
            //Id = id;
            //Model = "Audi";
            //Speed = 190;
            Console.WriteLine("Car constructor with 1 parameters");
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Id: {Id}, Model: {Model}, Speed: {Speed}";
        }
        #endregion
    }
}
