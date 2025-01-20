//Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

using System;

class Program
{
    static void Main()
    {
        // Leer dos números enteros de dos dígitos
        try
        {
            Console.Write("Introduce el primer número de dos dígitos: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número de dos dígitos: ");
            int num2 = int.Parse(Console.ReadLine());

            // Validar si ambos números son de dos dígitos
            if (EsDosDigitos(num1) && EsDosDigitos(num2))
            {
                int suma = num1 + num2;

                // Determinar si la suma es par
                if (suma % 2 == 0)
                {
                    Console.WriteLine($"La suma de {num1} y {num2} es {suma}, y es un número par.");
                }
                else
                {
                    Console.WriteLine($"La suma de {num1} y {num2} es {suma}, y es un número impar.");
                }
            }
            else
            {
                Console.WriteLine("Ambos números deben ser de dos dígitos.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, introduce números válidos.");
        }
    }

    // Método para verificar si un número es de dos dígitos
    static bool EsDosDigitos(int num)
    {
        return num >= 10 && num <= 99 || num <= -10 && num >= -99;
    }
}
