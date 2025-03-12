using System;
public class Pinguino : Ave
{
    public Pinguino(string nombre, string tamaño, string habitat) 
        : base(nombre, tamaño, habitat)
    {
    }

    public override void Volar()
    {
        Console.WriteLine($"El pingüino {Nombre} de tamaño {Tamaño} no puede volar a pesar de ser un ave. Habita en {Habitat}.");
    }
}