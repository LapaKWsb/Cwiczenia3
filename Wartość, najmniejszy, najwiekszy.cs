using System;

namespace Zadanie 1, 2
{
    class Program
    {
        static void Main()
        {
            int[] tablica = new int[10];
            Random random = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = random.Next(100);
            }

            Console.WriteLine("Zawartość tablicy od tyłu:");
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }

            int najmniejszy = tablica[0];
            int największy = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] < najmniejszy)
                {
                    najmniejszy = tablica[i];
                }

                if (tablica[i] > największy)
                {
                    największy = tablica[i];
                }
            }

            Console.WriteLine("Najmniejszy element: " + najmniejszy);
            Console.WriteLine("Największy element: " + największy);
        }
    }
}
