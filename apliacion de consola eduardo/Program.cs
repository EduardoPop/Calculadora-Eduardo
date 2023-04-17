using System;

namespace apliacion_de_consola_eduardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese la operación que quiere realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Cuadrado");
            Console.WriteLine("4. Raiz Cuadrada");

            string option = Console.ReadLine();
            double result = 0;

            switch (option)
            {
                case "1":
                    Console.WriteLine("Ingrese el primer número:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número:");
                    int num2 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, num2);
                    break;

                case "2":
                    Console.WriteLine("Ingrese el primer número:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número:");
                    num2 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, num2);
                    break;

                case "3":
                    Console.WriteLine("Ingrese el número al que desea calcular el cuadrado:");
                    num1 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, 0);
                    break;

                case "4":
                    Console.WriteLine("Ingrese el número al que desea calcular la raiz cuadrada:");
                    num1 = int.Parse(Console.ReadLine());
                    result = Operation(option, num1, 0);
                    break;

                default:
                    Console.WriteLine("La opción ingresada no es válida.");
                    break;
            }

            printMessage(result);
        }

        static double Operation(string option, int number1, int number2)
        {
            switch (option)
            {
                case "1":
                    return number1 + number2;

                case "2":
                    return number1 - number2;

                case "3":
                    return number1 * number1;

                case "4":
                    return Math.Sqrt(number1);

                default:
                    return 0;
            }
        }

        static void printMessage(double result)
        {
            Console.WriteLine("El resultado es: " + result);
        }
    }
}
