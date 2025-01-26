using System.Drawing;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        bool salida = true;
        Console.ForegroundColor = ConsoleColor.Green;
        do {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Menu de selección" +
                "\n1)cuadros con asteriscos" +
                "\n2)Espiral de asteriscos" +
                "\nEscribe el numero de la opcion del menu");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    cuadros();
                    Console.WriteLine("\n----------------------------------------------");
                    salida = false;
                    break;
                case 2:
                    Console.Clear();
                    espiral();
                    Console.WriteLine("\n----------------------------------------------");
                    salida = false;
                    break;
                default:
                    Console.WriteLine("Error:Opcion no valida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    salida = true;
                    break;
            }
        } while (salida);
    }

    public static ConsoleColor ramdomcol()
    {
        //return (ConsoleColor)new Random().Next(Enum.GetValues(typeof(ConsoleColor)).Length);
        ConsoleColor c= ConsoleColor.White;
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
                //Thread.Sleep(100);
            }
            for (int fila = 0; fila < inferior; fila++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                Console.Write("*");
                //Thread.Sleep(100);
            }
            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop + 1);
            for (int columna = 0; columna < superior; columna++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                Console.Write("*");
                //Thread.Sleep(100);
            }
            for (int fila = 0; fila < inferior; fila++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                Console.Write("*");
                //Thread.Sleep(100);
            }
        }
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nListo!!! presiona una tecla para continuar");
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
        Console.SetCursorPosition(centrox+horizontal, centroy);
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
        while (horizontal < Console.WindowWidth-2 && vertical < Console.WindowHeight-2);
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nListo!!! presiona una tecla para continuar");
    }
}