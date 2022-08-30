using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ALGORITMICA_P
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Dulap dulap = CitireDimensiuniDulap();
          
        }


        public static Dulap CitireDimensiuniDulap()
        {
            
            Console.WriteLine("Setati lungimia dulapu-lui !");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Setati latimea dulapu-lui ! ");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Setati inaltimea dulapu-lui ! ");
            int inaltime = int.Parse(Console.ReadLine());
            
            Dulap dulap = new Dulap(lungime, latime, inaltime);
            dulap.GetDulapSuprafataTotala();


            return dulap;
        }

        
    }
}
