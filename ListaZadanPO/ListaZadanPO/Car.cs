namespace ListaZadanPO
{
    public class Car
    {
        private string _marka;
        private int _rok;
        private string _model;
        private int _iloscDrzwi;
        private double _pojemnoscSilnika;

        public double SrednieSpalanie;

        public Car(string marka, int rok, string model, int iloscDrzwi, double pojemnoscSilnika)
        {
            Marka = marka;
            Rok = rok;
            Model = model;
            IloscDrzwi = iloscDrzwi;
            PojemnoscSilnika = pojemnoscSilnika;
        }

        public string Marka
        {
            set { _marka = value; }
        }

        public int Rok
        {
            set
            {
                if (value <= 1769 || value > 2017)
                {
                    Console.WriteLine("Podano złe dane");
                    _rok = 0;
                }
                else
                {
                    _rok = value;
                }
            }
        }

        public string Model
        {
            set { _model = value; }
        }

        public int IloscDrzwi
        {
            set { _iloscDrzwi = value; }
        }

        public double PojemnoscSilnika
        {
            set { _pojemnoscSilnika = value; }
        }

        public void Wyswietl()
        {
            Console.WriteLine("Marka samochodu: " + _marka);
            Console.WriteLine("Rok produkcji: " + _rok);
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return SrednieSpalanie * (dlugoscTrasy / 100);
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            var spalanie = ObliczSpalanie(dlugoscTrasy);
            return spalanie * cenaPaliwa;
        }

        public static void OpiszTyp(string Marka, int Rok, string Model)
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Rok: {Rok}");
        }

        public static void OpiszTyp(int iloscDrzwi, double pojemnoscSilnika)
        {
            Console.WriteLine($"Marka: {iloscDrzwi}");
            Console.WriteLine($"Model: {pojemnoscSilnika}");
        }

        public static void OpiszTyp(string Marka, string Model)
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
        }

    }
}
