using System.Windows.Forms;
namespace ListaZadanNaPo_cz2
{
    internal class Program
    {
        public class Car
        {
            private double pojemnoscSilnika;
            private string marka;
            private static int iloscKol;
            private Car()
            {
                this.pojemnoscSilnika = 0.0;
                this.marka = "Brak";
            }

            static Car()
            {
                iloscKol = 4;
            }

            public Car(double pojemnoscSilnika, string marka)
            {
                this.pojemnoscSilnika = pojemnoscSilnika;
                this.marka = marka;
            }

            public double PojemnoscSilnika { get; private set; }
            public string Marka { get; private set; }
            public static int IloscKol { get => iloscKol; set => iloscKol = value; }

            public static Car Create(double pojemnoscSilnika, string marka)
            {
                return new Car(pojemnoscSilnika, marka);
            }
            public double PobierzPojemnoscSilnika()
            {
                return this.pojemnoscSilnika;
            }

            public string PobierzMarke()
            {
                return this.marka;
            }

            ~Car()
            {
                MessageBox.Show("Zwalniam pamiec");
            }
        }
        static void Main(string[] args)
        { 
            var car1=new Car(2000, "Honda");
            var car2 = new Car(4000, "Opel");
            Car samochod1 = Car.Create(2.0, "Toyota");
            Console.WriteLine(samochod1.PobierzMarke());
            Console.WriteLine(samochod1.PobierzPojemnoscSilnika());
            Console.WriteLine("Obiekt 2: Pojemność silnika = {0}, Marka = {1}", Car.Create(1.5, "Ford").PobierzPojemnoscSilnika(), Car.Create(1.5, "Ford").PobierzMarke());
            Console.WriteLine(); Console.WriteLine("Ilość kół: " + Car.IloscKol);


        }
    }
}