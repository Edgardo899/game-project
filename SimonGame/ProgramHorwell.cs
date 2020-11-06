using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace simonGame
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> elementos = new List<string>() { "a", "e", "i", "o", "u" };
            List<String> palabraMaquina = new List<String>();
            List<String> palabraMaquinaTemporal = new List<String>();
            Random aleatory = new Random();
            int azar = aleatory.Next(0, elementos.Count); // El cero toma el minimo de elementos, usarlos para dificultad 
            palabraMaquina.Add(elementos[azar]);
            PrintList(palabraMaquina);

            List<String> palabraUsuario = new List<String>();

            //String entradas = Console.ReadLine();
            //String[] entradaToLista = entradas.Split(" ");
            //foreach (String entrada in entradaToLista)
            //    palabraUsuario.Add(entrada);

            //List<String> listaFinal = new List<string>();          
            //String frases = Console.ReadLine();
            //String [] fraseSeparada = frases.Split(" ");
            //foreach ( String cosa in fraseSeparada)
            //    listaFinal.Add(cosa);
            //PrintList(listaFinal);

            Console.Write("Tu turno: ");
            String Usuario = Console.ReadLine();
            palabraUsuario.Add(Usuario);

            //------------------------------

            Boolean acierto = true;
            int score = 0;
            int indice = 0;

            while (acierto != false)
            {

                foreach (String Elemento in palabraMaquina)
                {
                    if (palabraMaquina[indice] == palabraUsuario[indice])
                    {
                        acierto = true;
                        Console.WriteLine(acierto);

                    }
                    else
                    {
                        acierto = false;
                        Console.WriteLine(acierto);
                        Console.WriteLine(indice);
                        indice += 1;
                        Console.WriteLine($"Veamos.. tu puntaje final = {score}");
                        Console.WriteLine("Gracias por jugar. ");
                        Console.ReadKey();
                        break;
                    }
                }



                Console.WriteLine("Excelente, vamos una mas! ");
                Console.WriteLine(indice);
                indice += 1;
                score += 150;
                int azar2 = aleatory.Next(0, elementos.Count);
                palabraMaquina.Add(elementos[azar2]); palabraMaquinaTemporal.Add(elementos[azar2]);

                PrintList(palabraMaquinaTemporal);
                Console.Write("Ahora tu secuencia:  ");
                palabraMaquinaTemporal.Clear(); palabraUsuario.Clear();

                String entradas = Console.ReadLine();
                String[] entradaToLista = entradas.Split(" ");
                foreach (String entrada in entradaToLista)
                    palabraUsuario.Add(entrada);


            }









        }
        // ---------------- Esta funcion muestra en pantalla los elementos de la lista. -------
        public static void PrintList(List<string> lista)
        {
            foreach (string element in lista)
                Console.WriteLine("-Elemento Random: {0}", element);

        }

        //////--------- Crear la lista random---
        //static string[] ElementoRandom(int complejidad = 0)
        //{
        //    Random aleatory = new Random();
        //    String[] listElements = "a e i o u "; // Lista Maquina
        //    int index = aleatory.Next(complejidad, listElements.Length); // El cero toma el minimo de elementos, usarlos para dificultad 
        //    String nuevo =
        //}

        //// ---------------- Esta funcion muestra en pantalla los elementos de la lista. -------
        //public static void PrintList(List<string> lista)
        //{
        //    foreach (string element in lista)
        //        Console.WriteLine(" memoriza: {0}", element);

        //}

        //// ---------------- Esta funcion muestra en pantalla los elementos de la cola. -------
        //public static void PrintCola(Queue cola)
        //{
        //    foreach (string number in cola)
        //    {
        //        Console.Write("- {0}", number);
        //    }

        //}



        //// --------- Comparar --------------
        //public static Boolean Comprobar(Object cola1, Object cola2)
        //{
        //    if (cola1.Equals(cola2))
        //        return true;
        //    else return false;
        //}




        ////--------- Crear la lista random---
        //static string ElementoRandom(int complejidad = 0)
        //{
        //    Random aleatory = new Random();
        //    List<string> listElements = new List<string>() { "a ", "e ", "i ", "o ", "u " }; // Lista Maquina
        //    int index = aleatory.Next(complejidad, listElements.Count); // El cero toma el minimo de elementos, usarlos para dificultad 
        //    return listElements[index];
        //}





    }

}

