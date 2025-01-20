// Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 10 && number <= 99)
        {
            int unidad = number % 10;      // Último dígito
            int decena = number / 10;      // Primer dígito

            int suma = unidad + decena;

            // Esto muestra el resultado
            Console.WriteLine($"La suma de los dígitos es: {suma}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido de dos dígitos.");
        }
    }
}
