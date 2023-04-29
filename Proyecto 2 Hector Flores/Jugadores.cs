using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Hector_Flores
{
    internal class Jugadores
    {


        //Constructor


        public string? player { get; internal set; }
        public string? Ficha { get; internal set; }

        public int Turnos = 0;



        public Jugadores(string player, string Ficha, int Turnos)
        {
            this.player = player;
            this.Ficha = Ficha;
            this.Turnos = Turnos;


        }


        public string GetNombre()
        {
            return player;
        }

        public string GetFicha()
        {
            return Ficha;
        }

        public int GetTurnos()
        {
            return Turnos;
        }


        public static void Identificador1(Jugadores jugador)
        {

            while (true)
            {
                Console.WriteLine("Ingrese el nombre del jugador 1");
                jugador.player = Console.ReadLine();
                jugador.Turnos = 0;

                if (jugador.player.Length > 11)
                {
                    jugador.player = jugador.player.Substring(0, 11);
                }


                if (jugador.player.ToUpper() == "COMPUTADORA" || jugador.player == "")
                {
                    Console.WriteLine("Escriba un nombre valido para el jugador 1");
                    Console.ReadKey(true);
                    Console.Clear();
                    
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
        }



        public static void Identifcador2(Jugadores jugador)
        {

            while (true)
            {
                Console.WriteLine("Ingrese el nombre del jugador 2");
                jugador.player = Console.ReadLine();
                jugador.Turnos = 0;

                if (jugador.player.Length > 11)
                {
                    jugador.player = jugador.player.Substring(0, 11);
                }
                if (jugador.player == "" || jugador.player.ToUpper() == "COMPUTADORA")
                {
                    Console.WriteLine("Escriba un nombre valido para el jugador 2");
                    Console.ReadKey(true);
                    Console.Clear();

                }
                else
                {
                    break;
                }
            }
            Console.Clear();
        }


        public static bool PrimerTurno(Jugadores jugador1,Jugadores jugador2)
        {
           
            int r;
            while (true)
            {
                Console.WriteLine("¿Quién hará el primer movimiento? " + jugador1.player + "(1)" + "/" + jugador2.player + "(2)");
                Console.WriteLine("(Ingrese el numero del jugador)");
                try
                {
                    r = Convert.ToInt32(Console.ReadLine());
                    if (r == 1 || r == 2)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un jugador valido (1 o 2)");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.WriteLine("ERROR, Ingrese un numero valido");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }

            if (r == 1)
            {
               
                return true;
            }
            else
            {
                
                return false;
            }
            
        }

        public static void JuegaUno(Jugadores jugador1, Jugadores jugador2)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(jugador1.player + " tiene el primer turno.");
                    Console.WriteLine("Escoja la ficha que usará o/x ");
                    jugador1.Ficha = Console.ReadLine();

                    if (jugador1.Ficha == "x")
                    {

                        jugador2.Ficha = "o";

                        break;
                    }
                    else if (jugador1.Ficha == "o")
                    {
                        jugador2.Ficha = "x";
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Escoja una ficha valida");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, No ingrese numeros o simbolos extraños");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
            Console.Clear();
        }


        public static void JuegaDos(Jugadores jugador1,Jugadores jugador2)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(jugador2.player + " tiene el primer turno.");
                    Console.WriteLine("Escoja la ficha que usará o/x ");
                    jugador2.Ficha = Console.ReadLine();

                    if (jugador2.Ficha == "x")
                    {
                        jugador1.Ficha = "o";

                        break;
                    }
                    else if (jugador2.Ficha == "o")
                    {
                        jugador1.Ficha = "x";
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Escoja una ficha valida");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, No ingrese numeros o simbolos extraños");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                
            }
            Console.Clear();
        }


        public static void Turnos1(Jugadores jugador1, Jugadores jugador2, Ganador ganador)
        {
                
            do
            {
                Console.WriteLine("Es el turno de: " + jugador1.GetNombre());
                Console.WriteLine("Su ficha es: " + jugador1.GetFicha());
                Tablero.MostrarTablero();
                Tablero.ColocarFicha1(jugador1, jugador2);
                jugador1.Turnos++;
                Console.Clear();
                ganador.JugadorGanador(jugador1, jugador2);

                if (ganador.JugadorGanador(jugador1, jugador2) != null)
                {
                    Ganador.CambiarFicha(ganador.JugadorGanador(jugador1, jugador2).GetFicha());
                    Tablero.MostrarTablero();
                    Console.WriteLine();
                    Console.WriteLine("██     ██ ██ ███    ██ ███    ██ ███████ ██████  \r\n██     ██ ██ ████   ██ ████   ██ ██      ██   ██ \r\n██  █  ██ ██ ██ ██  ██ ██ ██  ██ █████   ██████  \r\n██ ███ ██ ██ ██  ██ ██ ██  ██ ██ ██      ██   ██ \r\n ███ ███  ██ ██   ████ ██   ████ ███████ ██   ██ \r\n                                                 \r\n                                                 ");
                    Console.Write("\n");
                    Console.WriteLine("El ganador es: " + ganador.JugadorGanador(jugador1, jugador2).GetNombre());
                    Historial_de_Partidas.GuardarPartida(ganador, jugador1, jugador2);
                    break;
                }

                Console.Clear();


                Console.WriteLine("Es el turno de: " + jugador2.player);
                Console.WriteLine("Su ficha es: " + jugador2.Ficha);
                Tablero.MostrarTablero();
                Tablero.ColocarFicha2(jugador1, jugador2);
                jugador2.Turnos++;
                Console.Clear();
                ganador.JugadorGanador(jugador1, jugador2);
                if (ganador.JugadorGanador(jugador1, jugador2) != null)
                {
                    Ganador.CambiarFicha(ganador.JugadorGanador(jugador1, jugador2).GetFicha());
                    Tablero.MostrarTablero();
                    Console.WriteLine();
                    Console.WriteLine("██     ██ ██ ███    ██ ███    ██ ███████ ██████  \r\n██     ██ ██ ████   ██ ████   ██ ██      ██   ██ \r\n██  █  ██ ██ ██ ██  ██ ██ ██  ██ █████   ██████  \r\n██ ███ ██ ██ ██  ██ ██ ██  ██ ██ ██      ██   ██ \r\n ███ ███  ██ ██   ████ ██   ████ ███████ ██   ██ \r\n                                                 \r\n                                                 ");
                    Console.Write("\n");
                    Console.WriteLine("El ganador es: " + ganador.JugadorGanador(jugador1, jugador2).GetNombre());
                    Historial_de_Partidas.GuardarPartida(ganador, jugador1, jugador2);
                    break;
                }

                 bool tablallena = Tablero.TablaLlena(jugador1.Ficha, jugador2.Ficha);

                if (tablallena == true)
                {
                    Tablero.MostrarTablero();
                    Console.WriteLine("EMPATE");
                    break;
                }
                Console.Clear();

            } while (true);
        }

        public static void Turnos2(Jugadores jugador1, Jugadores jugador2,Ganador ganador)
        {
            do
            {
                Console.WriteLine("Es el turno de: " + jugador2.player);
                Console.WriteLine("Su ficha es: " + jugador2.Ficha);
                Tablero.MostrarTablero();
                Tablero.ColocarFicha2(jugador1, jugador2);
                jugador2.Turnos++;
                Console.Clear();
                ganador.JugadorGanador(jugador1, jugador2);
                if (ganador.JugadorGanador(jugador1, jugador2) != null)
                {
                    Ganador.CambiarFicha(ganador.JugadorGanador(jugador1, jugador2).GetFicha());
                    Tablero.MostrarTablero();
                    Console.WriteLine();
                    Console.WriteLine("██     ██ ██ ███    ██ ███    ██ ███████ ██████  \r\n██     ██ ██ ████   ██ ████   ██ ██      ██   ██ \r\n██  █  ██ ██ ██ ██  ██ ██ ██  ██ █████   ██████  \r\n██ ███ ██ ██ ██  ██ ██ ██  ██ ██ ██      ██   ██ \r\n ███ ███  ██ ██   ████ ██   ████ ███████ ██   ██ \r\n                                                 \r\n                                                 ");
                    Console.Write("\n");
                    Console.WriteLine("El ganador: " + ganador.JugadorGanador(jugador1, jugador2).GetNombre());
                    Historial_de_Partidas.GuardarPartida(ganador, jugador1, jugador2);
                    break;
                }

                bool tablallena = Tablero.TablaLlena(jugador1.Ficha, jugador2.Ficha);

                if (tablallena == true)
                {
                    Tablero.MostrarTablero();
                    Console.WriteLine("EMPATE");
                    break;
                }


                Console.Clear();

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                Console.WriteLine("Es el turno de: " + jugador1.player);
                Console.WriteLine("Su ficha es: " + jugador1.Ficha);
                Tablero.MostrarTablero();
                Tablero.ColocarFicha1(jugador1, jugador2);
                jugador1.Turnos++;
                Console.Clear();
                ganador.JugadorGanador(jugador1, jugador2);

                if (ganador.JugadorGanador(jugador1, jugador2) != null)
                {
                    Ganador.CambiarFicha(ganador.JugadorGanador(jugador1, jugador2).GetFicha());
                    Tablero.MostrarTablero();
                    Console.WriteLine();
                    Console.WriteLine("██     ██ ██ ███    ██ ███    ██ ███████ ██████  \r\n██     ██ ██ ████   ██ ████   ██ ██      ██   ██ \r\n██  █  ██ ██ ██ ██  ██ ██ ██  ██ █████   ██████  \r\n██ ███ ██ ██ ██  ██ ██ ██  ██ ██ ██      ██   ██ \r\n ███ ███  ██ ██   ████ ██   ████ ███████ ██   ██ \r\n                                                 \r\n                                                 ");
                   Console.Write("\n");
                    Console.WriteLine("el ganado:" + ganador.JugadorGanador(jugador1, jugador2).GetNombre());
                    Historial_de_Partidas.GuardarPartida(ganador, jugador1, jugador2);
                    break;
                }

                tablallena = Tablero.TablaLlena(jugador1.Ficha, jugador2.Ficha);

                if (tablallena == true)
                {
                    Tablero.MostrarTablero();
                    Console.WriteLine("EMPATE");
                    break;
                }
                Console.Clear();

            } while (true);
        }


        public static void TurnosCOM(Jugadores jugador1, Jugadores jugador2, Ganador ganador)
        {
            do
            {
                Console.WriteLine("Es el turno de: " + jugador1.player);
                Console.WriteLine("Su ficha es: " + jugador1.Ficha);
                Tablero.MostrarTablero();
                Tablero.ColocarFicha1(jugador1, jugador2);
                Console.Clear();
                ganador.JugadorGanador(jugador1, jugador2);
                if (ganador.JugadorGanador(jugador1, jugador2) != null)
                {
                    Ganador.CambiarFicha(ganador.JugadorGanador(jugador1, jugador2).GetFicha());
                    Tablero.MostrarTablero();
                    Console.WriteLine();
                    Console.WriteLine("██     ██ ██ ███    ██ ███    ██ ███████ ██████  \r\n██     ██ ██ ████   ██ ████   ██ ██      ██   ██ \r\n██  █  ██ ██ ██ ██  ██ ██ ██  ██ █████   ██████  \r\n██ ███ ██ ██ ██  ██ ██ ██  ██ ██ ██      ██   ██ \r\n ███ ███  ██ ██   ████ ██   ████ ███████ ██   ██ \r\n                                                 \r\n                                                 ");
                    Console.Write("\n");
                    Console.WriteLine("Ha ganado " + ganador.JugadorGanador(jugador1, jugador2).GetNombre());
                    break;
                }

                bool tablallena = Tablero.TablaLlena(jugador1.Ficha, jugador2.Ficha);

                if (tablallena == true)
                {
                    Tablero.MostrarTablero();
                    Console.WriteLine("EMPATE");
                    break;
                }


                Console.Clear();

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                Console.WriteLine("Es el turno de: " + jugador1.player);
                Console.WriteLine("Su ficha es: " + jugador1.Ficha);
                Tablero.MostrarTablero();
                Tablero.ColocarFichaCOM(jugador1, jugador2);
                Console.Clear();
                ganador.JugadorGanador(jugador1, jugador2);

                if (ganador.JugadorGanador(jugador1, jugador2) != null)
                {
                    Ganador.CambiarFicha(ganador.JugadorGanador(jugador1, jugador2).GetFicha());
                    Tablero.MostrarTablero();
                    Console.WriteLine();
                    Console.Write("██     ██ ██ ███    ██ ███    ██ ███████ ██████  \r\n██     ██ ██ ████   ██ ████   ██ ██      ██   ██ \r\n██  █  ██ ██ ██ ██  ██ ██ ██  ██ █████   ██████  \r\n██ ███ ██ ██ ██  ██ ██ ██  ██ ██ ██      ██   ██ \r\n ███ ███  ██ ██   ████ ██   ████ ███████ ██   ██ \r\n                                                 \r\n                                                 ");
                    Console.WriteLine("\n");
                    Console.WriteLine("Ha ganado " + ganador.JugadorGanador(jugador1, jugador2).GetNombre());
                    break;
                }

                tablallena = Tablero.TablaLlena(jugador1.Ficha, jugador2.Ficha);

                if (tablallena == true)
                {
                    Tablero.MostrarTablero();
                    Console.WriteLine("EMPATE");
                    break;
                }
                Console.Clear();

            } while (true);
        }
    }

}
