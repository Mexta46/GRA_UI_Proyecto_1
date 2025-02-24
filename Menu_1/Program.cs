using Menu_1;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Menu1 m1=new Menu1();
        Menu2 m2 = new Menu2();
        bool s=true;
        Console.ForegroundColor = ConsoleColor.Green;
        do {
            lineas();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth / 2) - 9, 1);
            Console.WriteLine("Seleccion de menus");
            lineas();
            Console.SetCursorPosition((Console.WindowWidth / 2) - 11, Console.CursorTop + 1);
            Console.WriteLine("Selecciona una opcion:");
            Console.SetCursorPosition(10, Console.CursorTop);
            Console.WriteLine("1.Menu: programas de introduccion");
            Console.SetCursorPosition(10, Console.CursorTop);
            Console.WriteLine("2.Menu: programas de localizacion");
            Console.SetCursorPosition(10, Console.CursorTop);
            Console.WriteLine("3.Salir");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 20, Console.WindowHeight - 2);
            Console.WriteLine("Intserte el numero de la opcion elegida:");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 20, Console.WindowHeight - 2);
            int salida = 0;
            string opc = Console.ReadLine();
            if (int.TryParse(opc, out salida))
            {
                switch (salida)
                {
                    case 1:
                        Console.Clear();
                        m1.men();
                        break;
                    case 2:
                        Console.Clear();
                        m2.men();
                        break;
                    case 3: 
                        Console.Clear();
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
        } while(s);
    }

    public static void lineas()
    {
        for (int i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("=");
        }
    }
    
}