// Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Introduce un número entero de tres dígitos: ");
            int numero = int.Parse(Console.ReadLine());

            // Validar que el número tenga exactamente tres dígitos
            if (EsTresDigitos(numero))
            {
                // Obtener los dígitos
                int centena = Math.Abs(numero) / 100;        // Dígito en la posición de las centenas
                int decena = (Math.Abs(numero) / 10) % 10;  // Dígito en la posición de las decenas
                int unidad = Math.Abs(numero) % 10;         // Dígito en la posición de las unidades

                // Determinar la posición del mayor dígito
                if (centena >= decena && centena >= unidad)
                {
                    Console.WriteLine($"El dígito mayor es {centena} y está en la posición de las centenas.");
                }
                else if (decena >= centena && decena >= unidad)
                {
                    Console.WriteLine($"El dígito mayor es {decena} y está en la posición de las decenas.");
                }
                else
                {
                    Console.WriteLine($"El dígito mayor es {unidad} y está en la posición de las unidades.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero de tres dígitos.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, introduce un valor numérico válido.");
        }
    }

    // Método para validar si un número tiene tres dígitos
    static bool EsTresDigitos(int num)
    {
        return num >= 100 && num <= 999 || num <= -100 && num >= -999;
    }
}
