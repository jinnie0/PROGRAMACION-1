using System;
using System.Collections.Generic;

public class HamburguesaSaludable : Hamburguesa
{
    private Dictionary<string, double> ingredientesSaludablesAdicionales;
    private const int INGREDIENTES_SALUDABLES_EXTRA = 2;

    public HamburguesaSaludable(string carne, double precio) : base("Integral", carne, precio)
    {
        this.ingredientesSaludablesAdicionales = new Dictionary<string, double>();
    }

    public void AgregarIngredienteSaludableAdicional(string nombre, double precio)
    {
        if (ObtenerIngredientesAdicionales().Count + ingredientesSaludablesAdicionales.Count >= ObtenerMaxIngredientesAdicionales() + INGREDIENTES_SALUDABLES_EXTRA)
        {
            Console.WriteLine("No se puede agregar más ingredientes saludables. Máximo alcanzado.");
            return;
        }

        if (ingredientesSaludablesAdicionales.ContainsKey(nombre) || ObtenerIngredientesAdicionales().ContainsKey(nombre))
        {
            Console.WriteLine($"El ingrediente {nombre} ya está agregado.");
            return;
        }

        ingredientesSaludablesAdicionales.Add(nombre, precio);
        Console.WriteLine($"Agregado ingrediente saludable {nombre} por ${precio}");
    }

    public override void MostrarOrden()
    {
        base.MostrarOrden();

        double precioIngredientesSaludables = 0;

        if (ingredientesSaludablesAdicionales.Count > 0)
        {
            Console.WriteLine("\nIngredientes Saludables Adicionales:");
            foreach (var item in ingredientesSaludablesAdicionales)
            {
                Console.WriteLine($"- {item.Key}: ${item.Value}");
                precioIngredientesSaludables += item.Value;
            }

            double granTotal = ObtenerPrecioBase();
            foreach (var item in ObtenerIngredientesAdicionales())
            {
                granTotal += item.Value;
            }
            granTotal += precioIngredientesSaludables;

            Console.WriteLine($"Total Actualizado con Ingredientes Saludables: ${granTotal}");
        }
    }
}