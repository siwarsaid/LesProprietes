using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPropriétés
{
    internal class House
    {
        public List<Room> Rooms { get; } = new List<Room>();
        public List<Door> Doors { get; }= new List<Door>();

    }
}
