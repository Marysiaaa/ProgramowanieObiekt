using System;

namespace ListaZadanPO
{
    internal partial class Program
    {
        public enum Plec { K, M }

        public class Osoba 
        {
            private string _imie;
            private string _nazwisko;
            private int _rokUrodzenia;
            private int _waga;
            private int _wzrost;
            private bool _okulary;
            private  Plec _plec;
            private const string PAN = "Pan";
            private const string PANI = "Pani";

            public Osoba(string imie, string nazwisko, int rokUrodzenia,int waga,int wzrost ,bool okulary, Plec plec)
            {
                _imie = imie;
                _nazwisko = nazwisko;
                _rokUrodzenia = rokUrodzenia;
                _waga = waga;
                _wzrost = wzrost;
                _okulary = okulary;
                _plec = plec;
            }

            public string Imie { get => _imie; set => _imie = value; }
            public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
            public int RokUrodzenia { get => _rokUrodzenia; set => _rokUrodzenia = value; }
            public void PanPani()
            {
                string tytul=null;
                if (_plec == Plec.M)
                {
                    tytul = PAN;
                }
                else if(_plec == Plec.K)
                {
                    tytul = PANI;

                }
                Console.WriteLine($"Dyrektorem jest {tytul} {Imie} {Nazwisko}");
            }
            public int ObliczWiek()
            {
                int obecnyRok =  DateTime.Now.Year;
                return obecnyRok - RokUrodzenia;
            }

        }
        }
    }

