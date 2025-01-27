using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("Ingresa un año: ");
        int año = Convert.ToInt32(Console.ReadLine());

        if (bisiesto(año))
        {
            Console.WriteLine($"El año {año} es bisiesto");
        }
        else
        {
            Console.WriteLine($"El año {año} no es bisiesto");
        }
    }

    static bool bisiesto(int año)
    {
        if (año % 400 == 0)
        {
            return true;
        }
        else if (año % 100 == 0)
        {
            return false;
        }
        else if (año % 4 == 0)
        {
            return true;
        }
        return false;
    }
}
