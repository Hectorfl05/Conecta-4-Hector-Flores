

using Proyecto_2_Hector_Flores;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

class Conecta4
{



    static void Main()
    {

        Jugadores jugador1 = new Jugadores(" ", " ", 0);
        Jugadores jugador2 = new Jugadores(" ", " ", 0);
        Jugadores Computadora = new Jugadores("Computadora", " ", 0);
        Ganador ganador = new Ganador(jugador1, jugador2);
        int op, op1,op2, r;
        bool repetir = true;

        while (repetir)
        {

            while (true)
            {


                try
                {
                    Console.WriteLine(" ██████  ██████  ███    ██ ███████  ██████ ████████  █████      ██   ██ \r\n██      ██    ██ ████   ██ ██      ██         ██    ██   ██     ██   ██ \r\n██      ██    ██ ██ ██  ██ █████   ██         ██    ███████     ███████ \r\n██      ██    ██ ██  ██ ██ ██      ██         ██    ██   ██          ██ \r\n ██████  ██████  ██   ████ ███████  ██████    ██    ██   ██          ██ \r\n                                                                       ");
   
                    Console.WriteLine("1.Nueva partida");
                    Console.WriteLine("2.Tabla de jugadores");
                    Console.WriteLine("3.Salir del juego ");
                    Console.Write("Opción: ");



                    op = Convert.ToInt32(Console.ReadLine());
                    if (op < 1 || op > 3) 
                    {
                        Console.WriteLine("ERROR, opcion invalida");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    
                    break;
                }
                catch
                {
                    Console.WriteLine("Ingrese una opcion valida");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
            Console.Clear();
            switch (op)
            {
                case 1:

           
                        while (true)
                        {
                              try
                              {
                            Console.WriteLine("███╗   ███╗ ██████╗ ██████╗  ██████╗ ███████╗    ██████╗ ███████╗         ██╗██╗   ██╗███████╗ ██████╗  ██████╗ \r\n████╗ ████║██╔═══██╗██╔══██╗██╔═══██╗██╔════╝    ██╔══██╗██╔════╝         ██║██║   ██║██╔════╝██╔════╝ ██╔═══██╗\r\n██╔████╔██║██║   ██║██║  ██║██║   ██║███████╗    ██║  ██║█████╗           ██║██║   ██║█████╗  ██║  ███╗██║   ██║\r\n██║╚██╔╝██║██║   ██║██║  ██║██║   ██║╚════██║    ██║  ██║██╔══╝      ██   ██║██║   ██║██╔══╝  ██║   ██║██║   ██║\r\n██║ ╚═╝ ██║╚██████╔╝██████╔╝╚██████╔╝███████║    ██████╔╝███████╗    ╚█████╔╝╚██████╔╝███████╗╚██████╔╝╚██████╔╝\r\n╚═╝     ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝ ╚══════╝    ╚═════╝ ╚══════╝     ╚════╝  ╚═════╝ ╚══════╝ ╚═════╝  ╚═════╝                                                                                                                ");
                            Console.WriteLine("1.Vs Jugador");
                            Console.WriteLine("2.Vs Computadora");
                            Console.WriteLine("3.Volver al menú principal");
                            Console.Write("Opción: ");
                            op1 = Convert.ToInt32(Console.ReadLine());
                          
                            if (op1 < 1 || op1 > 3)
                            {
                                Console.WriteLine("ERROR, opcion invalida");
                                Console.ReadKey(true);
                                Console.Clear();
                                continue;
                                
                            }
                            break;
                        }
                         catch
                         {
                            Console.WriteLine("Ingrese una opcion valida");
                            Console.ReadKey(true);
                            Console.Clear();
                         }
                        }
                           Console.Clear();

                    switch (op1)
                    {
                        case 1:
                             
                            
                            Jugadores.Identificador1(jugador1);
                            

                            Jugadores.Identifcador2(jugador2);

                            Tablero.Creartablero();

                            if (Jugadores.PrimerTurno(jugador1, jugador2))
                            {
                                Jugadores.JuegaUno(jugador1, jugador2);
                                Historial_de_Partidas.Tiempoinicial();
                                Jugadores.Turnos1(jugador1, jugador2, ganador);
                                Historial_de_Partidas.Tiempofinal();
                            }
                            else
                            {
                                Jugadores.JuegaDos(jugador1, jugador2);
                                Historial_de_Partidas.Tiempoinicial();
                                Jugadores.Turnos2(jugador1 , jugador2, ganador);
                                Historial_de_Partidas.Tiempofinal();
                            }

                          
                            Console.ReadKey(true);
                            Console.Clear();

                            while (true)
                            {
                                Console.WriteLine("1.Volver al menu principal");
                                Console.WriteLine("2.Salir del juego");
                                Console.Write("Opción: ");
                                try
                                {
                                    int op3 = Convert.ToInt32(Console.ReadLine());
                                    if (op3 == 1)
                                    {
                                        repetir = true;
                                    }
                                    else if (op3 == 2)
                                    {
                                        repetir = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese la opcion valida");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        continue;
                                    }
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Error, ingrese una opcion valida");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    continue;
                                }

                            }

                            ganador.Reinciar();
                           
                            Console.Clear();
                            break;

                        case 2:

                            Jugadores.Identificador1(jugador1);
                            Jugadores.JuegaUno(jugador1, Computadora);
                            Tablero.Creartablero();

                            Jugadores.TurnosCOM(jugador1, Computadora, ganador);
                            Console.ReadKey(true);
                            Console.Clear();

                            while (true)
                            {   
                                Console.WriteLine("1.Volver al menu principal");
                                Console.WriteLine("2.Salir del juego");
                                Console.Write("Opción: ");
                                try
                                {
                                    int op3 = Convert.ToInt32(Console.ReadLine());
                                    if (op3 == 1)
                                    {
                                        repetir = true;
                                    }
                                    else if (op3 == 2)
                                    {
                                        repetir = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese la opcion valida");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        continue;
                                    }
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Error, ingrese una opcion valida");
                                    Console.ReadKey(true);
                                    Console.Clear();

                                    continue;
                                }

                            }
                            ganador.Reinciar();
                            Console.Clear();
                            break;

                        case 3:

                            repetir = true;

                            break;
                    }
                    break;
                case 2:

                    Console.WriteLine("██████╗  █████╗ ███╗   ██╗██╗  ██╗██╗███╗   ██╗ ██████╗ \r\n██╔══██╗██╔══██╗████╗  ██║██║ ██╔╝██║████╗  ██║██╔════╝ \r\n██████╔╝███████║██╔██╗ ██║█████╔╝ ██║██╔██╗ ██║██║  ███╗\r\n██╔══██╗██╔══██║██║╚██╗██║██╔═██╗ ██║██║╚██╗██║██║   ██║\r\n██║  ██║██║  ██║██║ ╚████║██║  ██╗██║██║ ╚████║╚██████╔╝\r\n╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝ ╚═════╝ \r\n                                                        ");

                    Console.WriteLine();
                    Historial_de_Partidas.TablaRanking();

                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                    Console.ReadKey(true);
                    Console.Clear();

                    break;

                case 3:

                    repetir = false;

                    Console.WriteLine("Adiós, hasta la próxima");

                    break;

                default:

                    Console.WriteLine("Ingrese una opcion valida");

                    break;
            }
        }
    }
 }