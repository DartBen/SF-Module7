internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class ElectricEngine : Engine { }
class GasEngine : Engine { }
class Battery : CarPart { }
class Differential : CarPart { }
class Whee : CarPart { }

abstract class Engine { }
abstract class CarPart { }

class Car<T> where T : Engine
{
    public T Engine;
    public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
    {

    }

}
