using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Proyecto_2_Hector_Flores
{
    internal class Ganador
    {
        private Jugadores jugador1;
        private Jugadores jugador2;

        private Jugadores? winner;
        public static string tie;

        
        public static string Fichaganador = "0";

        public Ganador(Jugadores jugador1, Jugadores jugador2)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.winner = null;
        }

        public Jugadores GetJugador1()
        {
            return jugador1;
        }

        public Jugadores GetJugador2()
        {
            return jugador2;
        }

       

        public Jugadores Reinciar()
        {

            if(winner != null)
            {
                winner = null;
                
            }

            return winner;

        }

        public Jugadores JugadorGanador(Jugadores jugador1, Jugadores jugador2)
        {
            bool conecta4 = true;

            // Validación del ganador de forma horizontal
            for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
            {
                for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
                {
                    conecta4 = true;
                    
                    try
                    {

                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f, c + i].Contains(jugador1.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }
                        }

                        if (conecta4)
                        {
                            winner = jugador1;

                            for (int i = 0; i < 4; i++)
                            {


                                

                            }

                            break;
                        }

                        conecta4 = true;

                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f, c + i].Contains(jugador2.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }
                        }
                        if (conecta4)
                        {

                            winner = jugador2;

                            for (int i = 0; i < 4; i++)
                            {
                              

                            }

                            break;

                        }
                    }
                    catch
                    {
                        break;
                    }

                }

            }
            // Validación del ganador en forma vertical
            for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
            {
                for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
                {
                    conecta4 = true;
                    try
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f + i, c].Contains(jugador1.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }


                        }

                        if (conecta4)
                        {
                            winner = jugador1;

                            break;
                        }

                        conecta4 = true;

                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f + i, c].Contains(jugador2.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }

                        }

                        if (conecta4)
                        {
                            winner = jugador2;

                            break;
                        }

                    }
                    catch
                    {
                        break;
                    }
                }
            }

            //Validacion de forma diagonal de derecha a izquierda
            for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
            {
                for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
                {
                    conecta4 = true;

                    try
                    {


                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f + i, c + i].Contains(jugador1.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }
                        }

                        if (conecta4)
                        {
                            winner = jugador1;
                            break;
                        }

                        conecta4 = true;

                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f + i, c + i].Contains(jugador2.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }
                        }

                        if (conecta4)
                        {
                            winner = jugador2;
                            break;
                        }

                    }
                    catch
                    {
                        break;
                    }
                }
            }

            //Validacion de forma diagonal de izquierda a derecha 

            for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
            {
                for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
                {
                    conecta4 = true;
                    try
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f + i, c - i].Contains(jugador1.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }
                        }

                        if (conecta4)
                        {
                            winner = jugador1;
                            break;
                        }

                        conecta4 = true;

                        for (int i = 0; i < 4; i++)
                        {
                            if (!Tablero.tabla[f + i, c - i].Contains(jugador2.Ficha))
                            {
                                conecta4 = false;
                                break;
                            }
                        }

                        if (conecta4)
                        {
                            winner = jugador2;
                            break;
                        }

                    }
                    catch
                    {
                        break;
                    }
                }
            }

            return winner;
        }


        public static void CambiarFicha(string Ficha)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
            { 
            
                  for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
                  {
                    try
                    {


                        if (Tablero.tabla[f, c].Contains(Ficha) && Tablero.tabla[f + 1, c].Contains(Ficha) && Tablero.tabla[f + 2, c].Contains(Ficha) && Tablero.tabla[f + 3, c].Contains(Ficha))
                        {
                            for (int j = 0; j < 4; j++)
                            {

                                Tablero.tabla[f, c] = Tablero.tabla[f, c].Replace(Ficha, "■");
                                f++;

                            }

                        }
                    }
                    catch
                    {
                        break;
                    }
                  }
 
            
            }

            for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
            {

                for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
                {
                    try
                    {


                        if (Tablero.tabla[f, c].Contains(Ficha) && Tablero.tabla[f, c + 1].Contains(Ficha) && Tablero.tabla[f, c + 2].Contains(Ficha) && Tablero.tabla[f, c + 3].Contains(Ficha))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Tablero.tabla[f, c] = Tablero.tabla[f, c].Replace(Ficha, "■");
                                c++;

                            }

                        }
                    }
                    catch
                    {
                        break;
                    }
                }


            }

            for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
            {

                for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
                {
                    try
                    {


                        if (Tablero.tabla[f, c].Contains(Ficha) && Tablero.tabla[f + 1, c + 1].Contains(Ficha) && Tablero.tabla[f + 2, c + 2].Contains(Ficha) && Tablero.tabla[f + 3, c + 3].Contains(Ficha))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Tablero.tabla[f, c] = Tablero.tabla[f, c].Replace(Ficha, "■");
                                c++;
                                f++;

                            }

                        }
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            for (int f = 0; f < Tablero.tabla.GetLength(0); f++)
            {

                for (int c = 0; c < Tablero.tabla.GetLength(1); c++)
                {
                    try
                    {


                        if (Tablero.tabla[f, c].Contains(Ficha) && Tablero.tabla[f + 1, c - 1].Contains(Ficha) && Tablero.tabla[f + 2, c - 2].Contains(Ficha) && Tablero.tabla[f + 3, c - 3].Contains(Ficha))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Tablero.tabla[f, c] = Tablero.tabla[f, c].Replace(Ficha, "■");
                                f++;
                                c--;

                            }

                        }
                    }catch 
                    {
                        break;
                    }
                }


            }




        }

    }


}   

   