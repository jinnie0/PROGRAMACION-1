using System;

public class HamburguesaPremium : Hamburguesa
{
    private string bebida;
    private string papitas;
    private double precioBebida;
    private double precioPapitas;

    public HamburguesaPremium(string tipoPan, string carne, double precio, string bebida, double precioBebida, string papitas, double precioPapitas)
        : base(tipoPan, carne, precio)
    {
        this.bebida = bebida;
        this.papitas = papitas;
        this.precioBebida = precioBebida;
        this.precioPapitas = precioPapitas;
    }

    public override void MostrarOrden()
    {
        base.MostrarOrden();

        double precioComplementos = precioBebida + precioPapitas;
        double precioTotal = ObtenerPrecioBase() + precioComplementos;

        // Mostrar complementos premium incluidos
        Console.WriteLine("\nComplementos Premium Incluidos:");
        Console.WriteLine($"- {bebida}: ${precioBebida}");
        Console.WriteLine($"- {papitas}: ${precioPapitas}");

        // No se permiten más adiciones a la hamburguesa premium
        Console.WriteLine($"\nTotal con Complementos Premium: ${precioTotal}");
    }

    // Sobrescribir el método AgregarIngredienteAdicional para impedir adiciones
    public new void AgregarIngredienteAdicional(string nombre, double precio)
    {
        Console.WriteLine("No se permiten ingredientes adicionales en la Hamburguesa Premium.");
    }
}