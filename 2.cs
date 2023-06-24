using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];

        int liczba = 1;
        int wiersz = 0;
        int kolumna = 0;
        int kierunek = 1; // Zmienna kierunek - 1: prawo, 2: dół, 3: lewo, 4: góra

        while (liczba <= 100)
        {
            tablica[wiersz, kolumna] = liczba;

            // Sprawdzenie aktualnego kierunku i wykonanie odpowiedniego ruchu
            if (kierunek == 1) // Ruch w prawo
            {
                if (kolumna < 9 && tablica[wiersz, kolumna + 1] == 0)
                    kolumna++; // Przesuń się w prawo, jeśli nie wyjdziesz poza granice tablicy i następne pole jest puste
                else
                    kierunek = 2; // Zmiana kierunku na dół, gdy wyjdziesz poza granice tablicy lub napotkasz już wypełnione pole
            }
            else if (kierunek == 2) // Ruch w dół
            {
                if (wiersz < 9 && tablica[wiersz + 1, kolumna] == 0)
                    wiersz++; // Przesuń się w dół, jeśli nie wyjdziesz poza granice tablicy i następne pole jest puste
                else
                    kierunek = 3; // Zmiana kierunku na lewo, gdy wyjdziesz poza granice tablicy lub napotkasz już wypełnione pole
            }
            else if (kierunek == 3) // Ruch w lewo
            {
                if (kolumna > 0 && tablica[wiersz, kolumna - 1] == 0)
                    kolumna--; // Przesuń się w lewo, jeśli nie wyjdziesz poza granice tablicy i następne pole jest puste
                else
                    kierunek = 4; // Zmiana kierunku na górę, gdy wyjdziesz poza granice tablicy lub napotkasz już wypełnione pole
            }
            else if (kierunek == 4) // Ruch w górę
            {
                if (wiersz > 0 && tablica[wiersz - 1, kolumna] == 0)
                    wiersz--; // Przesuń się w górę, jeśli nie wyjdziesz poza granice tablicy i następne pole jest puste
                else
                    kierunek = 1; // Zmiana kierunku na prawo, gdy wyjdziesz poza granice tablicy lub napotkasz już wypełnione pole
            }

            liczba++;
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
