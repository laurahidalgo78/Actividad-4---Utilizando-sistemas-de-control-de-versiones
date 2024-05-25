using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Básica en C#");
                Console.WriteLine("------------------------");

                // Leer el primer número
                Console.Write("Introduce el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Leer la operación
                Console.Write("Introduce la operación (+, -, *, /): ");
                char operacion = Console.ReadKey().KeyChar;
                Console.WriteLine();

                // Leer el segundo número
                Console.Write("Introduce el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Realizar el cálculo
                double resultado = 0;
                bool operacionValida = true;

                switch (operacion)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: División por cero no permitida.");
                            operacionValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Operación no válida.");
                        operacionValida = false;
                        break;
                }

                // Mostrar el resultado
                if (operacionValida)
                {
                    Console.WriteLine($"Resultado: {num1} {operacion} {num2} = {resultado}");
                }

                // Preguntar al usuario si desea continuar
                Console.WriteLine("¿Deseas realizar otra operación? (s/n)");
                char continuar = Console.ReadKey().KeyChar;
                if (continuar != 's' && continuar != 'S')
                {
                    break;
                }
            }
        }
    }
}
