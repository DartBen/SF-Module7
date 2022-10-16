internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class ElectricEngine { }
class GasEngine { }
class Battery { }
class Differential { }
class Whee { }

class Car<T>
{
    public T Engine;
    public virtual void ChangePart<T2>(T2 newPart)
    {
    }

}


