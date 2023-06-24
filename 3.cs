#define zadanie1 // zadanie1 lub zadanie2
#if zadanie1
    using System;
    class Program
    {
        static void Main()
        {
            int rozmiar = 0;

            // Pobranie i walidacja rozmiaru tablicy
            while (rozmiar <= 0 || rozmiar % 2 != 0)
            {
                Console.Write("Podaj rozmiar tablicy (liczba parzysta większa od zera): ");
                if (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0 || rozmiar % 2 != 0)
                {
                    Console.WriteLine("Niepoprawny rozmiar tablicy. Spróbuj ponownie.");
                }
            }

            int[,] tablica = new int[rozmiar, rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < rozmiar; j++)
                    {
                        tablica[i, j] = (i * rozmiar) + j + 1;
                    }
                }
                else
                {
                    for (int j = 0; j < rozmiar; j++)
                    {
                        tablica[i, j] = (i * rozmiar) + rozmiar - j;
                    }
                }
            }

            // Wypisanie tablicy na ekranie
            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
#endif

#if zadanie2
    using System;

    class Program
    {
        static void Main()
        {
            int rozmiar = 0;

            // Pobranie i walidacja rozmiaru tablicy
            while (rozmiar <= 0)
            {
                Console.Write("Podaj rozmiar tablicy (liczba większa od zera): ");
                if (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0)
                {
                    Console.WriteLine("Niepoprawny rozmiar tablicy. Spróbuj ponownie.");
                }
            }

            int[,] tablica = new int[rozmiar, rozmiar];

            int liczba = 1;
            int wiersz = 0;
            int kolumna = 0;
            int kierunek = 1;

            while (liczba <= rozmiar * rozmiar)
            {
                tablica[wiersz, kolumna] = liczba;

                if (kierunek == 1)
                {
                    if (kolumna < rozmiar - 1 && tablica[wiersz, kolumna + 1] == 0)
                        kolumna++;
                    else
                        kierunek = 2;
                }
                else if (kierunek == 2)
                {
                    if (wiersz < rozmiar - 1 && tablica[wiersz + 1, kolumna] == 0)
                        wiersz++;
                    else
                        kierunek = 3;
                }
                else if (kierunek == 3)
                {
                    if (kolumna > 0 && tablica[wiersz, kolumna - 1] == 0)
                        kolumna--;
                    else
                        kierunek = 4;
                }
                else if (kierunek == 4)
                {
                    if (wiersz > 0 && tablica[wiersz - 1, kolumna] == 0)
                        wiersz--;
                    else
                        kierunek = 1;
                }

                liczba++;
            }

            // Wypisanie tablicy na ekranie
            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
#endif