namespace LesPropriétés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();


            room.Doors.Add(houseDoor);
            house.Rooms.Add(room);
            house.Doors.Add(roomDoor);
        }
    }
}
