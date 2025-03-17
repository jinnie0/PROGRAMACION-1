using System;
using System.Collections.Generic;

public class Centralita
{
    private int cont;
    private double acum; 
    private List<Llamada> llamadas; 

    public Centralita()
    {
        this.cont = 0;
        this.acum = 0.0;
        this.llamadas = new List<Llamada>();
    }
    
    public int GetTotalLlamadas()
    {
        return cont;
    }
    
    public double GetTotalFacturado()
    {
        return acum;
    }
    
    public void RegistrarLlamada(Llamada llamada)
    {
        llamadas.Add(llamada);
        cont++;
        acum += llamada.CalcularPrecio();
        Console.WriteLine($"Registrada: {llamada}");
    }
    
    public void MostrarLlamadas()
    {
        Console.WriteLine("\n--- LISTADO DE LLAMADAS ---");
        foreach (Llamada llamada in llamadas)
        {
            Console.WriteLine(llamada);
        }
        Console.WriteLine($"Total llamadas: {cont}");
        Console.WriteLine($"Facturación total: {acum} céntimos");
    }
}