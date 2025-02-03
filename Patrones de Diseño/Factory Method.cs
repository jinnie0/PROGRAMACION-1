// Interfaz del producto
public interface IAnimal
{
    void Speak();
}

// Implementaciones concretas del producto
public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Guau Guau");
    }
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Miau");
    }
}

// Creador (Factory)
public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal();
}

// Factories concretas
public class DogFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}

public class CatFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}

AnimalFactory dogFactory = new DogFactory();
IAnimal dog = dogFactory.CreateAnimal();
dog.Speak();  // Guau Guau

AnimalFactory catFactory = new CatFactory();
IAnimal cat = catFactory.CreateAnimal();
cat.Speak();  // Miau
