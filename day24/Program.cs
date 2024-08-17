using System;
namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var sala = new Room(3);
            sala.RoomSoldOut += OnRoomSoldOut;
            sala.ReserveSeat();
            sala.ReserveSeat();
            sala.ReserveSeat();
            sala.ReserveSeat();
            sala.ReserveSeat();
        }

        static void OnRoomSoldOut(object sender, EventArgs e){
            Console.WriteLine("Sala lotada");
        }
    }
    public class Room
    {
        public Room(int Seats)
        {
            Seats = Seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;
        public int Seats { get; set; }   

        public void ReserveSeat(){
            seatsInUse++;
            if(seatsInUse >= Seats)
            {
                //evento fechado
                OnRoomSoldOut(EventArgs.Empty);
            } else {
                Console.WriteLine("Assento reservado!!");
            }
        }

        public event EventHandler RoomSoldOut;

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOut;
            handler?.Invoke(this, e);
        }
    }
}