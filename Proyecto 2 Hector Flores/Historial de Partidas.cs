using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Hector_Flores
{
    internal class Historial_de_Partidas
    {
        public static string[] rankins = new string[10];
        public static int[] TurnosGanador = new int[10];
        public static string[] TiempoGanador = new string[10];
        public static string nombreganador;
        public static int turnoswinner = 0;
        public static string tiempogano;
        public static Stopwatch sw = Stopwatch.StartNew();
        public static void Tiempoinicial()
        {
            sw = Stopwatch.StartNew();
            sw.Start();

        }


        public static string Tiempofinal()
        {
            sw.Stop();
            TimeSpan timeSpan = sw.Elapsed;
            string Time = timeSpan.ToString("mm':'ss");
            return Time;

        }
        public static void GuardarPartida(Ganador ganador, Jugadores jugador1, Jugadores jugador2)
        {
            if (ganador != null)
            {
                nombreganador = ganador.JugadorGanador(jugador1, jugador2).GetNombre();

                turnoswinner = ganador.JugadorGanador(jugador1, jugador2).GetTurnos();

                tiempogano = Tiempofinal();

                rankins[9] = rankins[8];
                rankins[8] = rankins[7];
                rankins[7] = rankins[6];
                rankins[6] = rankins[5];
                rankins[5] = rankins[4];
                rankins[4] = rankins[3];
                rankins[3] = rankins[2];
                rankins[2] = rankins[1];
                rankins[1] = rankins[0];

                rankins[0] = nombreganador;

                TurnosGanador[9] = TurnosGanador[8];
                TurnosGanador[8] = TurnosGanador[7];
                TurnosGanador[7] = TurnosGanador[6];
                TurnosGanador[6] = TurnosGanador[5];
                TurnosGanador[5] = TurnosGanador[4];
                TurnosGanador[4] = TurnosGanador[3];
                TurnosGanador[3] = TurnosGanador[2];
                TurnosGanador[2] = TurnosGanador[1];
                TurnosGanador[1] = TurnosGanador[0];

                TurnosGanador[0] = turnoswinner;

                TiempoGanador[9] = TiempoGanador[8];
                TiempoGanador[8] = TiempoGanador[7];
                TiempoGanador[7] = TiempoGanador[6];
                TiempoGanador[6] = TiempoGanador[5];
                TiempoGanador[5] = TiempoGanador[4];
                TiempoGanador[4] = TiempoGanador[3];
                TiempoGanador[3] = TiempoGanador[2];
                TiempoGanador[2] = TiempoGanador[1];
                TiempoGanador[1] = TiempoGanador[0];

                TiempoGanador[0] = tiempogano;
            }
        }




        public static void TablaRanking()
        {
            string formato = "{0,-25}{1,-25}{2,-25}";

            Console.WriteLine(formato,"JUGADOR","TIEMPO","TURNOS");

            for (int i = 0; i < 10; i++)
            {
                if (rankins[i] != null && TurnosGanador[i] != null)
                {
                    Console.WriteLine(formato,rankins[i], TiempoGanador[i], TurnosGanador[i]);
                }
                else
                {
                    Console.WriteLine(formato,"PLAYER", "TIME", "TURNS");
                }
            }




        }

    }
}
