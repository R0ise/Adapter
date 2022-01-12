using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // Впереди вода, придется плыть на лодке
            Boat boat = new Boat();
            // используем адаптер
            ITransport BoatTransport = new BoatToTransportAdapter(boat);
            // продолжаем плыть по воде
            driver.Travel(BoatTransport);

            Console.Read();
        }
    }
}
