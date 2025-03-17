using System;
public class LlamadaLocal : Llamada
{
    private double precio = 15.0; 
    
    public LlamadaLocal(string numOrigen, string numDestino, double duracion)
        : base(numOrigen, numDestino, duracion)
    {
    }
    
    public override double CalcularPrecio()
    {
        return precio * duracion;
    }
    
    public override string ToString()
    {
        return $"Llamada Local: {base.ToString()}";
    }
}