namespace rzutowanie
{
    internal partial class Program
    {
        public class Transakcja
        {
            public Transakcja(DateTime data, decimal kwota, RodzajTransakcji rodzaj)
            {
                Data = data;
                Kwota = kwota;
                Rodzaj = rodzaj;
            }

            public DateTime Data { get; }
            public decimal Kwota { get; }
            public RodzajTransakcji Rodzaj { get; }
        }
    }
}