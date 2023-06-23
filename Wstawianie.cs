using System;


namespace Zadanie 4
{
    class Program
    {
        static void Main()
        {
            int[] tablica = { 5, 2, 9, 7, 1, 3 };
            SortowaniePrzezWstawianie(tablica);
            WypiszTablice(tablica);
        }

        static void SortowaniePrzezWstawianie(int[] tablica)
        {
            for (int i = 1; i < tablica.Length; i++)
            {
                int klucz = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > klucz)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = klucz;
            }
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
