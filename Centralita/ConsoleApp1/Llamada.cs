using System;
public abstract class Llamada

{
    // Atributos
    protected string numOrigen;
    protected string numDestino;
    protected double duracion;
    
    // Constructor
    public Llamada(string numOrigen, string numDestino, double duracion)
    {
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = duracion;
    }
    
    // Getters
    public string GetNumOrigen()
    {
        return numOrigen;
    }
    
    public string GetNumDestino()
    {
        return numDestino;
    }
    
    public double GetDuracion()
    {
        return duracion;
    }
    
    public abstract double CalcularPrecio();
    
    public override string ToString()
    {
        return $"Llamada de {numOrigen} a {numDestino}, duración: {duracion} segundos, coste: {CalcularPrecio()} céntimos";
    }
}