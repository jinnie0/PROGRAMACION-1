public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    // Constructor privado para evitar la creación de instancias desde fuera
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }

    public void ShowMessage()
    {
        Console.WriteLine("¡Soy la única instancia de Singleton!");
    }
}

Singleton s1 = Singleton.Instance;
Singleton s2 = Singleton.Instance;

s1.ShowMessage();

// Verificar que ambas instancias son la misma
Console.WriteLine(ReferenceEquals(s1, s2));  // True
