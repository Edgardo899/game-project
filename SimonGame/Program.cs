using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
                Console.WriteLine("¡Bienvenido a SimonGame!");
                Console.WriteLine("-");
                Console.WriteLine("¡Opciones de juego!");
                Console.WriteLine("-");
                Console.WriteLine("1 para jugar con números.");
                Console.WriteLine("2 para jugar con letras.");
                Console.WriteLine("3 para jugar con equipos de fútbol.");
                Console.WriteLine("4 para jugar con países.");
                Console.WriteLine("5 para jugar con marcas de autos.");
                Console.WriteLine("-");
                Console.Write("Ingresar opción: ");
                ingresar = Console.ReadLine();
                if (ingresar == "1" || ingresar == "2" || ingresar == "3" || ingresar == "4" || ingresar == "5")
                {
                    Console.Clear();
                    salida = true;
                    opcion = Convert.ToInt32(ingresar);
                }
                else
                {
                    Console.WriteLine("¡Ingresar alguno de los valores indicados SIN ESPACIOS!");
                    Console.Clear();
                }
            } while (salida == false);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡JUGAR CON NÚMEROS!");
                    break;
                case 2:
                    Console.WriteLine("¡JUGAR CON LETRAS!");
                    break;

                case 3:
                    Console.WriteLine("¡JUGAR CON EQUIPOS DE FÚTBOL!");
                    break;

                case 4:
                    Console.WriteLine("¡JUGAR CON PAÍSES!");
                    break;

                case 5:
                    JugarMarcasAutos();
                    break;

            } // Fin del switch - case.


            Console.ReadKey();

        }

        static void JugarMarcasAutos()
        {
            var random = new Random();
            int dificultad, continuar, puntos = 0;
            string ingresar;
            List<string> Dfacil = new List<string>() { "BMW", "AUDI", "JEEP", "KIA", "FORD", "FIAT", "PEUGOT", "FERRARI", "ALFA ROMEO", "MERCEDES BENZ" };

            Console.WriteLine("Elija la dificultad");
            Console.WriteLine("-");
            Console.WriteLine("1 para Facil, 1 - 4 Marcas.");
            Console.WriteLine("2 para Normal, 1 - 6 Marcas.");
            Console.WriteLine("3 para Dificil, 1 - 8 Marcas.");
            Console.WriteLine("4 para Muy Dificil, 1 - 10 Marcas");
            Console.WriteLine("-");
            Console.WriteLine("Ingresar valor");
            ingresar = Console.ReadLine();
            dificultad = Convert.ToInt32(ingresar);
            Console.Clear();

            switch (dificultad)
            {
                case 1:
                    do
                    {
                        int r1 = random.Next(Dfacil.Count);
                        Console.WriteLine(Dfacil[r1]);
                        List<string> MarcaAutos = new List<string>();
                        Console.WriteLine("Ingrese la marca de auto vista: ");
                        string ingreso1 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        MarcaAutos.Add(ingreso1);
                        if (MarcaAutos[0] == Dfacil[r1])
                        {
                            int r2 = random.Next(Dfacil.Count);
                            Console.WriteLine(Dfacil[r2]);
                            Console.WriteLine("Ingrese la marca de auto vista: ");
                            string ingreso2 = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            MarcaAutos.Add(ingreso2);

                            if (MarcaAutos[1] == Dfacil[r2])
                            {
                                int r3 = random.Next(Dfacil.Count);
                                Console.WriteLine(Dfacil[r3]);
                                Console.WriteLine("Ingrese la marca de auto vista: ");
                                string ingreso3 = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                MarcaAutos.Add(ingreso3);

                                if (MarcaAutos[2] == Dfacil[r3])
                                {
                                    int r4 = random.Next(Dfacil.Count);
                                    Console.WriteLine(Dfacil[r4]);
                                    Console.WriteLine("Ingrese la marca de auto vista: ");
                                    string ingreso4 = Convert.ToString(Console.ReadLine());
                                    Console.Clear();
                                    MarcaAutos.Add(ingreso4);

                                    if (MarcaAutos[3] == Dfacil[r4])
                                    {
                                        Console.WriteLine("Ha acertado el ornden de las marcas.");
                                        Console.WriteLine("-");
                                        puntos += 10;
                                        Console.WriteLine("Consigue {0} puntos en esta ronda.", puntos);
                                        Console.WriteLine("-");
                                        Console.WriteLine("Para pasar a la siguiente ronda presione 1.");
                                        continuar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();


                                    }
                                    else
                                    {
                                        Console.WriteLine("Perdiste tu puntución en esta partida fue de {0}.", puntos);
                                        Console.WriteLine("Para salir presione 2.");
                                        continuar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                    }




                                }
                                else
                                {
                                    Console.WriteLine("Perdiste tu puntución en esta partida fue de {0}.", puntos);
                                    Console.WriteLine("Para salir presione 2.");
                                    continuar = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0}.", puntos);
                                Console.WriteLine("Para salir presione 2.");
                                continuar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0}.", puntos);
                            Console.WriteLine("Para salir presione 2.");
                            continuar = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        }
                    } while (continuar == 1);

                    break;

                case 2:
                    do
                    {
                        int r1 = random.Next(Dfacil.Count);
                        Console.WriteLine(Dfacil[r1]);
                        List<string> MarcaAutos = new List<string>();
                        Console.WriteLine("Ingrese la marca de auto vista: ");
                        string ingreso1 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        MarcaAutos.Add(ingreso1);
                        if (MarcaAutos[0] == Dfacil[r1])
                        {
                            int r2 = random.Next(Dfacil.Count);
                            Console.WriteLine(Dfacil[r2]);
                            Console.WriteLine("Ingrese la marca de auto vista: ");
                            string ingreso2 = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            MarcaAutos.Add(ingreso2);

                            if (MarcaAutos[1] == Dfacil[r2])
                            {
                                int r3 = random.Next(Dfacil.Count);
                                Console.WriteLine(Dfacil[r3]);
                                Console.WriteLine("Ingrese la marca de auto vista: ");
                                string ingreso3 = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                MarcaAutos.Add(ingreso3);

                                if (MarcaAutos[2] == Dfacil[r3])
                                {
                                    int r4 = random.Next(Dfacil.Count);
                                    Console.WriteLine(Dfacil[r4]);
                                    Console.WriteLine("Ingrese la marca de auto vista: ");
                                    string ingreso4 = Convert.ToString(Console.ReadLine());
                                    Console.Clear();
                                    MarcaAutos.Add(ingreso4);

                                    if (MarcaAutos[3] == Dfacil[r4])
                                    {
                                        int r5 = random.Next(Dfacil.Count);
                                        Console.WriteLine(Dfacil[r5]);
                                        Console.WriteLine("Ingrese la marca de auto vista: ");
                                        string ingreso5 = Convert.ToString(Console.ReadLine());
                                        Console.Clear();
                                        MarcaAutos.Add(ingreso5);

                                        if (MarcaAutos[4] == Dfacil[r5])
                                        {

                                            int r6 = random.Next(Dfacil.Count);
                                            Console.WriteLine(Dfacil[r6]);
                                            Console.WriteLine("Ingrese la marca de auto vista: ");
                                            string ingreso6 = Convert.ToString(Console.ReadLine());
                                            Console.Clear();
                                            MarcaAutos.Add(ingreso6);

                                            if (MarcaAutos[5] == Dfacil[r6])
                                            {
                                                Console.WriteLine("Ha acertado el ornden de las marcas.");
                                                Console.WriteLine("-");
                                                puntos += 10;
                                                Console.WriteLine("Consigue {0} puntos en esta ronda.", puntos);
                                                Console.WriteLine("-");
                                                Console.WriteLine("Para pasar a la siguiente ronda presione 1.");
                                                Console.Clear();
                                                continuar = Convert.ToInt32(Console.ReadLine());
                                            }
                                            else
                                            {
                                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                Console.WriteLine("Para salir presione 2.");
                                                continuar = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                            Console.WriteLine("Para salir presione 2.");
                                            continuar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                        Console.WriteLine("Para salir presione 2.");
                                        continuar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                    Console.WriteLine("Para salir presione 2.");
                                    continuar = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                Console.WriteLine("Para salir presione 2.");
                                continuar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }



                        }
                        else
                        {
                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                            Console.WriteLine("Para salir presione 2.");
                            continuar = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        }


                    } while (continuar == 1);
                    break;

                case 3:
                    do
                    {
                        int r1 = random.Next(Dfacil.Count);
                        Console.WriteLine(Dfacil[r1]);
                        List<string> MarcaAutos = new List<string>();
                        Console.WriteLine("Ingrese la marca de auto vista: ");
                        string ingreso1 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        MarcaAutos.Add(ingreso1);
                        if (MarcaAutos[0] == Dfacil[r1])
                        {
                            int r2 = random.Next(Dfacil.Count);
                            Console.WriteLine(Dfacil[r2]);
                            Console.WriteLine("Ingrese la marca de auto vista: ");
                            string ingreso2 = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            MarcaAutos.Add(ingreso2);

                            if (MarcaAutos[1] == Dfacil[r2])
                            {
                                int r3 = random.Next(Dfacil.Count);
                                Console.WriteLine(Dfacil[r3]);
                                Console.WriteLine("Ingrese la marca de auto vista: ");
                                string ingreso3 = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                MarcaAutos.Add(ingreso3);

                                if (MarcaAutos[2] == Dfacil[r3])
                                {
                                    int r4 = random.Next(Dfacil.Count);
                                    Console.WriteLine(Dfacil[r4]);
                                    Console.WriteLine("Ingrese la marca de auto vista: ");
                                    string ingreso4 = Convert.ToString(Console.ReadLine());
                                    Console.Clear();
                                    MarcaAutos.Add(ingreso4);

                                    if (MarcaAutos[3] == Dfacil[r4])
                                    {
                                        int r5 = random.Next(Dfacil.Count);
                                        Console.WriteLine(Dfacil[r5]);
                                        Console.WriteLine("Ingrese la marca de auto vista: ");
                                        string ingreso5 = Convert.ToString(Console.ReadLine());
                                        Console.Clear();
                                        MarcaAutos.Add(ingreso5);

                                        if (MarcaAutos[4] == Dfacil[r5])
                                        {

                                            int r6 = random.Next(Dfacil.Count);
                                            Console.WriteLine(Dfacil[r6]);
                                            Console.WriteLine("Ingrese la marca de auto vista: ");
                                            string ingreso6 = Convert.ToString(Console.ReadLine());
                                            Console.Clear();
                                            MarcaAutos.Add(ingreso6);

                                            if (MarcaAutos[5] == Dfacil[r6])
                                            {
                                                int r7 = random.Next(Dfacil.Count);
                                                Console.WriteLine(Dfacil[r7]);
                                                Console.WriteLine("Ingrese la marca de auto vista: ");
                                                string ingreso7 = Convert.ToString(Console.ReadLine());
                                                Console.Clear();
                                                MarcaAutos.Add(ingreso7);

                                                if (MarcaAutos[6] == Dfacil[r7])
                                                {
                                                    int r8 = random.Next(Dfacil.Count);
                                                    Console.WriteLine(Dfacil[r7]);
                                                    Console.WriteLine("Ingrese la marca de auto vista: ");
                                                    string ingreso8 = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    MarcaAutos.Add(ingreso8);

                                                    if (MarcaAutos[7] == Dfacil[r8])
                                                    {
                                                        Console.WriteLine("Ha acertado el ornden de las marcas.");
                                                        Console.WriteLine("-");
                                                        puntos += 10;
                                                        Console.WriteLine("Consigue {0} puntos en esta ronda.", puntos);
                                                        Console.WriteLine("-");
                                                        Console.WriteLine("Para pasar a la siguiente ronda presione 1.");
                                                        Console.Clear();
                                                        continuar = Convert.ToInt32(Console.ReadLine());


                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                        Console.WriteLine("Para salir presione 2.");
                                                        continuar = Convert.ToInt32(Console.ReadLine());
                                                        Console.Clear();
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                    Console.WriteLine("Para salir presione 2.");
                                                    continuar = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                Console.WriteLine("Para salir presione 2.");
                                                continuar = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                            Console.WriteLine("Para salir presione 2.");
                                            continuar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                        Console.WriteLine("Para salir presione 2.");
                                        continuar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                    Console.WriteLine("Para salir presione 2.");
                                    continuar = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }



                            }
                            else
                            {
                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                Console.WriteLine("Para salir presione 2.");
                                continuar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }



                        }
                        else
                        {
                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                            Console.WriteLine("Para salir presione 2.");
                            continuar = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        }


                    } while (continuar == 1);
                    break;

                case 4:
                    do
                    {
                        int r1 = random.Next(Dfacil.Count);
                        Console.WriteLine(Dfacil[r1]);
                        List<string> MarcaAutos = new List<string>();
                        Console.WriteLine("Ingrese la marca de auto vista: ");
                        string ingreso1 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        MarcaAutos.Add(ingreso1);
                        if (MarcaAutos[0] == Dfacil[r1])
                        {
                            int r2 = random.Next(Dfacil.Count);
                            Console.WriteLine(Dfacil[r2]);
                            Console.WriteLine("Ingrese la marca de auto vista: ");
                            string ingreso2 = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            MarcaAutos.Add(ingreso2);

                            if (MarcaAutos[1] == Dfacil[r2])
                            {
                                int r3 = random.Next(Dfacil.Count);
                                Console.WriteLine(Dfacil[r3]);
                                Console.WriteLine("Ingrese la marca de auto vista: ");
                                string ingreso3 = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                MarcaAutos.Add(ingreso3);

                                if (MarcaAutos[2] == Dfacil[r3])
                                {
                                    int r4 = random.Next(Dfacil.Count);
                                    Console.WriteLine(Dfacil[r4]);
                                    Console.WriteLine("Ingrese la marca de auto vista: ");
                                    string ingreso4 = Convert.ToString(Console.ReadLine());
                                    Console.Clear();
                                    MarcaAutos.Add(ingreso4);

                                    if (MarcaAutos[3] == Dfacil[r4])
                                    {
                                        int r5 = random.Next(Dfacil.Count);
                                        Console.WriteLine(Dfacil[r5]);
                                        Console.WriteLine("Ingrese la marca de auto vista: ");
                                        string ingreso5 = Convert.ToString(Console.ReadLine());
                                        Console.Clear();
                                        MarcaAutos.Add(ingreso5);

                                        if (MarcaAutos[4] == Dfacil[r5])
                                        {

                                            int r6 = random.Next(Dfacil.Count);
                                            Console.WriteLine(Dfacil[r6]);
                                            Console.WriteLine("Ingrese la marca de auto vista: ");
                                            string ingreso6 = Convert.ToString(Console.ReadLine());
                                            Console.Clear();
                                            MarcaAutos.Add(ingreso6);

                                            if (MarcaAutos[5] == Dfacil[r6])
                                            {
                                                int r7 = random.Next(Dfacil.Count);
                                                Console.WriteLine(Dfacil[r7]);
                                                Console.WriteLine("Ingrese la marca de auto vista: ");
                                                string ingreso7 = Convert.ToString(Console.ReadLine());
                                                Console.Clear();
                                                MarcaAutos.Add(ingreso7);

                                                if (MarcaAutos[6] == Dfacil[r7])
                                                {
                                                    int r8 = random.Next(Dfacil.Count);
                                                    Console.WriteLine(Dfacil[r7]);
                                                    Console.WriteLine("Ingrese la marca de auto vista: ");
                                                    string ingreso8 = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    MarcaAutos.Add(ingreso8);

                                                    if (MarcaAutos[7] == Dfacil[r8])
                                                    {
                                                        int r9 = random.Next(Dfacil.Count);
                                                        Console.WriteLine(Dfacil[r9]);
                                                        Console.WriteLine("Ingrese la marca de auto vista: ");
                                                        string ingreso9 = Convert.ToString(Console.ReadLine());
                                                        Console.Clear();
                                                        MarcaAutos.Add(ingreso9);

                                                        if (MarcaAutos[8] == Dfacil[r9])
                                                        {
                                                            int r10 = random.Next(Dfacil.Count);
                                                            Console.WriteLine(Dfacil[r10]);
                                                            Console.WriteLine("Ingrese la marca de auto vista: ");
                                                            string ingreso10 = Convert.ToString(Console.ReadLine());
                                                            Console.Clear();
                                                            MarcaAutos.Add(ingreso10);

                                                            if (MarcaAutos[9] == Dfacil[r10])
                                                            {
                                                                Console.WriteLine("Ha acertado el ornden de las marcas.");
                                                                Console.WriteLine("-");
                                                                puntos += 10;
                                                                Console.WriteLine("Consigue {0} puntos en esta ronda.", puntos);
                                                                Console.WriteLine("-");
                                                                Console.WriteLine("Para pasar a la siguiente ronda presione 1.");
                                                                Console.Clear();
                                                                continuar = Convert.ToInt32(Console.ReadLine());


                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                                Console.WriteLine("Para salir presione 2.");
                                                                continuar = Convert.ToInt32(Console.ReadLine());
                                                                Console.Clear();
                                                            }

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                            Console.WriteLine("Para salir presione 2.");
                                                            continuar = Convert.ToInt32(Console.ReadLine());
                                                            Console.Clear();
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                        Console.WriteLine("Para salir presione 2.");
                                                        continuar = Convert.ToInt32(Console.ReadLine());
                                                        Console.Clear();
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                    Console.WriteLine("Para salir presione 2.");
                                                    continuar = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                                Console.WriteLine("Para salir presione 2.");
                                                continuar = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                            Console.WriteLine("Para salir presione 2.");
                                            continuar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                        Console.WriteLine("Para salir presione 2.");
                                        continuar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                    Console.WriteLine("Para salir presione 2.");
                                    continuar = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }


                            }
                            else
                            {
                                Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                                Console.WriteLine("Para salir presione 2.");
                                continuar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }




                        }
                        else
                        {
                            Console.WriteLine("Perdiste tu puntución en esta partida fue de {0} puntos.", puntos);
                            Console.WriteLine("Para salir presione 2.");
                            continuar = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        }


                    } while (continuar == 1);
                    break;








            }






        }


    }
}
