namespace ListaZadanPO
{
    public class Pacjent
    {
        private string _imie;
        private string _nazwisko;
        private int _wzrost;
        private int _waga;


        public Pacjent(string imie, string nazwisko, int wzrost, int waga)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _wzrost = wzrost;
            _waga = waga;
        }
            public double ObliczBMI()
            {
                double wzrostMetry = _wzrost / 100.0;
                double bmi = _waga / (wzrostMetry * wzrostMetry);
                return bmi;
            }

            public void WyswietlBMIStatus()
            {
                double bmi = ObliczBMI();
                Console.WriteLine($"BMI pacjenta {_imie} {_nazwisko}: {bmi}");

                if (bmi < 18.5)
                {
                    Console.WriteLine("Niedowaga");
                }
                else if (bmi < 24.9)
                {
                    Console.WriteLine("Wartość prawidłowa");
                }
                else if (bmi < 29.9)
                {
                    Console.WriteLine("Nadwaga");
                }
                else
                {
                    Console.WriteLine("Otyłość");
                }
            }

        }
    }

