﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.IO;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json;
using static rzutowanie.Program;
using static rzutowanie.Program.Konto;

namespace rzutowanie
{
    internal partial class Program
    {
        public enum KONTO { FIRMOWE, PRYWATNE }

        static void Main(string[] args)
        {
            BaseClass myObj = new BaseClass();
            DerrivedClass myObj2 = new DerrivedClass();
            NextDerrivedClass myObj3 = new NextDerrivedClass();
            // Stworz konto firmowe

            Console.WriteLine("Podaj id konta klienta");
            var idKontaKlienta = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj typ konta");
            var typKonta = Console.ReadLine();

            var listaTransakcji = new List<Transakcja>();
            var files = Directory.GetFiles(".\\kontaKlientow");// pobiera nazwy plikow
            if (files.Contains($".\\kontaKlientow\\{idKontaKlienta}.txt"))
            {
                var json = File.ReadAllText(".\\kontaKlientow\\1234.txt");
                listaTransakcji = JsonSerializer.Deserialize<List<Transakcja>>(json);
                if (listaTransakcji == null)
                {
                    listaTransakcji = new List<Transakcja>();
                }
            }

            Konto? konto1 = null;

            if (typKonta.ToLower() == "firmowe")
            {
                konto1 = new KontoFirmowe(idKontaKlienta, new Wlasciciel("Maria", "Oleksinska", "Ciechanow", "marika.olek@wp.pl"), listaTransakcji);
            }
            else if (typKonta.ToLower() == "prywatne")
            {
                konto1 = new KontoPrywatne(idKontaKlienta, new Wlasciciel("Maria", "Oleksinska", "Ciechanow", "marika.olek@wp.pl"), listaTransakcji);
            }
            else
            {
                throw new Exception("Podano zły typ konta");
            }

            konto1.WpłataNaKonto(200);
            konto1.ZapiszTransakcje();
        }

        public class KontoFirmowe : Konto
        {
            public KontoFirmowe(int kontoId, Wlasciciel wlasciciel, List<Transakcja> transakcje)
                : base(kontoId, wlasciciel, transakcje)
            {
            }

            public void PrzelewUS(decimal kwota, Konto konto)
            {
                if (kwota > 0)
                {
                    PrzelewNaKonto(kwota, konto);
                }
                else if (kwota <= 0)
                {
                    throw new ArgumentException("Kwota musi być większa od zera");
                }
            }

            public void PrzelewZUS(decimal kwota, Konto konto)
            {
                if (kwota > 0)
                {
                    PrzelewNaKonto(kwota, konto);
                }
                else if (kwota <= 0)
                {
                    throw new ArgumentException("Kwota musi być większa od zera");
                }
            }
        }

        public class KontoPrywatne : Konto
        {
            public KontoPrywatne(int kontoId, Wlasciciel wlasciciel, List<Transakcja> transakcje)
                : base(kontoId, wlasciciel, transakcje)
            {
            }

            public void przelewWynadgrodzenia(decimal wynagrodzenie)
            {
                if (DateTime.Now.Day == 18)
                {
                    Zaksiegowanie(new Transakcja(DateTime.Now, wynagrodzenie, RodzajTransakcji.Zaksiegowanie));
                }
                else
                {
                    throw new InvalidOperationException("Wypłaty są przelewane tylko 18 dnia miesiąca");
                }
            }

            public void przelew500()
            {
                var kwota = 500;
                if (DateTime.Now.Day == 10)
                {
                    Zaksiegowanie(new Transakcja(DateTime.Now, kwota, RodzajTransakcji.Zaksiegowanie));
                }
                else
                {
                    throw new InvalidOperationException("500+ jest przelewane tylko 10 dnia miesiąca");
                }
            }
        }

        public class Konto
        {
            private List<Transakcja> _historiaTransakcji;

            public Konto(int id, Wlasciciel wlasciciel, List<Transakcja> transakcje)
            {
                Id = id;
                Wlasciciel = wlasciciel;
                _historiaTransakcji = transakcje;
            }

            public int Id { get; private set; }

            public Wlasciciel Wlasciciel { get; }

            public decimal Saldo
            {
                get
                {
                    decimal saldo = 0;
                    foreach (var transakcja in _historiaTransakcji.OrderBy(x => x.Data))
                    {
                        saldo += transakcja.Kwota;
                    }
                    return saldo;
                }

            }

            public decimal WpłataNaKonto(decimal kwota)
            {
                _historiaTransakcji.Add(new Transakcja(DateTime.Now, kwota, RodzajTransakcji.Wplata));
                return Saldo;
            }

            public decimal WypłataZKonta(decimal kwota)
            {
                _historiaTransakcji.Add(new Transakcja(DateTime.Now, -kwota, RodzajTransakcji.Wyplata));

                return Saldo;
            }

            public decimal Zaksiegowanie(Transakcja transakcja)
            {
                _historiaTransakcji.Add(transakcja);
                return Saldo;
            }

            public decimal Wyksiegowanie(Transakcja transakcja)
            {
                _historiaTransakcji.Add(transakcja);
                return Saldo;
            }

            public void PrzelewNaKonto(decimal kwota, Konto konto)
            {

                if (kwota > 0)
                {
                    Wyksiegowanie(new Transakcja(DateTime.Now, -kwota, RodzajTransakcji.Wyksiegowanie));
                    konto.Zaksiegowanie(new Transakcja(DateTime.Now, kwota, RodzajTransakcji.Zaksiegowanie));
                }
                else if (kwota <= 0)
                {
                    throw new ArgumentException("Kwota musi być większa od zera");
                }
            }

            public void ZapiszTransakcje()
            {
                var json = JsonSerializer.Serialize(_historiaTransakcji);
                Directory.CreateDirectory(".\\kontaKlientow");
                File.WriteAllLines($".\\kontaKlientow\\{Id}.txt", new string[] { json });
            }

            public string PokazKonto()
            {
                return $"Numer konta: {Id}, Dane właściciela: {Wlasciciel.Imie} {Wlasciciel.Nazwisko}, Saldo: {Saldo}, Adres: {Wlasciciel.Adres}, email: {Wlasciciel.Email}";
            }

            public class BaseClass
            {

            }
            public class DerrivedClass : BaseClass
            {

            }
            public class NextDerrivedClass : DerrivedClass
            {

            }
        }
    }
}