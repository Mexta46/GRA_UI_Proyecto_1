using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Menu_1
{
    public class Menu1
    {
        public void men()
        {
            bool salida = true;
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - 12, 1);
                Console.WriteLine("Programas de introduccion");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("Menu de selección");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("1)cuadros con asteriscos");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("2)Generar barras con asteriscos");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("3)Espiral de asteriscos");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("4)Regresar al menu anterior");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("5)Salir del programa");
                Console.SetCursorPosition((Console.WindowWidth / 2) - 20, Console.WindowHeight - 3);
                Console.WriteLine("Escribe el numero de la opcion del menu");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight - 2);
                try
                {
                    int opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            cuadros();
                            int selec = seleccion();
                            if (selec == 1)
                            {
                                Console.Clear();
                            }
                            else if (selec == 2)
                            {
                                Console.Clear();
                                men();
                            }
                            else if (selec == 3)
                            {
                                Environment.Exit(0);
                            }
                            salida = false;
                            break;
                        case 2:
                            Console.Clear();
                            barras();
                            int selec2 = seleccion();
                            if (selec2 == 1)
                            {
                                Console.Clear();
                            }
                            else if (selec2 == 2)
                            {
                                Console.Clear();
                                men();
                            }
                            else if (selec2 == 3)
                            {
                                Environment.Exit(0);
                            }
                            salida = false;
                            break;
                        case 3:
                            Console.Clear();
                            espiral();
                            int selec3 = seleccion();
                            if (selec3 == 1)
                            {
                                Console.Clear();
                            }
                            else if (selec3 == 2)
                            {
                                Console.Clear();
                                men();
                            }
                            else if (selec3 == 3)
                            {
                                Environment.Exit(0);
                            }
                            salida = false;
                            break;
                        case 4:
                            salida = false;
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.SetCursorPosition((Console.WindowWidth / 2) - 11, Console.WindowHeight - 4);
                            Console.WriteLine("Error:Opcion no valida");
                            Console.SetCursorPosition(0, 0);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 11, Console.WindowHeight - 4);
                    Console.WriteLine("Error:Opcion no valida");
                    Console.SetCursorPosition(0, 0);
                }
            } while (salida);
        }

        public int seleccion()
        {
            int salida;
            string opc;
            bool repeticion = true;
            do
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - 18, Console.WindowHeight - 3);
                Console.WriteLine("1-Menu anterior 2-Continuar 3-salida");
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.SetCursorPosition(i, Console.WindowHeight - 2);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight - 2);
                opc = Console.ReadLine();
                if (int.TryParse(opc, out salida))
                {
                    if (salida == 1 || salida == 2 || salida == 3)
                    {
                        repeticion = false;
                    }
                    else
                    {
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 11, Console.WindowHeight - 4);
                        Console.WriteLine("Error:Opcion no valida");
                    }
                }
                else
                {
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 11, Console.WindowHeight - 4);
                    Console.WriteLine("Error:Opcion no valida");
                }
            } while (repeticion);
            return salida;
        }

        public void barras()
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - 7, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dibujar barras");
            int width = Console.WindowWidth - 1;
            int height = Console.WindowHeight;   

            int amplitude = height / 3; 
            int step = 6;
            int x = 0;

            while (x + step < width)
            {
                Console.ForegroundColor= ConsoleColor.Magenta;
                for (int i = 0; i < step; i++)
                {
                    Console.SetCursorPosition(x + i, amplitude);
                    Thread.Sleep(100);
                    Console.Write("*");
                }

                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= amplitude; i++)
                {
                    Console.SetCursorPosition(x + step - 1, amplitude + i);
                    Thread.Sleep(100);
                    Console.Write("*");
                }

                x += step;

                Console.ForegroundColor = ConsoleColor.Magenta;
                for (int i = 0; i < step; i++)
                {
                    Console.SetCursorPosition(x + i, amplitude + amplitude);
                    Thread.Sleep(100);
                    Console.Write("*");
                }

                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= amplitude; i++)
                {
                    Console.SetCursorPosition(x + step - 1, amplitude + amplitude - i);
                    Thread.Sleep(100);
                    Console.Write("*");
                }

                x += step;
            }
        }

        public static ConsoleColor ramdomcol()
        {
            //return (ConsoleColor)new Random().Next(Enum.GetValues(typeof(ConsoleColor)).Length);
            ConsoleColor c = ConsoleColor.White;
            Random rnd = new Random();
            int opc = rnd.Next(5);
            switch (opc)
            {
                case 0:
                    c = ConsoleColor.Green;
                    break;
                case 1:
                    c = ConsoleColor.Yellow;
                    break;
                case 2:
                    c = ConsoleColor.Red;
                    break;
                case 3:
                    c = ConsoleColor.Blue;
                    break;
                case 4:
                    c = ConsoleColor.Cyan;
                    break;
            }
            return c;
        }

        public static void cuadros()
        {
            int dimensiones = 9, espacios = 2, superior, inferior, ancho, alto;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dibujar rectangulos");
            superior = Console.WindowWidth / (dimensiones * 4);
            ancho = (Console.WindowWidth - superior) / espacios;
            alto = Console.WindowHeight / espacios;
            Console.ForegroundColor = ramdomcol();
            Console.SetCursorPosition(ancho, alto);
            for (int linea = 0; linea < superior; linea++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            superior = 0;
            inferior = 0;
            for (int repe = 0; superior < Console.WindowWidth - 10 && inferior < Console.WindowHeight - 10; repe++)
            {
                Console.ForegroundColor = ramdomcol();
                superior = (repe * dimensiones * 2);
                inferior = (repe * (dimensiones / 3) + repe - 1);
                ancho = (Console.WindowWidth - superior) / espacios;
                alto = (Console.WindowHeight - inferior) / espacios;
                Console.SetCursorPosition(ancho, alto);
                for (int columna = 0; columna < superior; columna++)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                for (int fila = 0; fila < inferior; fila++)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop + 1);
                for (int columna = 0; columna < superior; columna++)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                for (int fila = 0; fila < inferior; fila++)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                    Console.Write("*");
                    Thread.Sleep(100);
                }
            }
        }

        public static void espiral()
        {
            int centrox, centroy, horizontal, vertical;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dibujar espiral");
            centrox = Console.WindowWidth / 2;
            centroy = Console.WindowHeight / 2;
            horizontal = 5;
            vertical = 1;
            Console.SetCursorPosition(centrox + horizontal, centroy);
            do
            {
                for (int columna = 0; columna <= horizontal; columna++)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                    Console.ForegroundColor = ramdomcol();
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                for (int fila = 0; fila < vertical; fila++)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                    Console.ForegroundColor = ramdomcol();
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                horizontal += 5;
                vertical += 2;
                for (int columna = 0; columna < horizontal; columna++)
                {
                    Console.ForegroundColor = ramdomcol();
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                for (int fila = 0; fila < vertical; fila++)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                    Console.ForegroundColor = ramdomcol();
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop + 1);
                horizontal += 3;
                vertical += 2;
            }
            while (horizontal < Console.WindowWidth - 10 && vertical < Console.WindowHeight - 10);
        }
    }
}
