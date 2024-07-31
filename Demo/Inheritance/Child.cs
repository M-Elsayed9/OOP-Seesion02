using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
 

        public int Z { get; set; }


        public Child(int x, int y, int z):base(x, y)
        {
            Z = z;
            Console.WriteLine("Child constructor with 3 parameters");
        }

        //public override int Product()
        //{
        //    return X * Y * Z;
        //}

        public new int Product() // masking the parent version
        {
            return base.Product() * Z;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}
