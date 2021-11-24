using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su nombre");
            Cliente cliente = new Cliente();
            string nombreF;
            nombreF=Console.WriteLine();
            Console.WriteLine("que pelicula desea elejir ver?");
            Console.WriteLine("(1) John Wick 3 (2) Aladdin (3) Avengers (4) Pikachu");
            Pelicula peli = new Pelicula();
            Console.WriteLine("elija entre las siguientes salas disponibles:");
            Sala sala = new Sala();
            Console.WriteLine("elija el numero de asiento que desee");
            Asiento asiento = new Asiento();
            Console.WriteLine("usted a resivido un aperitivo gratuito =):");
            Aperitvo_acc aperitvo_acc = new Aperitvo_acc();
            Console.WriteLine("que comida desea ordenar?");
            Console.WriteLine("Canguil, Hot-dog, CoCaCola");
            Comida comida = new Comida();



            Console.WriteLine(cliente.NombreF(nombref));
            Console.WriteLine(peli,);
            Console.WriteLine(sala);
            Console.WriteLine(asiento);
            Console.WriteLine(aperitvo_acc);
            Console.WriteLine(comida);
        }
    }
}