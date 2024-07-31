using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Demo
{
    internal class TypeC : TypeA
    {
        public TypeC()
        {
            //X = 10; // invalid X is protected private => Not inherited
            Y = 20; // valid Y is protected => inherited as protected private
            Z = 30; // valid Z is intrnal protected => inherited as internal protected
            //M = 40; // invalid Not inherited
        }

    }
}
