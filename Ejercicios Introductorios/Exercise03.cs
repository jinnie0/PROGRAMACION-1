// Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && Math.Abs(number) >= 10 && Math.Abs(number) <= 99)
        {
            int absNumber = Math.Abs(number);
            int unidad = absNumber % 10;    // Último dígito
            int decena = absNumber / 10;    // Primer dígito

            bool unidadEsPrimo = EsPrimo(unidad);
            bool decenaEsPrimo = EsPrimo(decena);

            Console.WriteLine($"Los dígitos del número {number} son:");
            Console.WriteLine($"- {decena}: {(decenaEsPrimo ? "Primo" : "No es primo")}");
            Console.WriteLine($"- {unidad}: {(unidadEsPrimo ? "Primo" : "No es primo")}");
            
            if (unidadEsPrimo && decenaEsPrimo)
            {
                Console.WriteLine("Ambos dígitos son primos.");
            }
            else
            {
                Console.WriteLine("No ambos dígitos son primos.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido de dos dígitos.");
        }
    }

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
