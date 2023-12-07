using System;
using static ListaZadanPO.Program;

namespace ListaZadanPO
{
    internal partial class Program
    {
        public class Zespolone
        {
            public double Rzeczywista { get; set; }
            public double Urojona { get; set; }
            public Zespolone(double rzeczywista, double urojona)
            {
                Rzeczywista = rzeczywista;
                Urojona = urojona;
            }
            public static Zespolone Dodaj(Zespolone liczba1, Zespolone liczba2)
            {
                double nowaRzeczywista = liczba1.Rzeczywista + liczba2.Rzeczywista;
                double nowaUrojona = liczba1.Urojona + liczba2.Urojona;
                return new Zespolone(nowaRzeczywista, nowaUrojona);
            }
            public static Zespolone Odejmij(Zespolone liczba1, Zespolone liczba2)
            {
                double nowaRzeczywista = liczba1.Rzeczywista - liczba2.Rzeczywista;
                double nowaUrojona = liczba1.Urojona - liczba2.Urojona;
                return new Zespolone(nowaRzeczywista, nowaUrojona);
            }

            public static Zespolone Pomnoz(Zespolone liczba1, Zespolone liczba2)
            {
                double nowaRzeczywista = liczba1.Rzeczywista * liczba2.Rzeczywista - liczba1.Urojona * liczba2.Urojona;
                double nowaUrojona = liczba1.Rzeczywista * liczba2.Urojona + liczba1.Urojona * liczba2.Rzeczywista;
                return new Zespolone(nowaRzeczywista, nowaUrojona);
            }

            public static Zespolone Podziel(Zespolone liczba1, Zespolone liczba2)
            {
                double mianownik = liczba2.Rzeczywista * liczba2.Rzeczywista + liczba2.Urojona * liczba2.Urojona;
                double nowaRzeczywista = (liczba1.Rzeczywista * liczba2.Rzeczywista + liczba1.Urojona * liczba2.Urojona) / mianownik;
                double nowaUrojona = (liczba1.Urojona * liczba2.Rzeczywista - liczba1.Rzeczywista * liczba2.Urojona) / mianownik;
                return new Zespolone(nowaRzeczywista, nowaUrojona);
            }

            public void Wyswietl()
            {
                Console.WriteLine($"{Rzeczywista} + {Urojona}i");
            }
        }
        public class Koszyk
        {
            private List<Produkt> listaProduktów;
            public Koszyk()
            {
                listaProduktów = new List<Produkt>();
            }
            public void DodajProdukt(Produkt produkt)
            {
                listaProduktów.Add(produkt);
            }
            public void PokazIleJestArtykolowWKoszykuISume()
            {
                Console.WriteLine("Ilość produktów w koszyku: "+listaProduktów.Count());
                var sumaProduktow = 0;
                foreach (var produkt in listaProduktów)
                {
                    sumaProduktow +=produkt.Cena;
                }
                Console.WriteLine($"Suma cen produktów w koszyku: {sumaProduktow} zł");

            }
        }
        public class Produkt
        {
            private string _nazwa;
            private int _cena;
            public string Nazwa
            {
                get { return _nazwa; }

                set { _nazwa = value; }
            }
            public int  Cena
            {
                get { return _cena; }
                set { _cena= value; }
            }
            public Produkt(string nazwa, int cena)
            {
                _nazwa = nazwa;
                _cena = cena;
                
            }
        }
        static void Main(string[] args)
        {
            var carName = "Mój samochód";
            Console.WriteLine(carName);

            var car1 = new Car("Opel", 1768, "Corsa", 3, 1000);
            car1.Wyswietl();

            var car3 = new Car("Opel", 2015, "Astra", 5, 2000);

            car3.SrednieSpalanie = 6.5;

            Console.WriteLine("Koszt przejazdu: " + car3.ObliczKosztPrzejazdu(180, 7));
            var dyrektor = new Osoba("Grzegorz", "Karolewski",1997,72,175,false,Plec.M);
            Console.WriteLine($"{dyrektor.Imie} {dyrektor.Nazwisko}, {dyrektor.ObliczWiek()} lat");
            dyrektor.PanPani();
            var pacjent = new Pacjent("Maria", "Oleksinska", 160, 55);
            pacjent.WyswietlBMIStatus();
            var laptop = new Produkt("Laptop", 3000);

            var telefon = new Produkt("Telefon", 1500);
            var koszyk = new Koszyk();
            koszyk.DodajProdukt(laptop);
            koszyk.DodajProdukt(telefon);
            koszyk.PokazIleJestArtykolowWKoszykuISume();




            Zespolone liczba1 = new Zespolone(3, 4);
            Zespolone liczba2 = new Zespolone(1, 2);

            Zespolone suma = Zespolone.Dodaj(liczba1, liczba2);
            Zespolone roznica = Zespolone.Odejmij(liczba1, liczba2);
            Zespolone iloczyn = Zespolone.Pomnoz(liczba1, liczba2);
            Zespolone iloraz = Zespolone.Podziel(liczba1, liczba2);

            Console.WriteLine("Suma:");
            suma.Wyswietl();

            Console.WriteLine("Różnica:");
            roznica.Wyswietl();

            Console.WriteLine("Iloczyn:");
            iloczyn.Wyswietl();

            Console.WriteLine("Iloraz:");
            iloraz.Wyswietl();


        }
    }
}
