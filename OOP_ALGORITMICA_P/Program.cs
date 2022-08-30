using System;

namespace OOP_ALGORITMICA_P_Dulap
{
    public class Program
    {
        static void Main()
        {

            Dulap dulap = CreazaDulap();
            Console.WriteLine($"Volumul dulapului este {dulap.volum}");
        }


        private static Dulap CreazaDulap()
        {
            Console.WriteLine("Introduce-ti dimensiunile unui dulap !");

            Console.WriteLine("Setati lungimia dulapu-lui !");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Setati latimea dulapu-lui !");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Setati inaltimea dulapu-lui !");
            int inaltime = int.Parse(Console.ReadLine());

            return new Dulap(lungime, latime, inaltime);
        }
    }
}