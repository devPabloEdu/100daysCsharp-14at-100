using System;
namespace Day35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }
        static void OnRoomSoldOut(object sender, EventArgs e){
            Console.WriteLine("Sala Lotada!");
        }
    }

    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            SeatsInUse = 0;
        }
        private int SeatsInUse = 0;
        public int Seats {get; set;}

        public void ReserveSeat()
        {
            SeatsInUse++;
            if(SeatsInUse >= Seats)
            {
               OnRoomSoldOut(EventArgs.Empty);
            } else {
                Console.WriteLine("Assento reservado");
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }

}