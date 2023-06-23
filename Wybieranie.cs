using System;

namespace Zadanie 5
{
    class Program
    {
        static void Main()
        {
            int[] tablica = { 3, 8, 9, 6, 2, 7 };
            SortWybieranie(tablica);
            WypiszTablice(tablica);
        }

        static void SortWybieranie(int[] tablica)
        {
            int n = tablica.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int indeksMin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[indeksMin])
                        indeksMin = j;
                }

                if (indeksMin != i)
                    (tablica[i], tablica[indeksMin]) = (tablica[indeksMin], tablica[i]);
            }
        }

        static void WypiszTablice(int[] tablica)
        {
            Console.WriteLine(string.Join(" ", tablica));
        }
    }
}
