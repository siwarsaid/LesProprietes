using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LesPropriétés
{
    internal class Door
    {
        public bool IsOpen { get; }

        public Door()
        {
            IsOpen = false;
        }
        public void Open()
        {
            if (IsOpen)
            {
                Console.WriteLine("Door already opened. Ain't done anything.");
            }
            
        }

        public void Close()
        {
            if (!IsOpen)
            {
                Console.WriteLine("Door already closed. Ain't done anything.");
            }
           
        }
    }
}
