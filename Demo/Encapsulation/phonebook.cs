using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Phonebook
    {
        #region Attributes
        private string[] Names ;
        private int[] Numbers;
        private int size ;

        #region Proprties

        public int Size
        {
            get;
        }
        #endregion

        #region Constructors
        public Phonebook(int size)
        {
            this.Size = size;
            Names = new string[size];
            Numbers = new int[size];
        }

        #endregion
        #endregion
    }
}
