using System;


namespace OOP_ALGORITMICA_P_Dulap
{
    public class Dulap
    {
        private readonly int lungime;
        private readonly int latime;
        private readonly int inaltime;
        public readonly int volum; // volumul poate fi citit de oriunde fiinda e calculat deja 

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
            this.volum = lungime * latime * inaltime; // volumul e creat automat in constructor
        }
    }
}