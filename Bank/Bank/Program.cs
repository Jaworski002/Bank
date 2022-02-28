using System;

namespace Bank
{
    static class Program
    {
      static void Main(string[] args)
      {
            int Counter1 = 0;
            while (Counter1 == 0)
            {
                Wyswitlacz.PokazEkranPowitalny();

                String wpisane1 = Console.ReadLine();
                bool Prawidlowosc = Int32.TryParse(wpisane1, out int odpowiedz);
                if (!Prawidlowosc)
                {
                    Console.Clear();
                    Console.WriteLine("Musisz podać liczbe 1, 2 albo 3");
                }
                else
                {
                    int odpowiedz1 = 1;
                    int odpowiedz2 = 2;
                    int odpowiedz3 = 3;

                    if (odpowiedz == odpowiedz1)
                    {
                        Console.Clear();
                        Wyswitlacz.PokazEkranKlientow();

                    }
                    else if (odpowiedz == odpowiedz2)
                    {
                        int Counter2 = 0;
                        Console.Clear();
                        while (Counter2 == 0)
                        {
                            Console.WriteLine("ZALOGUJ SIĘ WYBIERAJĄC ID KLIENTA:");
                            String wpisane2 = Console.ReadLine();
                            bool Prawidlowosc1 = Int32.TryParse(wpisane2, out int odp);
                            if (odp == 1)
                            {
                                int Counter3 = 0;
                                Console.Clear();
                                while (Counter3 == 0)
                                {
                                    Wyswitlacz.Klient1Info();
                                    String wpisane3 = Console.ReadLine();
                                    if (wpisane3 == "002")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient1.Saldo)
                                            {
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo + odp2;
                                                Dane.Klient1.Saldo = Dane.Klient1.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "003")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient1.Saldo)
                                            {
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo + odp2;
                                                Dane.Klient1.Saldo = Dane.Klient1.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "004")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient1.Saldo)
                                            {
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo + odp2;
                                                Dane.Klient1.Saldo = Dane.Klient1.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "005")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient1.Saldo)
                                            {
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo + odp2;
                                                Dane.Klient1.Saldo = Dane.Klient1.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                            }
                            else if (odp == 2)
                            { 
                                    int Counter3 = 0;
                                    Console.Clear();
                                while (Counter3 == 0)
                                {
                                    Wyswitlacz.Klient1Info();
                                    String wpisane3 = Console.ReadLine();
                                    if (wpisane3 == "001")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient2.Saldo)
                                            {
                                                Dane.Klient1.Saldo = Dane.Klient1.Saldo + odp2;
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "003")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient2.Saldo)
                                            {
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo + odp2;
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "004")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient2.Saldo)
                                            {
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo + odp2;
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "005")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient2.Saldo)
                                            {
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo + odp2;
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }
                                    }
                                
                                    else
                                    {
                                        Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }


                            }
                            else if (odp == 3)
                            {
                                int Counter3 = 0;
                                Console.Clear();
                                while (Counter3 == 0)
                                {
                                    Wyswitlacz.Klient1Info();
                                    String wpisane3 = Console.ReadLine();
                                    if (wpisane3 == "002")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient3.Saldo)
                                            {
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo + odp2;
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "001")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient3.Saldo)
                                            {
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo + odp2;
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "004")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient3.Saldo)
                                            {
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo + odp2;
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "005")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient3.Saldo)
                                            {
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo + odp2;
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                            }
                            else if (odp == 4)
                            {
                                int Counter3 = 0;
                                Console.Clear();
                                while (Counter3 == 0)
                                {
                                    Wyswitlacz.Klient1Info();
                                    String wpisane3 = Console.ReadLine();
                                    if (wpisane3 == "002")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient4.Saldo)
                                            {
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo + odp2;
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "003")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient4.Saldo)
                                            {
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo + odp2;
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "001")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient4.Saldo)
                                            {
                                                Dane.Klient1.Saldo = Dane.Klient1.Saldo + odp2;
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "005")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient4.Saldo)
                                            {
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo + odp2;
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                            }
                            else if (odp== 5)
                            {
                                int Counter3 = 0;
                                Console.Clear();
                                while (Counter3 == 0)
                                {
                                    Wyswitlacz.Klient1Info();
                                    String wpisane3 = Console.ReadLine();
                                    if (wpisane3 == "002")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient5.Saldo)
                                            {
                                                Dane.Klient2.Saldo = Dane.Klient2.Saldo + odp2;
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "003")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient5.Saldo)
                                            {
                                                Dane.Klient3.Saldo = Dane.Klient3.Saldo + odp2;
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "004")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient5.Saldo)
                                            {
                                                Dane.Klient4.Saldo = Dane.Klient4.Saldo + odp2;
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (wpisane3 == "001")
                                    {
                                        int Counter4 = 0;
                                        Console.Clear();
                                        while (Counter4 == 0)
                                        {
                                            Console.WriteLine("PODAJ KWOTĘ PRZELEWU:");
                                            String wpisane4 = Console.ReadLine();
                                            bool Prawidlowosc2 = Int32.TryParse(wpisane4, out int odp2);
                                            if (odp2 < Dane.Klient5.Saldo)
                                            {
                                                Dane.Klient1.Saldo = Dane.Klient1.Saldo + odp2;
                                                Dane.Klient5.Saldo = Dane.Klient5.Saldo - odp2;
                                                Wyswitlacz.PokazEkranKlientow();
                                                Console.ReadLine();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Musisz podać ID klienta");

                            }
                        }
                    }
                    else if (odpowiedz == odpowiedz3)
                    {
                        return;
                    }
                }
            }
      }

    }
}
