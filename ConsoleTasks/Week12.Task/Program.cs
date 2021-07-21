using System;

namespace Week12.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bizim parking yerimiz var ve ora 50 eded masin yerlesir.ordan tez-tez masin girir cixir ele
            // event yzinki  5-den az bos yer qalanda event bas versin ve consola yazdirsinki parking-de az ver qalib
            // Bir dene event yazin masinlar cixanda masin sayi 10-dan az olanda desinki parkig bosalir eve gede bilersiz
            Parking parking = new Parking();
            parking.ParkingIncrease += Parking_ParkingIncrease;
            parking.ParkingDecreases += Parking_ParkingDecreases;
            parking.Girir(38);
            parking.Girir(8);
            parking.Cixir(40);
            parking.Cixir(5);


            Console.ReadKey();
        }

        private static void Parking_ParkingDecreases(object sender, ParkEventArgs e)
        {
            Console.WriteLine($"Parkinge {e._girenCixanMasinSayi} masin daxil oldu. Parking-de 5 den az yer qalib.Yer sayi: {e.bosYer}. Masin sayi: {e.carSayi}");
        }

        private static void Parking_ParkingIncrease(object sender, ParkEventArgs e)
        {
            Console.WriteLine($"Parkingden {e._girenCixanMasinSayi} masin cixdi. Masin sayi 10 dan az oldu ,parking bosalir eve gede bilersiz. Masin sayi: { e.carSayi}. Bos yer: {e.bosYer}");
        } 
    }
    class Parking
    {
        int _tutum = 50;
        public delegate void ParkingHandler(object sender, ParkEventArgs e);
        public event ParkingHandler ParkingDecreases;
        public event ParkingHandler ParkingIncrease;
        public void Girir(int say)
        {
            if (_tutum - say >= 0)
            {
                _tutum -= say;
                if (_tutum <= 5)
                    ParkingDecreases?.Invoke(this, new ParkEventArgs(_tutum, say));
            }
        }
        public void Cixir(int say)
        {
            if (_tutum + say <= 50)
            {
                _tutum += say;
                if (50 - _tutum < 10)
                    ParkingIncrease?.Invoke(this, new ParkEventArgs(_tutum, say));
            }
        }
    }
    class ParkEventArgs : EventArgs
    {
        public int carSayi;
        public int bosYer;
        public int _girenCixanMasinSayi;
        public ParkEventArgs(int tutum, int girenCixanMasinSayi)
        {
            carSayi = 50 - tutum;
            bosYer = tutum;
            _girenCixanMasinSayi = girenCixanMasinSayi;
        }
    }
}

