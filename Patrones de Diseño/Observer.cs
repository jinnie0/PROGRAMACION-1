using System;
using System.Collections.Generic;

// Interfaz del observador
public interface IObserver
{
    void Update(string message);
}

// Interfaz del sujeto (observable)
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
}

// Sujeto concreto
public class NewsAgency : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}

// Observadores concretos
public class NewsSubscriber : IObserver
{
    private string _name;

    public NewsSubscriber(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} recibió la noticia: {message}");
    }
}

NewsAgency agency = new NewsAgency();

IObserver subscriber1 = new NewsSubscriber("José");
IObserver subscriber2 = new NewsSubscriber("Ana");

agency.Attach(subscriber1);
agency.Attach(subscriber2);

agency.Notify("¡Última hora: Se anuncia una nueva actualización en Genshin Impact!");

// Desvincular un observador
agency.Detach(subscriber1);
agency.Notify("¡Otra noticia: Evento especial en camino!");
