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

class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;
    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
    {
    }
}

class ElectricCar : Car<ElectricEngine>
{
    //public override void ChangePart<TPart>(TPart newPart)
    //{
    //}
}

class GasCar : Car<GasEngine>
{
    //public override void ChangePart<TPart>(TPart newPart)
    //{
    //}
}