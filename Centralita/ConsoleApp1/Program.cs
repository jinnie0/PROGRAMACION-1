using System;

class Program
{
    static void Main(string[] args)
    {

        Centralita centralita = new Centralita();
        
        Console.WriteLine("REGISTRANDO LLAMADAS EN LA CENTRALITA...");
        
        centralita.RegistrarLlamada(new LlamadaLocal("600111222", "600333444", 10));
        centralita.RegistrarLlamada(new LlamadaLocal("600555666", "600777888", 5));
        
        centralita.RegistrarLlamada(new LlamadaProvincial("910111222", "950333444", 8, 1));
        centralita.RegistrarLlamada(new LlamadaProvincial("912555666", "952777888", 12, 2));
        centralita.RegistrarLlamada(new LlamadaProvincial("914999000", "954111222", 6, 3));
        
        Console.WriteLine("\nINFORME DE LA CENTRALITA:");
        Console.WriteLine($"Total de llamadas: {centralita.GetTotalLlamadas()}");
        Console.WriteLine($"Facturación total: {centralita.GetTotalFacturado()} céntimos");
        
        centralita.MostrarLlamadas();
        
        Console.ReadKey(); 
    }
}