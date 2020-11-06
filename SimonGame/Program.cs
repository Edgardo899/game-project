using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

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
                    JugarConNumeros();
                    break;
                case 2:
                    JuegaConVocales();
                    break;

                case 3:
                    JugarConEquipos();
                    break;

                case 4:
                    JuegoPaíses();
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
        } //Fin de la función JugarMarcasAutos();

        static void JugarConEquipos()
        {
            Random valores = new Random(); //Para mostrar valores aleatorios.
                                           //Lista de la cual obtendremos los valores aleatorios. 
            string[] ganadores = { "BOCA", "RIVER", "INDEPENDIENTE", "PEÑAROL", "ESTUDIANTES", "GREMIO", "NACIONAL", "OLIMPIA", "SAN PABLO", "SANTOS", "ATLETICO NACIONAL", "CRUZEIRO", "FLAMENGO", "INTERNACIONAL", "ARGENTINOS", "ATLETICO MINEIRO", "COLO COLO", "CORINTHIANS", "ONCE CALDAS", "LIGA DE QUITO", "PALMEIRAS", "RACING", "SAN LORENZO", "VASCO DA GAMA", "VELEZ" };
            ArrayList equipos = new ArrayList(); //Donde vamos a guardar los valores aleatorios obtenidos.
            List<string> jugador = new List<string>(); //Donde vamos a guardar los equipos ingresados por el usuario. 
            string elemento; //El dato que va a ingresar el usuario. 
            int puntos = 0; //Contador de puntos. 
            int i = equipos.Count; //Contador de elementos de una lista
            int x = jugador.Count;
            int opcion;

            Console.WriteLine("El puntaje obtenido es: " + niveles());
            Console.ReadLine();


            int niveles()
            {
                Console.WriteLine("Ingrese el nivel que desea jugar: 1, 2, 3 o 4");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                int puntaje = juego_base(opcion);
                return puntaje;
            }



            int juego_base(int nivel)
            {
                //Dependiendo el parámetro que le pasamos a la función, vamos a jugar con cierta cantidad de equipos.
                //El usuario ingresa el NIVEL que es tomado como parámetro. 
                //Nviel 1- juega con 4 equipos. 
                //Nivel 2 juega con 6 equipos.
                //Nivel 3 juega con 8 equipos.
                //Nivel 4 juega con 10 equipos.
                int a = 0;

                if (nivel == 1)
                {
                    a = a + 4;
                }
                if (nivel == 2)
                {
                    a = a + 6;
                }
                if (nivel == 3)
                {
                    a = a + 8;
                }
                if (nivel == 4)
                {
                    a = a + 10;
                }
                do
                {

                    int aIndex = valores.Next(ganadores.Length);//Guardamos en una variable y obtenemos un valor aleatorio de la lista ganadores
                    Console.WriteLine("Equipo: {0}", ganadores[aIndex]);//Mostramos en pantalla el valor obtenido aleatoriamente.

                    equipos.Add(ganadores[aIndex]);//Agregamos a la lista de los datos que se fueron mostrando en pantalla. 
                    i++;
                    Thread.Sleep(350); //Frenamos la ejecución de la próxima linea. 
                    Console.Clear(); //limpiamos la pantalla para que no se vea el Equipo random.


                    Console.WriteLine("Ingresá: ");//Solicitamos al usuario que ingrese un dato

                    elemento = Convert.ToString(Console.ReadLine());//Casteamos el dato en un String y lo agregamos a la lista de sus datos ingresador por el user.
                    jugador.Add(elemento);

                    if (ganadores[aIndex] == elemento)
                    {
                        puntos = puntos + 10; //Si el dato ingresado por el user es igual al dato arrojado por el programa, se suman 10 puntos. 
                    }

                    Console.Clear();

                } while (i < a);
                //Para mostrar los elementos ingresados
                Console.WriteLine("Los equipos mostrados en pantalla:");
                foreach (string dato in equipos)
                    Console.WriteLine("{0}", dato);
                Console.WriteLine("Los equipos ingresados por el usuario:");
                foreach (string datoUser in jugador)
                    Console.WriteLine("{0}", datoUser);
                Console.ReadLine();
                return puntos;
            }
        }// Fin de la función JugarConEquipos().

        static void JugarConNumeros()
        {
            //Variables para guardar el nivel de dificultad elegido y bool para el do-while de verificación.
            string dificultad = "";
            int opcion = 0;
            bool salida = false;

            //Elegir nivel de dificultad.
            do
            {
                Console.WriteLine("-------------ELIJA EL NIVEL DE DIFICULTAD--------------------");
                Console.WriteLine("");
                Console.WriteLine("1 para jugar con ciclos de 4 números diferentes.");
                Console.WriteLine("2 para jugar con ciclos de 6 números diferentes.");
                Console.WriteLine("3 para jugar con ciclos de 8 números diferentes.");
                Console.WriteLine("4 para jugar con ciclos de 10 números diferentes.");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------");
                Console.Write("Ingresar opción: ");
                dificultad = Console.ReadLine();
                if (dificultad == "1" || dificultad == "2" || dificultad == "3" || dificultad == "4")
                {
                    Console.Clear();
                    salida = true;
                    opcion = Convert.ToInt32(dificultad);
                    //Se modifica la variable "opcion" para utilizarla correctamente en un for posterior.
                    switch (opcion)
                    {
                        case 1:
                            opcion = 4;
                            break;

                        case 2:
                            opcion = 6;
                            break;

                        case 3:
                            opcion = 8;
                            break;

                        case 4:
                            opcion = 10;
                            break;

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("¡Ingresar alguno de los valores indicados SIN ESPACIOS!");
                    Console.WriteLine("");

                }
            } while (salida == false);

            //Creo el Array que tendrá los elementos con los que se jugará.
            int[] elementos_numeros = new int[opcion];

            //Variables para realizar la prueba de comparación.
            int ronda = 0;
            int valor_ingresado = 0;
            bool excepcion_formato = false;
            bool excepcion_rango = false;
            bool salida_juego = false;
            Random elementos = new Random();

            //While del juego. 

            while (salida_juego == false)
            {
                //Se generan los números enteros al azar.
                for (int j = 0; j < opcion; j++)
                {
                    elementos_numeros[j] = elementos.Next(100);
                }

                //Empiezan los bucles de comparación.
                for (int i = 0; i < elementos_numeros.Length; i++)
                {

                    for (int j = 0; j < i + 1; j++)
                    {
                        try
                        {
                            //Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Valor {0} de referencia del ciclo de {1} números :    {2}", i + 1, opcion, elementos_numeros[i]);
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.Write("Ingrese el número {0} de los vistos: ", j + 1);
                            valor_ingresado = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        }

                        catch (IndexOutOfRangeException ex)
                        {
                            excepcion_rango = true;
                        }
                        catch (FormatException ex)
                        {
                            excepcion_formato = true;
                        }
                        //Si ocurre una excepción o los valores de los arrays no coinciden, empezar el fin del juego.
                        if (elementos_numeros[j] != valor_ingresado || excepcion_formato == true || excepcion_rango == true)
                        {
                            j = i;
                            i = elementos_numeros.Length;
                            salida_juego = true;

                        }
                        else
                        {
                            ronda++;
                        }
                    } //Fin del for comparación.
                } //Fin de la burbuja.

                if (salida_juego == false)
                {

                    Console.WriteLine("---------------¡NUEVO CICLO CON OTROS {0} NÚMEROS!------------ ", opcion);
                    Console.WriteLine("");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("--------------------- FIN DEL JUEGO -------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Puntos obtenidos por coincidencias: {0}", (ronda));
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------------");
                }

            } //Fin del juego.

        }// Fin de la función JugarConNumeros.

        //Comienzo de la función JugarPaises();
        static void JuegoPaíses()
        {
            var random = new Random();
            int dificultad;
            List<string> países = new List<string>() { "Argentina", "Brasil", "Uruguay", "Paraguay", "Bolivia", "Peru", "Ecuador", "Colombia",
                                                       "Venezuela", "Panama" };

            Console.WriteLine("Bienvenido!! ");

            Console.WriteLine("Seleccione un nivel de dificultad del 1 al 4 ");
            dificultad = Convert.ToInt32(Console.ReadLine());                   // Ingresamos el nivel de dificultad 
            switch (dificultad)
            {
                case 1:
                    int index = random.Next(países.Count);
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("--- BIENVENIDO INGRESE EL PRIMER PAÍS VISTO: ---");
                    Console.WriteLine("--- LUEGO OPRIMA ENTER HASTA QUE APAREZCA EL SEGUNDO PAÍS: ---");
                    Console.WriteLine("--------------------------------------------------------------------------");

                    Console.WriteLine(países[index]);                  // Nos muestra un país al zar de la lista 
                    string a = Convert.ToString(Console.ReadLine());   // Ingresamos el país visto


                    Console.ReadKey();

                    if (países[index] == a)
                    {
                        List<string> Input_países = new List<string>();
                        Input_países.Add(a);
                        Console.Clear();

                        index = random.Next(países.Count);             // Si se cumple la condición random nos cargara en la variable index un nuevo país al azar
                        Console.WriteLine(países[index]);               // Si se cumple la condición, nos mostrara un nuevo país  
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("INGRESE EL 1.° PAÍS Y EL QUE ESTA VIENDO SIN ESPACIOS ENTRE ELLOS: ");
                        a = Convert.ToString(Console.ReadLine());
                        Console.Clear();

                        if (Input_países[0] + países[index] == a)     // Si el elemento de la lista Input_países que se encuentra en la pocision [0] mas
                        {                                            // el elemento [index] es igual al elemento ingreasado por el usuario  
                            Input_países.Add(a);                    // Se agraga el nuevo elemento ingresado a la lista Input_países   
                            Console.Clear();
                            index = random.Next(países.Count);
                            Console.WriteLine(países[index]);
                            Console.WriteLine("INGRESE EL 1.° , 2.° PAÍS Y EL QUE ESTA VIENDO SIN ESPACIOS ENTRE ELLOS: ");
                            a = Convert.ToString(Console.ReadLine());

                            if (Input_países[1] + países[index] == a)
                            {
                                Input_países.Add(a);
                                Console.Clear();
                                index = random.Next(países.Count);
                                Console.WriteLine(países[index]);
                                Console.WriteLine("INGRESE EL 1.°, 2.° , 3.° PAÍS Y EL QUE ESTA VIENDO SIN ESPACIOS ENTRE ELLOS: ");
                                a = Convert.ToString(Console.ReadLine());

                                if (Input_países[2] + países[index] == a)
                                {
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("******** GANASTE !!!! ********");
                                    Console.WriteLine("------------------------------");
                                    Console.ReadLine();
                                }
                                else
                                    Console.WriteLine("OPCIÓN INCORRECTA!!");
                                Console.ReadLine();
                            }
                            else
                                Console.WriteLine("OPCIÓN INCORRECTA!!");
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("OPCIÓN INCORRECTA!!");
                        Console.ReadLine();
                    }
                    else
                        Console.WriteLine("OPCIÓN INCORRECTA!!");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Nivel 2");
                    index = random.Next(países.Count);
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.WriteLine("--- BIENVENIDO INGRESE EL PRIMER PAÍS VISTO: ---");
                    Console.WriteLine("--- LUEGO OPRIMA ENTER HASTA QUE APAREZCA EL SEGUNDO PAÍS: ---");
                    Console.WriteLine(países[index]);
                    a = Convert.ToString(Console.ReadLine());

                    Console.ReadKey();

                    if (países[index] == a)
                    {
                        List<string> Input_países = new List<string>();
                        Input_países.Add(a);
                        Console.Clear();

                        index = random.Next(países.Count);
                        Console.WriteLine(países[index]);
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("INGRESE EL 1.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                        a = Convert.ToString(Console.ReadLine());

                        if (Input_países[0] + países[index] == a)
                        {
                            Input_países.Add(a);
                            Console.Clear();
                            index = random.Next(países.Count);
                            Console.WriteLine(países[index]);
                            Console.WriteLine("INGRESE EL 1.° , 2.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                            a = Convert.ToString(Console.ReadLine());

                            if (Input_países[1] + países[index] == a)
                            {
                                Input_países.Add(a);
                                Console.Clear();
                                index = random.Next(países.Count);
                                Console.WriteLine(países[index]);
                                Console.WriteLine("INGRESE EL 1.°, 2.° , 3.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                a = Convert.ToString(Console.ReadLine());

                                if (Input_países[2] + países[index] == a)
                                {
                                    Input_países.Add(a);
                                    Console.Clear();
                                    index = random.Next(países.Count);
                                    Console.WriteLine(países[index]);
                                    Console.WriteLine("INGRESE EL 1.°, 2.° , 3.°, 4.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                    a = Convert.ToString(Console.ReadLine());

                                    if (Input_países[3] + países[index] == a)
                                    {
                                        Input_países.Add(a);
                                        Console.Clear();
                                        index = random.Next(países.Count);
                                        Console.WriteLine(países[index]);
                                        Console.WriteLine("INGRESE EL 1.|, 2.° , 3.°, 4.°, 5.° PAÍS Y EL QUE ACABA DE VER: ");
                                        a = Convert.ToString(Console.ReadLine());

                                        if (Input_países[4] + países[index] == a)
                                        {
                                            Console.WriteLine("------------------------------");
                                            Console.WriteLine("********GANASTE !!!! ********");
                                            Console.WriteLine("------------------------------");
                                            Console.ReadLine();
                                        }
                                        else
                                            Console.WriteLine("OPCIÓN INCORRECTA!!");
                                        Console.ReadLine();
                                    }
                                    else
                                        Console.WriteLine("OPCIÓN INCORRECTA!!");
                                    Console.ReadLine();
                                }
                                else
                                    Console.WriteLine("OPCIÓN INCORRECTA!!");
                                Console.ReadLine();
                            }
                            else
                                Console.WriteLine("OPCIÓN INCORRECTA!!");
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("OPCIÓN INCORRECTA!!");
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Nivel 3");
                    index = random.Next(países.Count);
                    Console.WriteLine("--- BIENVENIDO INGRESE EL PRIMER PAÍS VISTO: ---");
                    Console.WriteLine("--- LUEGO OPRIMA ENTER HASTA QUE APAREZCA EL SEGUNDO PAÍS: ---");
                    Console.WriteLine(países[index]);
                    a = Convert.ToString(Console.ReadLine());

                    Console.ReadKey();

                    if (países[index] == a)
                    {
                        List<string> Input_países = new List<string>();
                        Input_países.Add(a);
                        Console.Clear();

                        index = random.Next(países.Count);
                        Console.WriteLine(países[index]);
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("INGRESE EL 1.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                        a = Convert.ToString(Console.ReadLine());

                        if (Input_países[0] + países[index] == a)   // Si el elemento de la lista Input_países que se encuentra en la pocision [0] mas
                        {                                           // el elemento [index] es igual al elemento ingreasado por el usuario
                            Input_países.Add(a);                   // Se agraga el nuevo elemento ingresado a la lista Input_países 
                            Console.Clear();
                            index = random.Next(países.Count);
                            Console.WriteLine(países[index]);
                            Console.WriteLine("INGRESE EL 1.° , 2.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                            a = Convert.ToString(Console.ReadLine());

                            if (Input_países[1] + países[index] == a)
                            {
                                Input_países.Add(a);
                                Console.Clear();
                                index = random.Next(países.Count);
                                Console.WriteLine(países[index]);
                                Console.WriteLine("INGRESE EL 1.°, 2.° , 3.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                a = Convert.ToString(Console.ReadLine());

                                if (Input_países[2] + países[index] == a)
                                {
                                    Input_países.Add(a);
                                    Console.Clear();
                                    index = random.Next(países.Count);
                                    Console.WriteLine(países[index]);
                                    Console.WriteLine("INGRESE EL 1.°, 2.° , 3.°, 4.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                    a = Convert.ToString(Console.ReadLine());

                                    if (Input_países[3] + países[index] == a)
                                    {
                                        Input_países.Add(a);
                                        Console.Clear();
                                        index = random.Next(países.Count);
                                        Console.WriteLine(países[index]);
                                        Console.WriteLine("INGRESE EL 1.°, 2.° , 3.°, 4.°, 5.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                        a = Convert.ToString(Console.ReadLine());

                                        if (Input_países[4] + países[index] == a)
                                        {
                                            Input_países.Add(a);
                                            Console.Clear();
                                            index = random.Next(países.Count);
                                            Console.WriteLine(países[index]);
                                            Console.WriteLine("INGRESE EL 1.°, 2.° , 3.°, 4.°, 5.°, 6.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                            a = Convert.ToString(Console.ReadLine());

                                            if (Input_países[5] + países[index] == a)
                                            {
                                                Input_países.Add(a);
                                                Console.Clear();
                                                index = random.Next(países.Count);
                                                Console.WriteLine(países[index]);
                                                Console.WriteLine("INGRESE EL 1.°, 2.° , 3.°, 4.°, 5.°, 6.°, 7.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                                a = Convert.ToString(Console.ReadLine());

                                                if (Input_países[6] + países[index] == a)
                                                {
                                                    Console.WriteLine("GANASTE !!!!");
                                                    Console.ReadLine();
                                                }
                                                else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                                Console.ReadLine();
                                            }
                                            else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                            Console.ReadLine();
                                        }
                                        else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                        Console.ReadLine();
                                    }
                                    else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                    Console.ReadLine();
                                }
                                else
                                    Console.WriteLine("OPCIÓN INCORRECTA!!");
                                Console.ReadLine();
                            }
                            else
                                Console.WriteLine("OPCIÓN INCORRECTA!!");
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("OPCIÓN INCORRECTA!!");
                        Console.ReadLine();
                    }
                    break;
                case 4:
                    Console.WriteLine("Nivel 4");
                    index = random.Next(países.Count);
                    Console.WriteLine("--- BIENVENIDO INGRESE EL PRIMER PAÍS VISTO: ---");
                    Console.WriteLine("--- LUEGO OPRIMA ENTER HASTA QUE APAREZCA EL SEGUNDO PAÍS: ---");
                    Console.WriteLine(países[index]);
                    a = Convert.ToString(Console.ReadLine());

                    Console.ReadKey();

                    if (países[index] == a)
                    {
                        List<string> Input_países = new List<string>();
                        Input_países.Add(a);
                        Console.Clear();

                        index = random.Next(países.Count);
                        Console.WriteLine(países[index]);
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("INGRESE EL 1.° PAÍS Y EL QUE ACABA DE VER: ");
                        a = Convert.ToString(Console.ReadLine());

                        if (Input_países[0] + países[index] == a)
                        {
                            Input_países.Add(a);
                            Console.Clear();
                            index = random.Next(países.Count);
                            Console.WriteLine(países[index]);
                            Console.WriteLine("INGRESE EL 1.° , 2.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                            a = Convert.ToString(Console.ReadLine());

                            if (Input_países[1] + países[index] == a)
                            {
                                Input_países.Add(a);
                                Console.Clear();
                                index = random.Next(países.Count);
                                Console.WriteLine(países[index]);
                                Console.WriteLine("INGRESE EL 1.°, 2.° , 3.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                a = Convert.ToString(Console.ReadLine());

                                if (Input_países[2] + países[index] == a)
                                {
                                    Input_países.Add(a);
                                    Console.Clear();
                                    index = random.Next(países.Count);
                                    Console.WriteLine(países[index]);
                                    Console.WriteLine("INGRESE EL 1.°, 2.° , 3.°, 4.° PAÍS Y EL QUE ACABA DE VER SIN ESPCAIOS: ");
                                    a = Convert.ToString(Console.ReadLine());

                                    if (Input_países[3] + países[index] == a)
                                    {
                                        Input_países.Add(a);
                                        Console.Clear();
                                        index = random.Next(países.Count);
                                        Console.WriteLine(países[index]);
                                        Console.WriteLine("INGRESE EL 1.°, 2.°, 3.°, 4.°, 5.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                        a = Convert.ToString(Console.ReadLine());

                                        if (Input_países[4] + países[index] == a)
                                        {
                                            Input_países.Add(a);
                                            Console.Clear();
                                            index = random.Next(países.Count);
                                            Console.WriteLine(países[index]);
                                            Console.WriteLine("INGRESE EL 1.°, 2.°, 3.°, 4.°, 5.°, 6.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                            a = Convert.ToString(Console.ReadLine());
                                        }
                                        if (Input_países[5] + países[index] == a)
                                        {
                                            Input_países.Add(a);
                                            Console.Clear();
                                            index = random.Next(países.Count);
                                            Console.WriteLine(países[index]);
                                            Console.WriteLine("INGRESE EL 1.°, 2.°, 3.°, 4.°, 5.°, 6.°, 7.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                            a = Convert.ToString(Console.ReadLine());

                                            if (Input_países[6] + países[index] == a)
                                            {
                                                Input_países.Add(a);
                                                Console.Clear();
                                                index = random.Next(países.Count);
                                                Console.WriteLine(países[index]);
                                                Console.WriteLine("INGRESE EL 1.°, 2.°, 3.°, 4.°, 5.°, 6.°, 7.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                                a = Convert.ToString(Console.ReadLine());

                                                if (Input_países[7] + países[index] == a)
                                                {
                                                    Input_países.Add(a);
                                                    Console.Clear();
                                                    index = random.Next(países.Count);
                                                    Console.WriteLine(países[index]);
                                                    Console.WriteLine("INGRESE EL 1.°, 2.°, 3.°, 4.°, 5.°, 6.°, 7.°, 8.° PAÍS Y EL QUE ACABA DE VER SIN ESPACIOS: ");
                                                    a = Convert.ToString(Console.ReadLine());

                                                    if (Input_países[8] + países[index] == a)
                                                    {
                                                        Console.WriteLine("GANASTE !!!!");
                                                        Console.ReadLine();
                                                    }
                                                    else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                                    Console.ReadLine();
                                                }
                                                else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                                Console.ReadLine();
                                            }
                                            else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                            Console.ReadLine();
                                        }
                                        else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                        Console.ReadLine();
                                    }
                                    else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                    Console.ReadLine();
                                }
                                else Console.WriteLine("OPCIÓN INCORRECTA!!");
                                Console.ReadLine();

                            }
                            else Console.WriteLine("OPCIÓN INCORRECTA!!");
                            Console.ReadLine();
                        }
                        else Console.WriteLine("OPCIÓN INCORRECTA!!");

                        Console.ReadLine();
                    }
                    break;
            }

        }  //Fin de la función JugarPaises();

        //Comienzo de la función JuegaConVocales();
        // -------- Metod Contiene la logica del juego y sus variables.

        static void JuegaConVocales(int dificultad = 0)
        {
            // -----  Aqui estan definidas nuestras listas, enteros, arrays, boleanos y contadores

            List<String> elementos = new List<string>() { "a", "e", "i", "o", "u" }; // Lista de elementos a jugar disponibles
            List<String> palabraMaquina = new List<String>();
            List<String> palabraMaquinaTemporal = new List<String>();
            List<String> palabraUsuario = new List<String>();
            Random aleatory = new Random();
            Boolean acierto = true;
            float score = 0;
            int indice = -1;

            // Iniciamos el juego y damos bienvenida... eli dificult

            Console.WriteLine("Juguemos con Simon");
            Console.WriteLine("Elige la cantidad de vocales con las que quieres jugar");
            Console.Write("0 = Mdo Dios, 1 = Mdo Leyenda, 2 = Mdo Normal, 3 = Mdo Babys ");
            int dificil = int.Parse(Console.ReadLine());
            Console.WriteLine("Recuerda, separa tus vocales con la barra espaciadora");
            Console.WriteLine("Muy bien, Vamos a jugar.");
            while (acierto != false)
            {


                Console.WriteLine("Excelente! ");
                Console.Clear();
                score += 150; // aumento de puntaje por cada acierto, 150 puntos por ronda
                indice += 1;

                int azar = aleatory.Next(dificil, elementos.Count); // Aqui elige la dificultad
                palabraMaquina.Add(elementos[azar]); palabraMaquinaTemporal.Add(elementos[azar]);

                PrintList(palabraMaquinaTemporal);
                Console.Write($"Ahora tus vocales: ");
                palabraMaquinaTemporal.Clear(); palabraUsuario.Clear();

                String entradas = Console.ReadLine();
                String[] entradaToLista = entradas.Split(" ");
                foreach (String entrada in entradaToLista) // agregamos las entradas de usuario como lista
                {
                    palabraUsuario.Add(entrada);
                }


                foreach (String Elemento in palabraMaquina)
                {

                    if (palabraMaquina[indice] == palabraUsuario[indice])
                    {
                        acierto = true; // Si son iguaales los index de cada lista mantiene el While

                    }
                    else
                    {
                        acierto = false; // Sale del While
                        Console.WriteLine($"Perdiste.. tu puntaje final es = {score} puntos");
                        Console.WriteLine("Gracias por jugar. ");
                        break;
                    }
                }

            }

        }



        // ---------------- Esta funcion muestra en pantalla los elementos de la lista. -------
        public static void PrintList(List<string> lista)
        {
            foreach (string element in lista)
                Console.WriteLine("Simon dice : {0}", element);

        }
        //Fin de la función JuegaconVocales();

    } //Fin de la clase Program.
}
