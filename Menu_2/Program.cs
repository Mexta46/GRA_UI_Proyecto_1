using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            MostrarMenu();
            Console.SetCursorPosition(2, 12);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 20, Console.WindowHeight - 2);
            Console.WriteLine("Intserte el numero de la opcion elegida:");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 20, Console.WindowHeight - 2);
            if (int.TryParse(Console.ReadLine(), out opcion))
            {

                switch (opcion)
                {
                    case 1:
                        do
                        {
                            JuegoAhorcado();
                        } while (submenus() != 1);
                        break;
                    case 2:
                        do
                        {
                            ContarSignos();
                        } while (submenus() != 1);
                        break;
                    case 3:
                        do
                        {
                            TransponerMatriz();
                        } while (submenus() != 1);
                        break;
                    case 4:
                        do
                        {
                            MayorMenorMatriz();
                        } while (submenus() != 1);
                        break;
                    case 5:
                        do
                        {
                            ParesImpares();
                        } while (submenus() != 1);
                        break;
                    case 6:
                        do
                        {
                            SumaFilasColumnas();
                        } while (submenus() != 1);
                        break;
                    case 7:
                        do
                        {
                            MultiplicacionMatrices();
                        } while (submenus() != 1);
                        break;
                    case 8:
                        do
                        {
                            DesviacionEstandar();
                        } while (submenus() != 1);
                        break;
                    default:
                        Console.Clear();
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 23, Console.WindowHeight - 3);
                        Console.WriteLine("Error: el valor numerico insertado no es valido");
                        Console.SetCursorPosition(0, 0);
                        break;
                }

            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth / 2) - 20, Console.WindowHeight - 3);
                Console.WriteLine("Error: el valor insertado no es numerico");
                Console.SetCursorPosition(0, 0);
            }
        } while (opcion != 9);
    }

    static int submenus()
    {
        int salida;
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
            if (int.TryParse(Console.ReadLine(), out salida))
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
        if (salida == 3)
        {
            Environment.Exit(0);
        }
        Console.Clear();
        return salida;
    }

    static void EscribirEn(int x, int y, string texto)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(texto);
    }

    static void MostrarMenu()
    {
        int centroX = Console.WindowWidth / 2 - 20;
        int y = 2;

        EscribirEn(centroX, y++, "=== MENÚ DE PROGRAMAS ===");
        EscribirEn(centroX, y++, "1. Juego del ahorcado");
        EscribirEn(centroX, y++, "2. Contar positivos, negativos y ceros");
        EscribirEn(centroX, y++, "3. Transposición de matriz");
        EscribirEn(centroX, y++, "4. Mayor y menor en matriz");
        EscribirEn(centroX, y++, "5. Suma y promedio de pares e impares");
        EscribirEn(centroX, y++, "6. Suma de filas y columnas en matriz 3x3");
        EscribirEn(centroX, y++, "7. Multiplicación de matrices");
        EscribirEn(centroX, y++, "8. Calcular desviación estándar");
        EscribirEn(centroX, y++, "9. Salir");
    }

    static void MostrarMatriz(string nombre, int[,] matriz, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine($"{nombre}:");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.SetCursorPosition(x, y + i + 1);
            Console.Write("|");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($" {matriz[i, j],2} ");
            }
            Console.Write("|");
        }
    }




    static void MostrarVector(string nombre, int[] vector, int x = 2, int y = 10)
    {
        EscribirEn(x, y, nombre + ":");
        for (int i = 0; i < vector.Length; i++)
        {
            EscribirEn(x + i * 6, y + 1, $"{vector[i],5}");
        }
    }


    static void JuegoAhorcado()
    {
        string palabra = "computadora";
        string Titulo = "== Juego del ahorcado ==";
        string adivinada = new string('_', palabra.Length);
        int errores = 0;
        List<char> letrasIncorrectas = new List<char>();

        while (errores < 6 && adivinada.Contains('_'))
        {
            Console.Clear();
            DibujoAhorcado(errores);
            EscribirEn((Console.WindowWidth/2)-(Titulo.Length/2), 0, Titulo);
            EscribirEn(30, 2, $"Palabra: {adivinada}");
            EscribirEn(30, 4, "Letra: ");
            char letra = char.ToLower(Console.ReadKey().KeyChar);

            if (palabra.Contains(letra))
            {
                char[] nueva = adivinada.ToCharArray();
                for (int i = 0; i < palabra.Length; i++)
                    if (palabra[i] == letra)
                        nueva[i] = letra;
                adivinada = new string(nueva);
            }
            else
            {
                if (!letrasIncorrectas.Contains(letra))
                {
                    errores++;
                    letrasIncorrectas.Add(letra);
                }
            }
        }

        Console.Clear();
        DibujoAhorcado(errores);
        if (errores == 6)
            EscribirEn(2, 15, "¡Perdiste! La palabra era: " + palabra);
        else
            EscribirEn(2, 15, "¡Ganaste! La palabra es: " + palabra);
    }

    static void DibujoAhorcado(int fallos)
    {
        string[] dibujo = new string[7];
        dibujo[0] = " +---+";
        dibujo[1] = " |   |";
        dibujo[2] = fallos > 0 ? " O   |" : "     |";
        dibujo[3] = fallos > 3 ? "/|\\  |" : (fallos == 3 ? "/|   |" : fallos == 2 ? " |   |" : "     |");
        dibujo[4] = fallos > 5 ? "/ \\  |" : (fallos == 5 ? "/    |" : "     |");
        dibujo[5] = "     |";
        dibujo[6] = "=======";

        for (int i = 0; i < dibujo.Length; i++)
            EscribirEn(2, i + 2, dibujo[i]);
    }

    static int[,] RellenarMatrizInteractiva(string nombre, int filas, int columnas, int x, int y)
    {
        int longitud;
        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                matriz[i, j] = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{nombre}:");
                    int[,] posicionX = new int[columnas,filas];

                    for (int fi = 0; fi < filas; fi++)
                    {
                        longitud = 0;
                        for (int xc = 0; xc < Console.WindowWidth; xc++)
                        {
                            Console.SetCursorPosition(xc, y + fi + 1);
                            Console.Write(" ");
                        }
                        Console.SetCursorPosition(x, y + fi + 1);
                        Console.Write("|");
                        for (int co = 0; co < columnas; co++)
                        {
                            if (matriz[fi, co] == 0)
                            {
                                longitud = matriz[fi, co].ToString().Length/2;
                                Console.SetCursorPosition(Console.CursorLeft + co + longitud, y + fi + 1);
                                posicionX[co,fi] = Console.CursorLeft;
                                Console.Write("_");
                            }
                            else
                            {
                                Console.Write($" {matriz[fi, co]} ");

                            }
                        }
                        Console.Write("|");
                    }
                    Console.SetCursorPosition(posicionX[j,i], y + i + 1);
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int valor))
                    {
                        matriz[i, j] = valor;
                        break;
                    }
                }
            }
        }
        Console.SetCursorPosition(x, y);
        Console.WriteLine($"{nombre}:");

        for (int fi = 0; fi < filas; fi++)
        {
            longitud = 0;
            for (int xc = 0; xc < Console.WindowWidth; xc++)
            {
                Console.SetCursorPosition(xc, y + fi + 1);
                Console.Write(" ");
            }
            Console.SetCursorPosition(x, y + fi + 1);
            Console.Write("|");
            for (int co = 0; co < columnas; co++)
            {
                if (matriz[fi, co] == 0)
                {
                    longitud = matriz[fi, co].ToString().Length / 2;
                    Console.SetCursorPosition(Console.CursorLeft + co + longitud, y + fi + 1);
                    Console.Write("_");
                }
                else
                {
                    Console.Write($" {matriz[fi, co]} ");

                }
            }
            Console.Write("|");
        }

        return matriz;
    }


    static void ContarSignos()
    {
        Console.Clear();
        string Titulo = "== Contar positivos, negativos y ceros ==";
        EscribirEn((Console.WindowWidth / 2) - (Titulo.Length / 2), 0, Titulo);
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");
        int centroX = (Console.WindowWidth - (n * 3 + 4)) / 2;
        int[,] matriz = RellenarMatrizInteractiva("Matriz A", m, n, centroX, 5);
        int pos = 0, neg = 0, ceros = 0;

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] > 0) pos++;
                else if (matriz[i, j] < 0) neg++;
                else ceros++;
            }

        EscribirEn(2, 22, $"Positivos: {pos}");
        EscribirEn(2, 23, $"Negativos: {neg}");
        Console.ForegroundColor = ConsoleColor.Red;
        EscribirEn(2, 24, $"Ceros: {ceros}");
        Console.ResetColor();
    }

    static void TransponerMatriz()
    {
        Console.Clear();
        string Titulo = "== Transposición de matriz ==";
        EscribirEn((Console.WindowWidth / 2) - (Titulo.Length / 2), 0, Titulo);
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");

        int centroX = (Console.WindowWidth - (n * 3 + 4)) / 2;
        int[,] matriz = RellenarMatrizInteractiva("Matriz A", m, n, centroX, 5);

        int[,] transpuesta = new int[n, m];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                transpuesta[j, i] = matriz[i, j];

        MostrarMatriz("Matriz A^T", transpuesta, centroX, Console.CursorTop + 1);
    }

    static void MayorMenorMatriz()
    {
        Console.Clear();
        string Titulo = "== Mayor y menor en matriz ==";
        EscribirEn((Console.WindowWidth / 2) - (Titulo.Length / 2), 0, Titulo);
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");
        int centroX = (Console.WindowWidth - (n * 3 + 4)) / 2;
        int[,] matriz = RellenarMatrizInteractiva("Matriz A", m, n, centroX, 5);
        int max = int.MinValue, min = int.MaxValue;
        (int, int) posMax = (0, 0), posMin = (0, 0);

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] > max) { max = matriz[i, j]; posMax = (i, j); }
                if (matriz[i, j] < min) { min = matriz[i, j]; posMin = (i, j); }
            }

        EscribirEn(2, 22, $"Mayor: {max} en ({posMax.Item1},{posMax.Item2})");
        Console.ForegroundColor = ConsoleColor.Green;
        EscribirEn(2, 23, $"Menor: {min} en ({posMin.Item1},{posMin.Item2})");
        Console.ResetColor();
    }

    static void ParesImpares()
    {
        Console.Clear();
        string Titulo = "== Suma y promedio de pares e impares ==";
        EscribirEn((Console.WindowWidth / 2) - (Titulo.Length / 2), 0, Titulo);
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");
        int centroX = (Console.WindowWidth - (n * 3 + 4)) / 2;
        int[,] matriz = RellenarMatrizInteractiva("Matriz A", m, n, centroX, 5);
        int sumaP = 0, sumaI = 0, contP = 0, contI = 0, sumaTotal = 0;

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                sumaTotal += matriz[i, j];

                if (matriz[i, j] % 2 == 0)
                {
                    sumaP += matriz[i, j];
                    contP++;
                }
                else
                {
                    sumaI += matriz[i, j];
                    contI++;
                }
            }

        int totalElementos = m * n;
        double promedioGeneral = (double)sumaTotal / totalElementos;

        int yInicio = 6 + m * n;

        yInicio += m + 2;
        EscribirEn(2, yInicio++, $"Suma pares: {sumaP}, Cantidad: {contP}, Promedio: {(contP == 0 ? 0 : (double)sumaP / contP):F2}");
        EscribirEn(2, yInicio++, $"Suma impares: {sumaI}, Cantidad: {contI}, Promedio: {(contI == 0 ? 0 : (double)sumaI / contI):F2}");
        EscribirEn(2, yInicio, $"Promedio general: {promedioGeneral:F2}");
    }


    static void SumaFilasColumnas()
    {
        Console.Clear();
        string Titulo = "== Suma de filas y columnas en matriz 3x3 ==";
        EscribirEn((Console.WindowWidth / 2) - (Titulo.Length / 2), 0, Titulo);
        int[] filas = new int[3];
        int[] columnas = new int[3];
        int centroX = (Console.WindowWidth - (3 * 3 + 4)) / 2;
        int[,] matriz = RellenarMatrizInteractiva("Matriz", 3, 3, centroX, 5);

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                filas[i] += matriz[i, j];
                columnas[j] += matriz[i, j];
            }

        MostrarVector("Vector Filas", filas, 2, 20);
        MostrarVector("Vector Columnas", columnas, 2, 22);
    }

    static void MultiplicacionMatrices()
    {
        Console.Clear();
        string Titulo = "== Multiplicación de matrices ==";
        EscribirEn((Console.WindowWidth / 2) - (Titulo.Length / 2), 0, Titulo);
        int m = SolicitarEntero(2, 2, "Filas de A: ");
        int n = SolicitarEntero(2, 3, "Columnas de A / Filas de B: ");
        int p = SolicitarEntero(2, 4, "Columnas de B: ");

        //int[,] A = new int[m, n];
        int centroX = (Console.WindowWidth - (n * 3 + 4)) / 2;
        int[,] A = RellenarMatrizInteractiva("Matriz A", m, n, centroX, 5);
        //int[,] B = new int[n, p];
        int[,] B = RellenarMatrizInteractiva("Matriz B", n, p, centroX, Console.CursorTop + 1);
        int[,] C = new int[m, p];

        /*for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                A[i, j] = SolicitarEntero(2, 6, $"A[{i},{j}]: ");*/

        /*for (int i = 0; i < n; i++)
            for (int j = 0; j < p; j++)
                B[i, j] = SolicitarEntero(2, 7, $"B[{i},{j}]: ");*/

        for (int i = 0; i < m; i++)
            for (int j = 0; j < p; j++)
                for (int k = 0; k < n; k++)
                    C[i, j] += A[i, k] * B[k, j];

        MostrarMatriz("Matriz Resultado C = A * B", C, centroX, Console.CursorTop + 1);
    }

    static void DesviacionEstandar()
    {
        Console.Clear();
        string Titulo = "== Desviación estándar ==";
        EscribirEn((Console.WindowWidth / 2) - (Titulo.Length / 2), 0, Titulo);
        int n = SolicitarEntero(2, 2, "Cantidad de elementos: ");
        double[] datos = new double[n];
        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            EscribirEn(2, 4, $"Dato[{i + 1}]: ");
            Console.SetCursorPosition(15, 4);
            datos[i] = double.Parse(Console.ReadLine());
            suma += datos[i];
        }

        double media = suma / n;
        double sumaCuadrados = 0;
        foreach (var d in datos)
            sumaCuadrados += Math.Pow(d - media, 2);

        double desviacion = Math.Sqrt(sumaCuadrados / (n - 1));
        EscribirEn(2, 5 + n, $"Desviación estándar: {desviacion:F2}");
    }

    static int SolicitarEntero(int x, int y, string texto)
    {
        int salida;
        bool repeticion = true;
        do {
            for (int xc = 0; xc < Console.WindowWidth; xc++)
            {
                Console.SetCursorPosition(xc, y);
                Console.Write(" ");
            }
            EscribirEn(x, y, texto);
            if(int.TryParse(Console.ReadLine(), out salida))
            {
                for (int xc = 0; xc < Console.WindowWidth; xc++)
                {
                    Console.SetCursorPosition(xc, 1);
                    Console.Write(" ");
                }
                repeticion = false;
            }
            else
            {
                EscribirEn((Console.WindowWidth / 2) - 20, 1, "Error: el valor insertado no es numerico");
            }
        } while (repeticion);
        return salida;
    }
}
