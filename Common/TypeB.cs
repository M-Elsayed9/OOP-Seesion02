using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB : TypeA
    {
        //public void Print()
        //{
        //    TypeA Obj = new TypeA();
        //    // Obj.X = 10; // invalid

        //    // Obj.Y = 20; // invalid
        //    Obj.Z = 30; // valid
        //    // Obj.M = 40; // invalid
        //}

        public TypeB()
        {
            X = 10; // X is protected private => inherited as protected private
            Y = 20; // valid Y is protected => inherited as protected
            Z = 30; // valid Z is internal protected => inherited as internal protected
            //M = 40; // invalid Not inherited
        }
    }
}
