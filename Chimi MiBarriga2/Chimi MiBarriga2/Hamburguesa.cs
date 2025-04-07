using System;
using System.Collections.Generic;

public class Hamburguesa
{
    private string tipoPan;
    private string carne;
    private double precio;
    private Dictionary<string, double> ingredientesAdicionales;
    private const int MAX_INGREDIENTES_ADICIONALES = 4;

    public Hamburguesa(string tipoPan, string carne, double precio)
    {
        this.tipoPan = tipoPan;
        this.carne = carne;
        this.precio = precio;
        this.ingredientesAdicionales = new Dictionary<string, double>();
    }

    public void AgregarIngredienteAdicional(string nombre, double precio)
    {
        if (ingredientesAdicionales.Count >= MAX_INGREDIENTES_ADICIONALES)
        {
            Console.WriteLine("No se puede agregar más ingredientes. Máximo alcanzado.");
            return;
        }

        if (ingredientesAdicionales.ContainsKey(nombre))
        {
            Console.WriteLine($"El ingrediente {nombre} ya está agregado.");
            return;
        }

        ingredientesAdicionales.Add(nombre, precio);
        Console.WriteLine($"Agregado {nombre} por ${precio}");
    }

    public virtual void MostrarOrden()
    {
        double precioTotal = precio;

        Console.WriteLine("\n=== DETALLES DE LA ORDEN ===");
        Console.WriteLine($"Hamburguesa Base: Pan {tipoPan} con {carne} - ${precio}");

        if (ingredientesAdicionales.Count > 0)
        {
            Console.WriteLine("Ingredientes Adicionales:");
            foreach (var item in ingredientesAdicionales)
            {
                Console.WriteLine($"- {item.Key}: ${item.Value}");
                precioTotal += item.Value;
            }
        }

        Console.WriteLine($"Precio Total: ${precioTotal}");
    }

    protected Dictionary<string, double> ObtenerIngredientesAdicionales()
    {
        return ingredientesAdicionales;
    }

    protected double ObtenerPrecioBase()
    {
        return precio;
    }

    protected int ObtenerMaxIngredientesAdicionales()
    {
        return MAX_INGREDIENTES_ADICIONALES;
    }
}