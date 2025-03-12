using System;

class Program
{
    static void Main(string[] args)
    {
        Pinguino pinguino = new Pinguino("Emperador", "Grande", "Antártida");
        Aguila aguila = new Aguila("Calva", "Mediana", "América del Norte");
        
        Ave[] aves = { pinguino, aguila };
        
        Console.WriteLine("Comportamiento de vuelo de las aves:");
        foreach (Ave ave in aves)
        {
            Console.WriteLine();
        }
        
        Console.ReadKey();
    }
}