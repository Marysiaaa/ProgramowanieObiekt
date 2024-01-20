using System;
namespace Vehicle
{


    public class Vehicle
    {
    }

    public class Car : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem");
        }

    }

    public class Bicycle : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę rowerem");
        }

        // Tu możesz dodać dodatkowe właściwości i metody dla klasy Bicycle
    }

    // Krok 13: Tworzenie interfejsu

    public interface IRideable
    {
        void Ride();
    }

    // Krok 14: Użycie klas i interfejsu

    class Program
    {
        static void Main()
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Ride();         // Wyświetli: "Jadę samochodem"
            bicycle.Ride();     // Wyświetli: "Jadę rowerem"
            Osoba osoba = new Osoba();
            osoba.Graj();

            var gitara = new Gitara();
            osoba.UstawInstrument(gitara);
            osoba.Graj();

            gitara.PodlaczWzmacniacz();
            osoba.Graj();

            osoba.UstawInstrument(new Skrzypce());
            osoba.Graj();
        }

        static void ZagrajMelodie(List<Iskrzypek> skrzypcy, List<Igitarzysta> gitarzysci)
        {
            skrzypcy[0].Graj();

            Thread.Sleep(1000);

            gitarzysci[0].Graj();
        }
    }

    public interface IInstrument
    {
        void Graj();
    }

    public class Gitara : IInstrument
    {
        private bool czyWzmocnionySygnal = false;

        public void PodlaczWzmacniacz()
        {
            czyWzmocnionySygnal = true;
        }

        public void Graj()
        {
            if (czyWzmocnionySygnal)
            {
                Console.WriteLine("Gram na wzmocnionej gitarze");
                return;
            }

            Console.WriteLine("Gram na gitarze");
        }
    }

    public class Skrzypce : IInstrument
    {
        public void Graj()
        {
            Console.WriteLine("Gram na skrzypcach");
        }
    }
}