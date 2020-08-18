using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
      static Animales gato = new Animales();
        static Animales perro = new Animales();
        static Animales serpiente = new Animales();
        static Animales buho = new Animales();
        static int op = 0;
        static void Main(string[] args)
        { 
          while (op < 5)
          {
            Console.WriteLine("---------------Cinta de Opciones---------------");
            Console.WriteLine("1. Gato");
            Console.WriteLine("2. Perro");
            Console.WriteLine("3. Serpiente");
            Console.WriteLine("4. Búho");
            Console.WriteLine("5. Salir");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" \n");
            Console.WriteLine("Digite el numero de opcion que desea");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine(" \n\n");
            Console.Clear();
                if (op == 1)
                {
                    gato.animal = "Gato";
                    gato.Nopatas = 4;
                    gato.alimento = "Pescado";
                    gato.clasificacion = "Vertebrados";
                    gato.grupo = "Mamiferos";
                    gato.tiporeproduccion = "Viviparos";
                    gato.Descripcion();
                }
                else if (op == 2)
                {
                    perro.animal = "Perro";
                    perro.Nopatas = 4;
                    perro.alimento = "Carne";
                    perro.clasificacion = "Vertebrados";
                    perro.grupo = "Mamiferos";
                    perro.tiporeproduccion = "Viviparos";
                    perro.Descripcion();
                }
                else if (op == 3)
                {
                    serpiente.animal = "Serpiente";
                    serpiente.Nopatas = 0;
                    serpiente.alimento = "Roedores";
                    serpiente.clasificacion = "Vertebrados";
                    serpiente.grupo = "Reptiles";
                    serpiente.tiporeproduccion = "Oviparos";
                    serpiente.Descripcion();
                }
                else if (op == 4)
                {
                    buho.animal = "Búho";
                    buho.Nopatas = 2;
                    buho.alimento = "Reptiles";
                    buho.clasificacion = "Vertebrados";
                    buho.grupo = "Mamiferos";
                    buho.tiporeproduccion = "Viviparos";
                    buho.Descripcion();
                }
          }
            if (op == 5)
            {
                Console.WriteLine("Gracias por usar nuestra aplicación");
            }
            Console.ReadKey();
        }
    }
}
