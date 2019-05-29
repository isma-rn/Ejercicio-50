using System;
using System.Text;
namespace E50_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese un número entero positivo mayor a 0");
                if (Int32.TryParse(Console.ReadLine(), out int numero) && numero >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int i = 1; i <= numero; i++)
                        Console.WriteLine("{0}, {1}", i, ConstruirCadena(i));
                }
                else
                    Console.WriteLine("Error, debe ingresar un número mayor o igual a 1");

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);

            } while (!salir);
        }
        public static string ConstruirCadena(int numero)
        {
            StringBuilder result = new StringBuilder();

            if (numero % 3 == 0)
                result.Append("fizz");
            if (numero % 5 == 0)
                result.Append("buzz");

            return result.ToString();
        }
    }
}
