using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session1
{
    internal struct PhoneBook
    {
        private string[] names;
        private long[] numbers;
        int size;
        int counter;
        public PhoneBook(int size)
        {
            Size = size;
            names = new string[size];
            numbers = new long[size];
            counter = 0;
        }

        #region Full property
        public int Size
        {
            get { return size; }
            set
            {
                if (value > 0)
                    size = value;
            }
        }
        #endregion

        #region Indexer
        public long this[string name]
        {
            // update phone number
            set
            {
                for (int i = 0; i < names.Length; i++)
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        return;
                    }
            }
            // get phone number
            get
            {
                for (int i = 0; i < names.Length; i++)
                    if (names[i] == name)
                        return numbers[i];
                return -1;
            }
        }

        public string this[long number]
        {
            // update name
            set
            {
                for (int i = 0; i < numbers.Length; i++)
                    if (numbers[i] == number)
                    {
                        names[i] = value;
                        return;
                    }
            }
            // get name
            get
            {
                for (int i = 0; i < numbers.Length; i++)
                    if (numbers[i] == number)
                        return names[i];
                return "";
            }
        }
        #endregion
        public void AddPerson(string name, long number)
        {
            if (counter < size)
            {
                names[counter] = name ?? "no name";
                numbers[counter] = number;
                ++counter;
            }
        }

    }//struct
}//namespace
