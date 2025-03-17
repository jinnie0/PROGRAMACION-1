using System;

//hay algo aquí que me está dando error en el programa entero

public class LlamadaProvincial : Llamada
{
    private double precio1 = 20.0; // franja 1
    private double precio2 = 25.0; // franja 2
    private double precio3 = 30.0; // franja 3
    private int franja;
    
    public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franja)
        : base(numOrigen, numDestino, duracion)
    {
        this.franja = franja;
    }
    public override double CalcularPrecio()
    {
        switch (franja)
        {
            case 1:
                return precio1 * duracion;
            case 2:
                return precio2 * duracion;
            case 3:
                return precio3 * duracion;
            default:
                return 0; 
        }
    }
    
    public override string ToString()
    {
        return $"Llamada Provincial (franja {franja}): {base.ToString()}";
    }
}