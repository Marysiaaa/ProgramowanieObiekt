namespace ZadaniaNaCwicznia_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cw4_1();
            //Cw4_2();
            // Cw4_3();
            //Cw4_4();
            // Cw4_5();
            //  Cw4_6();
            // Cw4_7();
           // Cw4_8();
            //Cw4_9();
            // Cw4_10();
            // Cw4_11();
            // Cw4_12();
            // Cw4_13(); 
            //Cw4_14();
        }



        public static void Cw4_1()
        {
            Console.Write("Podaj liczbe elementów tablicy:");
            var liczbaElementow = Console.ReadLine();
            Console.WriteLine("Podaj elewmenty tablicy odzielone przecinkiem ");
            var userinput = Console.ReadLine();
            string[] numbers = userinput.Split(',');
            int[] intNumber = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int result))
                {
                    intNumber[i] = result;
                }
                else
                {
                    Console.WriteLine("Kolego żle podales liczby");
                }


            }
            foreach (int number in intNumber)
            {
                Console.WriteLine(number);
            }

        }
        public static void Cw4_2()
        {
            int[] tab1 = new int[10] { 1, 3, 4, 5, 6, 6, 7, 8, 89, 8 };
            int[] tab2 = new int[10];
            for (int i = 0; i < tab1.Length; i++)
            {
                tab2[i] = tab1[i];
            }
            foreach (int number in tab2)
            {
                Console.WriteLine(number);
            }
        }
        public static void Cw4_3()
        {
            Console.Write("Podaj liczbe elementów tablicy:");
            var liczbaElementow = Console.ReadLine();
            Console.WriteLine("Podaj elewmenty tablicy odzielone przecinkiem ");
            var userinput = Console.ReadLine();
            string[] numbers = userinput.Split(',');
            int[] intNumber = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int result))
                {
                    intNumber[i] = result;
                }
                else
                {
                    Console.WriteLine("Kolego żle podales liczby");
                }


            }
            foreach (int number in intNumber)
            {
                Console.WriteLine(number);
            }
            var max = intNumber.Max();
            var min = intNumber.Min();
            var lenght = intNumber.Length;
            var indexMax = Array.IndexOf(intNumber, max);
            var indexMin = Array.IndexOf(intNumber, min);
            Console.WriteLine("Maksymalna liczba " + max + "o indeksie " + indexMax);
            Console.WriteLine("Minimalna liczba " + min + "o indeksie " + indexMin);
            var suma = 0;

            foreach (int number in intNumber)
            {
                suma += number;
            }
            Console.WriteLine("Suma elementow wynosi: " + suma);

            var srednia = suma / lenght;
            Console.WriteLine("Srednia arytmetyczna wynosi" + srednia);

            var iloscDodatnich = 0;
            var iloscUjemnych = 0;
            for (int i = 0; i < intNumber.Length; i++)
            {
                if (intNumber[i] > 0)
                {
                    iloscDodatnich++;
                }
                else if (intNumber[i] > 0)
                {
                    iloscUjemnych++;
                }

            }
            Console.WriteLine("Liczba dodatnich elementów : " + iloscDodatnich);
            Console.WriteLine("Liczba ujemnych elementów :" + iloscUjemnych);


        }
        public static void Cw4_4()
        {
            int[] tablica = new int[100];
            var iloscLiczbpierwszychwTablicy = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                var rand = new Random();
                var r = rand.Next(1, 100);
                tablica[i] = r;


            }
            for (int i = 0; i < tablica.Length; i++)
            {

                if (CzyLiczbaPierwsza(tablica[i]))
                {
                    Console.Write(tablica[i] + ",");
                    iloscLiczbpierwszychwTablicy++;

                }

            }
            Console.WriteLine("Ilość liczb pierwszych: " + iloscLiczbpierwszychwTablicy);



            static bool CzyLiczbaPierwsza(int liczba)
            {
                if (liczba <= 1)
                {
                    return false;
                }

                for (int i = 2; i * i <= liczba; i++)
                {
                    if (liczba % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
        public static void Cw4_5()
        {
            int[] tab1 = new int[10] { 1, 3, 4, 5, 6, 6, 7, 8, 89, 8 };
            int[] tab2 = new int[10];
            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = tab1[(i + tab1.Length - 1) % tab1.Length];
            }


            Console.WriteLine("TABLICA 1 ");
            foreach (int i in tab1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("TABLICA 2 ");
            foreach (int number in tab2)
            {
                Console.WriteLine(number);
            }

        }
        public static void Cw4_6()
        {
            int[,] tablica = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablica[i, j] = i * 5 + j + 1;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tablica[i, j] + "\t"); // "\t" to znak tabulacji
                }
                Console.WriteLine(); // Nowa linia po każdym wierszu
            }
            int sumaPrzekatnej = 0;
            for (int i = 0; i < 5; i++)
            {
                sumaPrzekatnej += tablica[i, i];
            }

            Console.WriteLine("Suma elementów na głównej przekątnej: " + sumaPrzekatnej);
        }
        public static void Cw4_7()
        {
            int[,] tab1 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] tab2 = { { 2, 1 }, { 4, 4 }, { 5, 5 } };

            int rows = tab1.GetLength(0); // Liczba wierszy
            int cols = tab1.GetLength(1); // Liczba kolumn

            if (rows == tab2.GetLength(0) && cols == tab2.GetLength(1))
            {
                int[,] result = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = tab1[i, j] + tab2[i, j];
                    }
                }

                // Wyświetlenie wynikowej macierzy
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(result[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nie można dodać macierzy o różnych rozmiarach.");
            }


        }
        public static void Cw4_8()
        {
            string[,] dniTygodnia = new string[3, 7];


            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[0, 1] = "wtorek";
            dniTygodnia[0, 2] = "środa";
            dniTygodnia[0, 3] = "czwartek";
            dniTygodnia[0, 4] = "piątek";
            dniTygodnia[0, 5] = "sobota";
            dniTygodnia[0, 6] = "niedziela";


            dniTygodnia[1, 0] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[1, 2] = "wednesday";
            dniTygodnia[1, 3] = "thursday";
            dniTygodnia[1, 4] = "friday";
            dniTygodnia[1, 5] = "saturday";
            dniTygodnia[1, 6] = "sunday";


            dniTygodnia[2, 0] = "montag";
            dniTygodnia[2, 1] = "dienstag";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[2, 3] = "donnerstag";
            dniTygodnia[2, 4] = "freitag";
            dniTygodnia[2, 5] = "samstag";
            dniTygodnia[2, 6] = "sonntag";


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(dniTygodnia[i, j] + " ");
                }
                Console.WriteLine();
            }

        }


        public static void Cw4_9()
        {
            Console.WriteLine("Wpisz zdanie ");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            string[] zdanie = input.Split(' ');
            var liczbaWyrazow = zdanie.Length;
            Console.WriteLine("Liczba wyrazów: " + liczbaWyrazow);
        }
        public static void Cw4_10()
        {
            Console.WriteLine("Podaj date w formacie DD-MM-RRRR ");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            string[] data = input.Split('-');
            int[] intData = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (int.TryParse(data[i], out int result))
                {
                    intData[i] = result;
                }
                else
                {
                    Console.WriteLine("Kolego podales zla date ");
                }

            }
            switch (intData[1])
            {
                case 1:
                    Console.WriteLine("Styczeń");
                    break;
                case 2:
                    Console.WriteLine("Luty");
                    break;
                case 3:
                    Console.WriteLine("Marzec");
                    break;
                case 4:
                    Console.WriteLine("Kwiecien");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Czerwiec");
                    break;
                case 7:
                    Console.WriteLine("Lipiec");
                    break;
                case 8:
                    Console.WriteLine("Sierpien");
                    break;
                case 9:
                    Console.WriteLine("Wrzesień");
                    break;
                case 10:
                    Console.WriteLine("Październik");
                    break;
                case 11:
                    Console.WriteLine("Listopad");
                    break;
                case 12:
                    Console.WriteLine("Grudzien");
                    break;
                default:
                    Console.WriteLine("Podales zly miesiac");
                    break;
            }


        }
        public static void Cw4_11()
        {
            string tekst = "ala ma kota";
            for (int i = 0; i < tekst.Length; i++)
            {
                char znak = tekst[i];
                int lZnaków = 0;

                if (znak != ' ') // Pomijamy spacje
                {
                    for (int j = 0; j < tekst.Length; j++)
                    {
                        if (tekst[j] == znak)
                        {
                            lZnaków++;
                        }
                    }

                    Console.WriteLine("Znak '" + znak + "' wystąpił " + lZnaków + " razy");
                }
            }
        }
        public static void Cw4_12()
        {
            var iloscWierszy = 0;
            string tekst = "W pare godzin póżniej, gdy noc zbierała się do odejscia,\n" +
                "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                "co ono oznacza.Był głodny. Wiec poszedł do spiżarni,\n" +
                "wgramolił sie na krzesło, sięgnął na górną półkę, ale nic nie znalazł.\n";
            for (int i = 0; i < tekst.Length; i++)
            {
                Console.Write(tekst[i]);
            }
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == '\n')
                {
                    iloscWierszy++;
                }
            }
            Console.WriteLine("Liczba wierszy: " + iloscWierszy);
            var iloscZnakow = 0;
            var pozycjaWiersza = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != '\n')
                {
                    iloscZnakow++;

                }
                else
                {
                    Console.WriteLine("iloscZnakow znaków w wierszu" + pozycjaWiersza + " " + iloscZnakow);
                    pozycjaWiersza++;
                    iloscZnakow = 0;
                }

            }
            Console.WriteLine("IloscZnakow znaków w wierszu " + pozycjaWiersza + ": " + iloscZnakow);

        }
        public static void Cw4_13()
        {
            string tekst = "Kiedy idzie sie po miód zbalonikiem, to trzeba sie starać, żeby pszczoły nie widziały, po co sie idzie -odpowiedział Puchatek ";
            string[] tekstTab = tekst.Split(' ');

            for (int i = 0; i < tekstTab.Length; i++)
            {
                string wyrazAnalizowany = tekstTab[i];
                int iloscWystapien = 0;

                for (int j = 0; j < tekstTab.Length; j++)
                {
                    if (tekstTab[j] == wyrazAnalizowany)
                    {
                        iloscWystapien++;

                    }

                }
                Console.WriteLine(wyrazAnalizowany + " Ilosc wystapien " + iloscWystapien);


            }
        }



        public static void Cw4_14()
        {
            string[] identyfikatory = new string[5] { "KOMG-2002", "BH-2010", "TGT-2011", "GKA-2022", "MKA-2013" };
            int obecnyRok = DateTime.Now.Year;

            for (int i = 0; i < identyfikatory.Length; i++)
            {
                string identyfikator = identyfikatory[i];

                string rokZakupuStr = identyfikator.Substring(identyfikator.Length - 4);
                int rokZakupu;

                if (int.TryParse(rokZakupuStr, out rokZakupu))
                {
                    int lataOdZakupu = obecnyRok - rokZakupu;

                    Console.WriteLine($"Środek trwały o identyfikatorze {identyfikator} ma {lataOdZakupu} lat od zakupu.");
                }
                else
                {
                    Console.WriteLine($"Błąd w identyfikatorze: {identyfikator}");
                }

            }
        }










    }
}
