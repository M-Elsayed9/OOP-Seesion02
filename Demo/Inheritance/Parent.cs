using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Parent
    {

        #region Properties
        public int X { get; set; }

        public int Y { get; set; }

        #endregion

        #region Constructors

        public Parent()
        {
            Console.WriteLine("Parent constructor with no parameters");
        }

        public Parent(int x, int y)
        {

           X = x;
           Y = y;
           Console.WriteLine("Parent constructor with 2 parameters");
        }

        #endregion

        #region Methods

        public /*virtual*/ int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        #endregion
    }
}
