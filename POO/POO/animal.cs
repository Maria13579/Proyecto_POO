using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class animal
    {
        public string animal;
        public int Nopatas = 0;
        public string alimento;
        public string clasificacion;
        public string grupo;
        public string tiporeproduccion;

        public void Descripcion()

        {

            Console.WriteLine(animal + "\n" + Nopatas + "\n" + alimento + "\n" + clasificacion + "\n" + grupo + "\n" + tiporeproduccion);

        }
    }
}
