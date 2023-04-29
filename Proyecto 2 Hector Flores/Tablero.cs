using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Hector_Flores
{
    internal class Tablero
    {
       
        public static string[,] tabla = new string[6, 7];
        public static int columna = 0;
        public static int[] numeros = {1,2,3,4,5,6,7};
       



        public static void Creartablero()
        {

            //Crear un nuveo tablero, llenando la matriz de ceros
            for (int f = 0; f < tabla.GetLength(0); f++)
            {
                for (int c = 0; c < tabla.GetLength(1); c++)
                {
                    tabla[f, c] = "[ ]";
                }
            }
        }

    
        public static bool ColumnaLlena(string ficha, string ficha2)
        {
           
                if (tabla[0, columna].Contains(ficha) || tabla[0, columna].Contains(ficha2))
                {
                    // Si encontramos una celda vacía, la columna no está llena
                    return true;
                }
            
            // Si todas las celdas están ocupadas, la columna está llena
            return false;
        }

        public static bool TablaLlena(string ficha, string ficha2)
        {
            for (int i = 0; i < 7; i++)
            {

                if (!tabla[0,i].Contains("o") && !tabla[0, i].Contains("x"))
                {
                    // Si encontramos una celda vacía, la columna no está llena
                    return false;
                    
                }
                
            }
            return true;
            // Si todas las celdas están ocupadas, la columna está llena
            
        }


        public static void colocarcolumna()
        {
           
            switch (columna)
            {
                case 1:
                    columna = 0;
                    break;

                case 2:
                    columna = 1;
                    break;

                case 3:
                    columna = 2;
                    break;

                case 4:
                    columna = 3;
                    break;

                case 5:
                    columna = 4;
                    break;
                case 6:
                    columna = 5;
                    break;
                case 7:
                    columna = 6;
                    break;
            }

        }

        public static void MostrarTablero()
        {
            
            //Mostrar tablero
            for (int f = 0; f < 6; f++)
            {

                for (int c = 0; c < 7; c++)
                {
                    Console.Write(tabla[f, c]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 7; i++)
            {
                Console.Write("(" + numeros[i] +")");
              
            }

            Console.WriteLine();

        }

        public static void ColocarFicha1(Jugadores jugador1, Jugadores jugador2)
        {
            columna = 0;
            bool columnaLlena;
            do
            {
                while (true)
                {
                    Console.WriteLine("Ingrese la columna donde desea colocar la ficha:");
                    try
                    {
                        columna = Convert.ToInt32(Console.ReadLine());

                        if (columna <= 0 || columna > 7)
                        {
                            Console.WriteLine("ERROR, ingrese una columna valida");

                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Es el turno de: " + jugador1.player);
                            Console.WriteLine("Su ficha es: " + jugador1.Ficha);

                            MostrarTablero();
                            continue;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Error, ingrese un numero valido");
                        Console.ReadKey(true);
                        Console.Clear();
                        Console.WriteLine("Es el turno de: " + jugador1.player);
                        Console.WriteLine("Su ficha es: " + jugador1.Ficha);
                        MostrarTablero();
                        continue;
                    }
                    colocarcolumna();
                    break;
                }
                columnaLlena = ColumnaLlena(jugador1.Ficha, jugador2.Ficha);
                if (columnaLlena)
                {
                    Console.WriteLine("La columna seleccionada está llena. Por favor seleccione otra columna.");
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.WriteLine("Es el turno de: " + jugador1.player);
                    Console.WriteLine("Su ficha es: " + jugador1.Ficha);
                    MostrarTablero();
                }
            } while (columnaLlena);

            for (int i = 5; i >= 0; i--)
            {
                if (tabla[i, columna].Contains(jugador1.Ficha) || tabla[i, columna].Contains(jugador2.Ficha))
                {
                    continue;
                }
                else
                {
                    tabla[i, columna] = tabla[i, columna].Replace(" ", jugador1.Ficha);
                    break;
                }
            }
        }

        public static void ColocarFicha2(Jugadores jugador1, Jugadores jugador2)
        {
            bool columnaLlena;
            do
            {
                while (true)
                {
                    Console.WriteLine("Ingrese la columna donde desea colocar la ficha:");
                    try
                    {
                        columna = Convert.ToInt32(Console.ReadLine());

                        if (columna <= 0 || columna > 7)
                        {
                            Console.WriteLine("ERROR, ingrese una columna valida");

                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Es el turno de: " + jugador2.player);
                            Console.WriteLine("Su ficha es: " + jugador2.Ficha);
                            MostrarTablero();
                            continue;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Error, ingrese un numero valido");
                        Console.ReadKey(true);
                        Console.Clear();
                        Console.WriteLine("Es el turno de: " + jugador2.player);
                        Console.WriteLine("Su ficha es: " + jugador2.Ficha);
                        MostrarTablero();
                        continue;
                    }
                    colocarcolumna();
                    break;
                }
                columnaLlena = ColumnaLlena(jugador1.Ficha, jugador2.Ficha);
                if (columnaLlena)
                {
                    Console.WriteLine("La columna seleccionada está llena. Por favor seleccione otra columna.");
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.WriteLine("Es el turno de: " + jugador2.player);
                    Console.WriteLine("Su ficha es: " + jugador2.Ficha);
                    MostrarTablero();
                }
            } while (columnaLlena);

            for (int i = 5; i >= 0; i--)
            {
                if (tabla[i, columna].Contains(jugador1.Ficha) || tabla[i, columna].Contains(jugador2.Ficha))
                {
                    continue;
                }
                else
                {
                    tabla[i, columna] = tabla[i, columna].Replace(" ", jugador2.Ficha);
                    break;
                }
            }
        }


        public static void ColocarFichaCOM(Jugadores jugador1, Jugadores jugador2)
        {  
            columna = 0;
            bool columnaLlena;
            do
            {
                Random rnd = new Random();
                columna = rnd.Next(0, 7);
                colocarcolumna();
                columnaLlena = ColumnaLlena(jugador1.Ficha, jugador2.Ficha);

                
            } while (columnaLlena);

            for (int i = 5; i >= 0; i--)
            {
                if (tabla[i, columna].Contains(jugador1.Ficha) || tabla[i, columna].Contains(jugador2.Ficha))
                {
                    continue;
                }
                else
                {
                    tabla[i, columna] = tabla[i, columna].Replace(" ", jugador2.Ficha);
                    break;
                }
            }
        }





    }
}
