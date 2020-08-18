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
        static animal gato = new animal();
        static animal perro = new animal();
        static animal serpiete = new animal();
        static animal buho = new animal();
        static int op = 0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------------Cinta de Opciones---------------");
            Console.WriteLine("1. Gato");
            Console.WriteLine("2. Perro");
            Console.WriteLine("3. Serpiente");
            Console.WriteLine("4. Búho");
            Console.WriteLine("5. Salir");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("/n");
            Console.WriteLine("Digite el numero de opcion que desea")
            op=int.Parse(Console.ReadLine());
            while(op<5 && op>0)
            {

             if(op==1)
             {
              gato.animals="Gato";
              gato.NoPatas = 4;
              gato.alimento ="Pescado";
              gato.clasificacion = "Vertebrados";
              gato.grupo = "Mamiferos";
              gato.tiporeproduccion = "Viviparos";
             }
             else if(op == 2)
             {
              perro.animals="Perro";
              perro.NoPatas=4;
              perro.alimento = "Carne";
              perro.clasificacion = "Vertebrados";
              perro.grupo = "Mamiferos";
              perro.tiporeproduccion = "Viviparos";
             }
             else if (op == 3)
             {
              serpiente.animals="Serpiente";
              serpiente.NoPatas=0;
              serpiente.alimento = "Roedores";
              serpiente.clasificacion = "Vertebrados";
              serpiente.grupo = "Reptiles";
              serpiente.tiporeproduccion = "Oviparos";
             }
             else if (op==4)
             {
              buho.animals="Búho";
              buho.NoPatas=2;
              buho.alimento = "Reptiles";
              buho.clasificacion = "Vertebrados";
              buho.grupo = "Mamiferos";
              buho.tiporeproduccion = "Viviparos";
             }
            }
            if(op==5)
            {
                Console.WriteLine("Gracias por usar nuestra aplicación");
            }
        }
    }
}
