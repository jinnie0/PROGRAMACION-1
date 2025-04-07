using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a Chimi MiBarriga del Sr. Billy Navaja");
        Console.WriteLine("==============================================");

        // Ejemplo de Hamburguesa Clásica
        Console.WriteLine("\n1. HAMBURGUESA CLÁSICA");
        Hamburguesa hamburguesaClasica = new Hamburguesa("Normal", "Res", 5.00);
        hamburguesaClasica.AgregarIngredienteAdicional("Lechuga", 0.50);
        hamburguesaClasica.AgregarIngredienteAdicional("Tomate", 0.75);
        hamburguesaClasica.AgregarIngredienteAdicional("Bacon", 1.50);
        hamburguesaClasica.AgregarIngredienteAdicional("Pepinillo", 0.25);
        // Intentar agregar un quinto ingrediente (no debería permitirse)
        hamburguesaClasica.AgregarIngredienteAdicional("Cebolla", 0.50);
        hamburguesaClasica.MostrarOrden();

        // Ejemplo de Hamburguesa Saludable
        Console.WriteLine("\n\n2. HAMBURGUESA SALUDABLE");
        HamburguesaSaludable hamburguesaSaludable = new HamburguesaSaludable("Pollo", 6.50);
        hamburguesaSaludable.AgregarIngredienteAdicional("Lechuga", 0.50);
        hamburguesaSaludable.AgregarIngredienteAdicional("Tomate", 0.75);
        hamburguesaSaludable.AgregarIngredienteAdicional("Zanahoria", 0.50);
        hamburguesaSaludable.AgregarIngredienteAdicional("Cebolla", 0.25);
        // Agregar ingredientes saludables adicionales
        hamburguesaSaludable.AgregarIngredienteSaludableAdicional("Brotes", 0.75);
        hamburguesaSaludable.AgregarIngredienteSaludableAdicional("Aguacate", 1.50);
        // Intentar agregar un séptimo ingrediente (no debería permitirse)
        hamburguesaSaludable.AgregarIngredienteSaludableAdicional("Espinaca", 0.75);
        hamburguesaSaludable.MostrarOrden();

        // Ejemplo de Hamburguesa Premium
        Console.WriteLine("\n\n3. HAMBURGUESA PREMIUM");
        HamburguesaPremium hamburguesaPremium = new HamburguesaPremium("Brioche", "Wagyu", 12.00, "Refresco Grande", 2.50, "Papas Fritas Grandes", 3.00);
        // Intentar agregar ingredientes adicionales (no debería permitirse)
        hamburguesaPremium.AgregarIngredienteAdicional("Queso", 1.00);
        hamburguesaPremium.MostrarOrden();

        Console.WriteLine("\n\nGracias por usar el sistema de Chimi MiBarriga. ¡Vuelva pronto!");
        Console.ReadLine();
    }
}