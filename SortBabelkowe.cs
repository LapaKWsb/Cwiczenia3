// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie 3
{
    class Program
    {
        static void Main()
        {
            int[] tablica = { 5, 2, 9, 7, 1, 3 };

            Console.WriteLine("Przed sortowaniem:");
            WypiszTablice(tablica);

            SortowanieBabelkowe(tablica);

            Console.WriteLine("Po sortowaniu:");
            WypiszTablice(tablica);
        }

        static void SortowanieBabelkowe(int[] tablica)
        {
            int n = tablica.Length;

            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        Zamien(tablica, i, i + 1);
                    }
                }

                n--;
            }
            while (n > 1);
        }

        static void Zamien(int[] tablica, int indeks1, int indeks2)
        {
            int temp = tablica[indeks1];
            tablica[indeks1] = tablica[indeks2];
            tablica[indeks2] = temp;
        }

        static void WypiszTablice(int[] tablica)
        {
            foreach (int element in tablica)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
