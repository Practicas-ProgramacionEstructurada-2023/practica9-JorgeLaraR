using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Multiplicar números");
                Console.WriteLine("2. Restar números");
                Console.WriteLine("3. Concatenar cadenas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("\nIngrese su opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("\nIngrese dos números enteros para multiplicar: ");

                            Console.Write("\nNúmero 1: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nNúmero 2: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nResultado de la multiplicación (entero): " + Multiplicar(num1, num2));

                            Console.Write("\nIngrese dos números decimales para multiplicar:");

                            Console.Write("\nNúmero 1: ");
                            double num1Double = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nNúmero 2: ");
                            double num2Double = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nResultado de la multiplicación (decimal): " + Multiplicar(num1Double, num2Double));
                            break;
                        case 2:
                            Console.Write("\nEl resultado es: " + RestarNumeros(20, 5, 3, 2));
                            break;
                        case 3:
                            Console.Write("\nIngrese su primer nombre: ");
                            string? cadena1 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese su primer apellido: ");
                            string? cadena2 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese el separador: ");
                            string? separador1 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenacion = ConcatenarCadenas(cadena1, cadena2, separador1);



                            Console.Write("\nIngrese su segundo nombre: ");
                            string? cadena3 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese su segundo apellido: ");
                            string? cadena4 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese su tercer apellido: ");
                            string? cadena5 = Convert.ToString(Console.ReadLine());

                            Console.Write("Ingrese el separador: ");
                            string? separador2 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenacion2 = ConcatenarCadenas(cadena3, cadena4, cadena5, separador2);
                            Console.WriteLine($"\nResultado de la concatenación: {resultadoConcatenacion2}");
                            break;
                        case 4:
                            Console.Write("\nSaliendo del programa....");
                            break;
                        default:
                            Console.Write("\nOpción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.Write("\nOpción no válida. Intente de nuevo.");
                }
            }while (opcion != 4);

        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static int RestarNumeros(params int[] numeros)
        {
            int resultado = numeros[0]; //Inicializamos el resultado con el primer número

            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i]; //Restamos los números uno por uno
            }

            return resultado;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? separador1)
        {
            return cadena1 + separador1 + cadena2;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? cadena3, string? separador1)
        {
            return cadena1 + separador1 + cadena2 + separador1 + cadena3;
        }
    }
}