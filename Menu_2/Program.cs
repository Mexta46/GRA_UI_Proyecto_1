using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            MostrarMenu();
            Console.SetCursorPosition(2, 12);
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Clear();

                switch (opcion)
                {
                    case 1: JuegoAhorcado(); break;
                    case 2: ContarSignos(); break;
                    case 3: TransponerMatriz(); break;
                    case 4: MayorMenorMatriz(); break;
                    case 5: ParesImpares(); break;
                    case 6: SumaFilasColumnas(); break;
                    case 7: MultiplicacionMatrices(); break;
                    case 8: DesviacionEstandar(); break;
                }

                if (opcion != 9)
                {
                    EscribirEn(2, 26, "Presione una tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
            else
            {
                EscribirEn(2, 26, "Error: Opción no válida. Presione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 9);
    }

    static void EscribirEn(int x, int y, string texto)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(texto);
    }

    static void MostrarMenu()
    {
        EscribirEn(2, 1, "=== MENÚ DE PROGRAMAS ===");
        EscribirEn(2, 2, "1. Juego del ahorcado");
        EscribirEn(2, 3, "2. Contar positivos, negativos y ceros");
        EscribirEn(2, 4, "3. Transposición de matriz");
        EscribirEn(2, 5, "4. Mayor y menor en matriz");
        EscribirEn(2, 6, "5. Suma y promedio de pares e impares");
        EscribirEn(2, 7, "6. Suma de filas y columnas en matriz 3x3");
        EscribirEn(2, 8, "7. Multiplicación de matrices");
        EscribirEn(2, 9, "8. Calcular desviación estándar");
        EscribirEn(2, 10, "9. Salir");
    }

    static void MostrarMatriz(string nombre, int[,] matriz, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(nombre + ":");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.SetCursorPosition(x, y + i + 1);
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i, j],5}");
            }
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
        string adivinada = new string('_', palabra.Length);
        int errores = 0;
        List<char> letrasIncorrectas = new List<char>();

        while (errores < 6 && adivinada.Contains('_'))
        {
            Console.Clear();
            DibujoAhorcado(errores);
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

    static void ContarSignos()
    {
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");
        int[,] matriz = new int[m, n];
        int pos = 0, neg = 0, ceros = 0;

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = SolicitarEntero(2, 5, $"A[{i},{j}]: ");
                if (matriz[i, j] > 0) pos++;
                else if (matriz[i, j] < 0) neg++;
                else ceros++;
            }

        MostrarMatriz("Matriz A", matriz, 2, 5 + m * n + 1);
        EscribirEn(2, 22, $"Positivos: {pos}");
        EscribirEn(2, 23, $"Negativos: {neg}");
        Console.ForegroundColor = ConsoleColor.Red;
        EscribirEn(2, 24, $"Ceros: {ceros}");
        Console.ResetColor();
    }

    static void TransponerMatriz()
    {
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");
        int[,] matriz = new int[m, n];

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                matriz[i, j] = SolicitarEntero(2, 5, $"A[{i},{j}]: ");

        MostrarMatriz("Matriz A", matriz, 2, 5 + m * n + 1);

        int[,] transpuesta = new int[n, m];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                transpuesta[j, i] = matriz[i, j];

        MostrarMatriz("Matriz A^T", transpuesta, 2, 5 + m * n + 5);
    }

    static void MayorMenorMatriz()
    {
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");
        int[,] matriz = new int[m, n];
        int max = int.MinValue, min = int.MaxValue;
        (int, int) posMax = (0, 0), posMin = (0, 0);

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = SolicitarEntero(2, 5, $"A[{i},{j}]: ");
                if (matriz[i, j] > max) { max = matriz[i, j]; posMax = (i, j); }
                if (matriz[i, j] < min) { min = matriz[i, j]; posMin = (i, j); }
            }

        MostrarMatriz("Matriz A", matriz, 2, 5 + m * n + 1);
        EscribirEn(2, 22, $"Mayor: {max} en ({posMax.Item1},{posMax.Item2})");
        Console.ForegroundColor = ConsoleColor.Green;
        EscribirEn(2, 23, $"Menor: {min} en ({posMin.Item1},{posMin.Item2})");
        Console.ResetColor();
    }

    static void ParesImpares()
    {
        int m = SolicitarEntero(2, 2, "Filas: ");
        int n = SolicitarEntero(2, 3, "Columnas: ");
        int[,] matriz = new int[m, n];
        int sumaP = 0, sumaI = 0, contP = 0, contI = 0, sumaTotal = 0;

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = SolicitarEntero(2, 5 + i * n + j, $"A[{i},{j}]: ");
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
        MostrarMatriz("Matriz A", matriz, 2, yInicio);

        yInicio += m + 2;
        EscribirEn(2, yInicio++, $"Suma pares: {sumaP}, Cantidad: {contP}, Promedio: {(contP == 0 ? 0 : (double)sumaP / contP):F2}");
        EscribirEn(2, yInicio++, $"Suma impares: {sumaI}, Cantidad: {contI}, Promedio: {(contI == 0 ? 0 : (double)sumaI / contI):F2}");
        EscribirEn(2, yInicio, $"Promedio general: {promedioGeneral:F2}");
    }


    static void SumaFilasColumnas()
    {
        int[,] matriz = new int[3, 3];
        int[] filas = new int[3];
        int[] columnas = new int[3];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                matriz[i, j] = SolicitarEntero(2, 2, $"A[{i},{j}]: ");

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                filas[i] += matriz[i, j];
                columnas[j] += matriz[i, j];
            }

        MostrarMatriz("Matriz A", matriz, 2, 15);
        MostrarVector("Vector Filas", filas, 2, 20);
        MostrarVector("Vector Columnas", columnas, 2, 22);
    }

    static void MultiplicacionMatrices()
    {
        int m = SolicitarEntero(2, 2, "Filas de A: ");
        int n = SolicitarEntero(2, 3, "Columnas de A / Filas de B: ");
        int p = SolicitarEntero(2, 4, "Columnas de B: ");

        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p];

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                A[i, j] = SolicitarEntero(2, 6, $"A[{i},{j}]: ");

        for (int i = 0; i < n; i++)
            for (int j = 0; j < p; j++)
                B[i, j] = SolicitarEntero(2, 7, $"B[{i},{j}]: ");

        for (int i = 0; i < m; i++)
            for (int j = 0; j < p; j++)
                for (int k = 0; k < n; k++)
                    C[i, j] += A[i, k] * B[k, j];

        MostrarMatriz("Matriz Resultado C = A * B", C, 2, 6 + m * n + n * p + 2);
    }

    static void DesviacionEstandar()
    {
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
        for (int xc = 0; xc < Console.WindowWidth; xc++)
        {
            Console.SetCursorPosition(xc, y);
            Console.Write(" ");
        }
        EscribirEn(x, y, texto);
        return int.Parse(Console.ReadLine());
    }
}
