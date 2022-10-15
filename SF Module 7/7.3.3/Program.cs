internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Processor : ComputerPart
{
    public override void Work() { }
}
class MotherBoard : ComputerPart
{
    public override void Work() { }
}
class GraphicCard : ComputerPart
{
    public override void Work() { }
}

abstract class ComputerPart
{
    public abstract void Work();

}
