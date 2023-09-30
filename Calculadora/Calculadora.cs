using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Prototipo de Calculadora Básica");

        while (true)
        {
            Console.WriteLine("Por favor, ingrese la operación (por ejemplo, 2 + 3) o 'salir' para terminar:");
            string input = Console.ReadLine();

            if (input.ToLower() == "salir")
            {
                break;
            }

            string[] partes = input.Split(' ');

            if (partes.Length != 3)
            {
                Console.WriteLine("Formato incorrecto. Debe ser: número operador número");
                
            }

            double num1, num2;

            if (!double.TryParse(partes[0], out num1) || !double.TryParse(partes[2], out num2))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese números válidos.");
                continue;
            }

            double resultado = 0;

            switch (partes[1])
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Operador no válido. Por favor, use +, -, *, o /.");
                    continue;
            }

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}

