using System;

namespace Bank
{
    public static class Wyswitlacz
    {
        public static void PokazEkranPowitalny()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW BANKU");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.Write("WYBIERZ 1, 2 LUB 3:");
            Console.WriteLine();
        }
        public static void PokazEkranKlientow()
        {
            Console.WriteLine("ID | IMIĘ I NAZWISKO | NR KONTA | SALDO");
            var K1 = Dane.Klient1.ToString();
            Console.WriteLine("1 | Jan Nowak | 001 | " + K1);
            var K2 = Dane.Klient2.ToString();
            Console.WriteLine("2 | Agnieszka Kowalska | 002 | " + K2);
            var K3 = Dane.Klient3.ToString();
            Console.WriteLine("3 | Robert Lewandowski | 003 | " + K3);
            var K4 = Dane.Klient4.ToString();
            Console.WriteLine("4 | Zofia Plucińska | 004 | " + K4);
            var K5 = Dane.Klient5.ToString();
            Console.WriteLine("5 | Grzegorz Braun | 005 | " + K5);
        }
        public static void Klient1Info()
        {
            Console.WriteLine("ZALOGOWANY KLIENT");
            Console.WriteLine("ID: 1");
            Console.WriteLine("IMIĘ I NAZWISKO: Jan Nowak");
            Console.WriteLine("NR KONTA: 001");
            Console.WriteLine("SALDO: " + Dane.Klient1.ToString());
            Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW:");
        }
        public static void Klient2Info()
        {
            Console.WriteLine("ZALOGOWANY KLIENT");
            Console.WriteLine("ID: 2");
            Console.WriteLine("IMIĘ I NAZWISKO: Agnieszka Kowalska");
            Console.WriteLine("NR KONTA: 002");
            Console.WriteLine("SALDO: " + Dane.Klient2.ToString());
            Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW:");
        }
        public static void Klient3Info()
        {
            Console.WriteLine("ZALOGOWANY KLIENT");
            Console.WriteLine("ID: 3");
            Console.WriteLine("IMIĘ I NAZWISKO: Robert Lewandowski");
            Console.WriteLine("NR KONTA: 003");
            Console.WriteLine("SALDO: " + Dane.Klient3.ToString());
            Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW:");
        }
        public static void Klient4Info()
        {
            Console.WriteLine("ZALOGOWANY KLIENT");
            Console.WriteLine("ID: 4");
            Console.WriteLine("IMIĘ I NAZWISKO: Zofia Plucińska");
            Console.WriteLine("NR KONTA: 004");
            Console.WriteLine("SALDO: " + Dane.Klient4.ToString());
            Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW:");
        }
        public static void Klient5Info()
        {
            Console.WriteLine("ZALOGOWANY KLIENT");
            Console.WriteLine("ID: 5");
            Console.WriteLine("IMIĘ I NAZWISKO: Grzegorz Braun");
            Console.WriteLine("NR KONTA: 005");
            Console.WriteLine("SALDO: " + Dane.Klient5.ToString());
            Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW:");
        }

    }
}