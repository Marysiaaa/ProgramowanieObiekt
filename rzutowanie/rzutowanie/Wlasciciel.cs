namespace rzutowanie
{
    internal partial class Program
    {
        public class Wlasciciel
        {
            public Wlasciciel(string imie, string nazwisko, string adres, string email)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                Adres = adres;
                Email = email;
            }

            public string Imie { get; private set; }
            public string Nazwisko { get; private set; }
            public string Adres { get; private set; }
            public string Email { get; private set; }
        }
    }
}