using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables que guardan la opción elegida por el usuario.
            string ingresar;
            int opcion = 0;
            bool salida = false;

            //Input del usuario.
            do
            {
                Console.WriteLine("¡Opciones de juego!");
                Console.WriteLine("-");
                Console.WriteLine("1 para jugar con números.");
                Console.WriteLine("2 para jugar con colores.");
                Console.WriteLine("-");
                Console.Write("Ingresar opción: ");
                ingresar = Console.ReadLine();
                if (ingresar == "1" || ingresar == "2")
                {
                    Console.Clear();
                    salida = true;
                    opcion = Convert.ToInt32(ingresar);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("¡Ingresar alguno de los valores indicados SIN ESPACIOS!");
                }
            } while (salida == false);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡JUGAR CON NÚMEROS!");
                    break;
                case 2:
                    Console.WriteLine("¡JUGAR CON COLORES!");
                    break;

            } // Fin del switch - case.

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();

        }
    }
}
