using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_1
{
    public class Menu2
    {
        public void men()
        {
            bool salida = true;
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - 12, 1);
                Console.WriteLine("Programas de localizacion");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("Menu de selección");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("1)Mostrar la tabla de senos del 0 al 90");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("2)Mostrar la tabla de cosenos del 0 al 90");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("3)Dados los dos catetos de un triángulo rectángulo, calcule la hipotenusa y el valor de los ángulos menores de 90 grados");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("4)Dados 2 puntos de un recta calcule: " +
                    " a) El valor de la pendiente" +
                    " b) El ángulo de inclinación" +
                    " c) Las coordenadas del punto medio.");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("5)Calcular y mostrar las coordenadas (x,y) de la trayectoria de un proyectil en intervalos de tiempo (0.1, 0.2, ...)");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("6)Regresar al menu anterior");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.WriteLine("7)Salir");
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
                            TablaSenos();
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
                            TablaCosenos();
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
                            Triangulo();
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
                            Console.Clear();
                            Recta();
                            int selec4 = seleccion();
                            if (selec4 == 1)
                            {
                                Console.Clear();
                            }
                            else if (selec4 == 2)
                            {
                                Console.Clear();
                                men();
                            }
                            else if (selec4 == 3)
                            {
                                Environment.Exit(0);
                            }
                            salida = false;
                            break;
                        case 5:
                            Console.Clear();
                            ProgramaProyectil();
                            int selec5 = seleccion();
                            if (selec5 == 1)
                            {
                                Console.Clear();
                            }
                            else if (selec5 == 2)
                            {
                                Console.Clear();
                                men();
                            }
                            else if (selec5 == 3)
                            {
                                Environment.Exit(0);
                            }
                            salida = false;
                            break;
                        case 6:
                            Console.Clear();
                            salida = false;
                            break;
                        case 7:
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

        public void TablaSenos()
        {
            int y = 4;
            int x = 2;
            Console.WriteLine("Tabla de Senos (0° a 90°) - Sin Funciones Propias");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Grados\tSeno");

            for (int angulo = 0; angulo <= 90; angulo++)
            {
                y++;
                if (y == (Console.WindowHeight-5))
                {
                    x += 17;
                    y = 4;
                }
                Console.SetCursorPosition(x, y);
                double radianes = ConvertirGradosARadianes(angulo); // Convertir grados a radianes
                double seno = CalcularSeno(radianes); // Calcular seno usando serie de Taylor
                Console.WriteLine($"{angulo}    {seno:F6}"); // Mostrar resultado con 6 decimales
            }
        }

        // Función para convertir grados a radianes (usamos aproximación de PI)
        public double ConvertirGradosARadianes(double grados)
        {
            double PI = 3.14159265358979; // Aproximación de PI
            return grados * (PI / 180.0);
        }

        // Función para calcular el seno usando la serie de Taylor
        public double CalcularSeno(double x)
        {
            double resultado = 0;
            int iteraciones = 10; // Número de términos en la serie para mayor precisión

            for (int n = 0; n < iteraciones; n++)
            {
                double termino = Potencia(-1, n) * Potencia(x, 2 * n + 1) / Factorial(2 * n + 1);
                resultado += termino;
            }

            return resultado;
        }

        // Función para calcular la potencia manualmente
        public double Potencia(double baseNum, int exponente)
        {
            double resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        // Función para calcular el factorial manualmente
        public double Factorial(int numero)
        {
            double resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;

        }

        //Programa 2
        public void TablaCosenos()
        {
            int y = 4;
            int x = 2;
            Console.WriteLine("Tabla de Cosenos (0° a 90°) - Sin Funciones Propias");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Grados\tCoseno");

            for (int angulo = 0; angulo <= 90; angulo++)
            {
                y++;
                if (y == (Console.WindowHeight - 5))
                {
                    x += 17;
                    y = 4;
                }
                Console.SetCursorPosition(x, y);
                double radianes = ConvertirGradosARadianes2(angulo); // Convertir grados a radianes
                double coseno = CalcularCoseno(radianes); // Calcular coseno usando serie de Taylor
                Console.WriteLine($"{angulo}\t{coseno:F6}"); // Mostrar resultado con 6 decimales
            }
        }

        // Función para convertir grados a radianes (usamos aproximación de PI)
        public double ConvertirGradosARadianes2(double grados)
        {
            double PI = 3.14159265358979; // Aproximación de PI
            return grados * (PI / 180.0);
        }

        // Función para calcular el coseno usando la serie de Taylor
        public double CalcularCoseno(double x)
        {
            double resultado = 0;
            int iteraciones = 10; // Número de términos en la serie para mayor precisión

            for (int n = 0; n < iteraciones; n++)
            {
                double termino = Potencia1(-1, n) * Potencia1(x, 2 * n) / Factorial1(2 * n);
                resultado += termino;
            }

            return resultado;
        }

        // Función para calcular la potencia manualmente
        public double Potencia1(double baseNum, int exponente)
        {
            double resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        // Función para calcular el factorial manualmente
        public double Factorial1(int numero)
        {
            double resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        //Programa 3
        public void Triangulo()
        {
            double cateto1 = ObtenerCateto("Ingrese el valor del primer cateto:");
            double cateto2 = ObtenerCateto("Ingrese el valor del segundo cateto:");

            // Cálculo de la hipotenusa con Pitágoras
            double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            // Cálculo de los ángulos en grados
            double angulo1 = Math.Atan(cateto1 / cateto2) * (180 / Math.PI);
            double angulo2 = 90 - angulo1;

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Hipotenusa: {hipotenusa:F6}");
            Console.WriteLine($"Ángulo 1: {angulo1:F6}°");
            Console.WriteLine($"Ángulo 2: {angulo2:F6}°");

            // Dibujar el triángulo en consola
            DibujarTriangulo(cateto1, cateto2);

        }

        // Método para obtener un cateto con validación
        public double ObtenerCateto(string mensaje)
        {
            double cateto;
            bool valido;
            do
            {
                Console.WriteLine(mensaje);
                valido = double.TryParse(Console.ReadLine(), out cateto) && cateto > 0;
                if (!valido)
                {
                    Console.WriteLine("Por favor, ingresa un valor válido mayor que 0.");
                }
            } while (!valido);
            return cateto;
        }

        public void DibujarTriangulo(double baseTriangulo, double altura)
        {
            int maxAltura = 15;  // Límite para no desbordar la pantalla
            int maxBase = 30;

            // Escalamos si es muy grande
            double factorEscala = Math.Min(maxAltura / altura, maxBase / baseTriangulo);
            int baseEscalada = (int)(baseTriangulo * factorEscala);
            int alturaEscalada = (int)(altura * factorEscala);

            Console.WriteLine("\nTriángulo Representado en Consola:");

            for (int y = 0; y <= alturaEscalada; y++)
            {
                for (int x = 0; x <= baseEscalada; x++)
                {
                    if (x == 0 || y == alturaEscalada || x == (int)(y * (baseEscalada / (double)alturaEscalada)))
                        Console.Write("*"); // Lados del triángulo
                    else
                        Console.Write(" "); // Espacios vacíos
                }
                Console.WriteLine();
            }
        }

        // Programa 4
        public void Recta()
        {
            // Solicitar coordenadas del primer punto
            Console.WriteLine("Ingrese la coordenada X del primer punto:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada Y del primer punto:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            // Solicitar coordenadas del segundo punto
            Console.WriteLine("Ingrese la coordenada X del segundo punto:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada Y del segundo punto:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Calcular pendiente
            double pendiente;
            if (x2 - x1 == 0)
            {
                Console.WriteLine("\nLa recta es vertical, la pendiente es infinita.");
                pendiente = double.PositiveInfinity;
            }
            else
            {
                pendiente = (y2 - y1) / (x2 - x1);
                Console.WriteLine($"\nPendiente: {pendiente:F6}");
            }

            // Calcular el ángulo de inclinación
            double angulo;
            if (double.IsInfinity(pendiente))
            {
                angulo = 90; // La inclinación de una recta vertical es 90°
            }
            else
            {
                angulo = Math.Atan(pendiente) * (180 / Math.PI);
            }
            Console.WriteLine($"Ángulo de inclinación: {angulo:F6}°");

            // Calcular punto medio
            double puntoMedioX = (x1 + x2) / 2;
            double puntoMedioY = (y1 + y2) / 2;
            Console.WriteLine($"Punto medio: ({puntoMedioX:F6}, {puntoMedioY:F6})");

        }

        public void ProgramaProyectil()
        {
            Console.Clear();
            Console.WriteLine("Programa 5: Cálculo de la trayectoria de un proyectil\n");

            // Constante de gravedad
            const double g = 9.81;

            // Pedir datos al usuario con validación
            double v0 = ObtenerDato("Ingrese la velocidad inicial (m/s):");
            double angulo = ObtenerDato("Ingrese el ángulo de lanzamiento (grados):");

            // Convertir ángulo a radianes
            double theta = angulo * Math.PI / 180;

            // Calcular componentes de la velocidad inicial
            double v0x = v0 * Math.Cos(theta);
            double v0y = v0 * Math.Sin(theta);

            // Calcular tiempo total de vuelo
            double tiempoTotal = (2 * v0y) / g;

            // Calcular altura máxima
            double alturaMaxima = (v0y * v0y) / (2 * g);

            // Calcular distancia máxima (alcance)
            double distanciaMaxima = v0x * tiempoTotal;

            Console.WriteLine("\nTrayectoria del proyectil:");

            // Mostrar coordenadas en intervalos de 0.1 segundos
            Console.WriteLine("\nTiempo (s) | X (m)  | Y (m)  | Velocidad (m/s)");
            Console.WriteLine("--------------------------------------------");

            for (double t = 0; t <= tiempoTotal; t += 0.1)
            {
                double x = v0x * t;
                double y = v0y * t - 0.5 * g * t * t;

                if (y < 0) break; // Detener cuando el proyectil toca el suelo

                // Calcular velocidad instantánea
                double vy = v0y - g * t;
                double v = Math.Sqrt(v0x * v0x + vy * vy);

                Console.WriteLine($"{t:F1}       | {x:F2}   | {y:F2}   | {v:F2}");
            }

            // Mostrar valores finales
            Console.WriteLine("\nResultados finales:");
            Console.WriteLine($"Altura máxima alcanzada: {alturaMaxima:F2} m");
            Console.WriteLine($"Distancia máxima recorrida: {distanciaMaxima:F2} m");
            Console.WriteLine($"Tiempo total de vuelo: {tiempoTotal:F2} s");

        }

        // Método para obtener datos con validación
        public double ObtenerDato(string mensaje)
        {
            double valor;
            bool valido;
            do
            {
                Console.WriteLine(mensaje);
                valido = double.TryParse(Console.ReadLine(), out valor);
                if (!valido || valor <= 0)
                {
                    Console.WriteLine("Por favor, ingresa un número válido y mayor a 0.");
                }
            } while (!valido || valor <= 0);
            return valor;
        }
    }
}
