﻿namespace ListaZadanPo_cz3
{
    internal class Program
    {
        public class Student :Osoba
        {
            
            private  int _rok;
            private  int _numerGrupy;
            private  int _numerAlbumu;

            public Student(string imie, string nazwisko,int rokUrodzenia,int rok, int numerGrupy, int numerAlbumu,string miejsceZamieszkania )
                : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
            { 
                _rok = rok;
                _numerGrupy = numerGrupy;
                _numerAlbumu = numerAlbumu;
            }
            public void WypiszInfo()
            {
                Console.WriteLine("Imie " + Imie);
                Console.WriteLine("Nazwisko" + Nazwisko);
                Console.WriteLine("Rok Urodzenia " + RokUrodzenia);
                Console.WriteLine("Numer Grupy"+_numerGrupy);
                Console.WriteLine("Numer Albumu"+_numerAlbumu);

            }

        }
        public class Osoba
        {
            protected string _imie;
            protected string _nazwisko;
            protected int _rokUrodzenia;
            protected string  _miejsceZamieszkania;

            public Osoba(string imie, string nazwisko,int rokUrodzenia, string miejsceZamieszkania)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                _rokUrodzenia = rokUrodzenia;
                _miejsceZamieszkania = miejsceZamieszkania;
            }

            public string Imie { get => _imie; set => _imie = value; }
            public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
            public int RokUrodzenia { get => _rokUrodzenia; set => _rokUrodzenia = value; }

            public void WypiszInfo()
            {
                Console.WriteLine("Imie "+_imie);
                Console.WriteLine("Imie " + _nazwisko);
                Console.WriteLine("Imie " + _rokUrodzenia);

            }
            public int ObliczWiek()
            {
                int obecnyRok = DateTime.Now.Year;
                return obecnyRok - RokUrodzenia;
            }
        }
        static void Main(string[] args)
        {
            var student = new Student("Maria", "Oleksinska", 2002, 2002, 2, 173496,"Kraków");

            Console.WriteLine(student.ObliczWiek());
            var student1 = new Student("Ala", "Kowalska", 2002, 2002, 2, 175641,"Ciechanów");
            var student2 = new Student("Jan", "Nowak", 2003, 2003, 4, 17541,"Warszawa");
            var osoba1 = new Osoba("Anna", "Kowalczyk", 2002, "Ciechanów");
            var osoba2 = new Osoba("Martyna", "Jeleniewska", 2002, "Wrocław");
            osoba1 = student1;
           // student2 = osoba2;


        }
    }
}