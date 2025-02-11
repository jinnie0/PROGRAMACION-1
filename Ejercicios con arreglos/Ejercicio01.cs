// Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Encontrar el mayor número y su posición
        int mayorNumero = numeros[0];
        int posicionMayor = 0;

        for (int i = 1; i < 10; i++)
        {
            if (numeros[i] > mayorNumero)
            {
                mayorNumero = numeros[i];
                posicionMayor = i;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"El mayor número es {mayorNumero} y está en la posición {posicionMayor} del arreglo.");
    }
}
