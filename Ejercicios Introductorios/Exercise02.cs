// Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");

        string input = Console.ReadLine();

        // Esto valida que el número sea entero y de dos dígitos 
        if (int.TryParse(input, out int number) && Math.Abs(number) >= 10 && Math.Abs(number) <= 99)
        {
            // Negativo
            bool esNegativo = number < 0;

            // Si es primo, y sólo con los positivos 
            bool esPrimo = EsPrimo(Math.Abs(number));
            
            Console.WriteLine($"El número {number} es:");
            Console.WriteLine(esNegativo ? "- Negativo" : "- Positivo");
            Console.WriteLine(esPrimo ? "- Primo" : "- No es primo");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido de dos dígitos.");
        }
    }

    // Método para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false; // Los números menores o iguales a 1 no son primos
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}
