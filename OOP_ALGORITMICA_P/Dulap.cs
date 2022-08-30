using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ALGORITMICA_P
{
    public class Dulap
    {
        private readonly int lungime;
        private readonly int latime;
        private readonly int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public void Tipareste()
        {
            string tiparesteText = "Introduce-ti dimensiunile unui dulap !";
            Console.WriteLine(tiparesteText);
        }

        public void GetDulapSuprafataTotala()
        {
            int  volum = 0;
            volum += volum * lungime * latime * inaltime;
        }
    }
}
