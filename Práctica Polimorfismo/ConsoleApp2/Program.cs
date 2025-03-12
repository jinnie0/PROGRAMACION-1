using System;

namespace ConsoleApp2
{
    public abstract class Ave(string nombre, string tamaño, string habitat)
    {
        public string Nombre { get; set; } = nombre;
        public string Tamaño { get; set; } = tamaño;
        public string Habitat { get; set; } = habitat;

        public abstract void Volar();
    }

    public class Aguila(string nombre, string tamaño, string habitat) : Ave(nombre, tamaño, habitat)
    {
        public override void Volar()
        {
            Console.WriteLine($"El {Nombre} de tamaño {Tamaño} vuela los cielos de {Habitat}.");
        }
    }

    public class Pinguino(string nombre, string tamaño, string habitat) : Ave(nombre, tamaño, habitat)
    {
        public override void Volar()
        {
            Console.WriteLine($"El {Nombre} de tamaño {Tamaño} nada durísimo. Habita en {Habitat}.");
        }
    }

    class Programita
    {
        private static void Main(string[] args)
        {
            Aguila aguilaReal = new("Águila", "grande", "Montañas");
            Pinguino pinguinoEmperador = new("Pingüino", "Mediano", "El Polo Norte");

            aguilaReal.Volar();
            pinguinoEmperador.Volar();
        }
    }
}
