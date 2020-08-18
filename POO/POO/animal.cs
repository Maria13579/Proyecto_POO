using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class animal
    {
        public string animals;
        public int Nopatas = 0;
        public string alimento;
        public string clasificación;
        public string grupo;
        public string tiporeproduccion;

        public void Dezplasamiento(int NoMov)
        {
            Console.WriteLine(NoMov);
        }
        public void Comer(string Comida)
        {
            Console.WriteLine("Come:" + Comida);
        }
    }
}
