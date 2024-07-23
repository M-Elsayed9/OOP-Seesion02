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
        #endregion
        
        #region Proprties

        public int Size { get; } // read only property 
        
        
        #endregion

        #region Constructors
        public Phonebook(int size)
        {
            this.Size = size;
            Names = new string[size];
            Numbers = new int[size];
        }


        #endregion


        #region Methods

        public void AddPerson(int Position, string PersonName, int PhoneNumber)
        {
            if (Position < 0 || Position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            if (PersonName is not null && Numbers is not null)
            {

                Names[Position] = PersonName;
                Numbers[Position] = PhoneNumber;
            }
        }
        #endregion

        #region Getter - Setter 

        public int GetPersonNumber(string PersonName)
        {
            if (Names is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (Names[i] == PersonName)
                    {
                        return Numbers[i];
                    }
                }
            }

            return -1;
        }

        public void SetPersonNumber(string PersonName, int PhoneNumber)
        {
            if (Names is not null)
            {
                for (int i = 0; i < size; i++)
                    if (Names[i] == PersonName)
                    {
                        Numbers[i] = PhoneNumber;
                        break;
                    }
            }
        }
        #endregion
    }
}
