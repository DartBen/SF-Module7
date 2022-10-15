using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class A
{
    public virtual void Display()
    {
        WriteLine("A");
    }
}
class B : A
{
    public new void Display()
    {
        WriteLine("B");
    }
}
class C : A
{
    public override void Display()
    {
        WriteLine("C");
    }
}
class D : B
{
    public new void Display()
    {
        WriteLine("D");
    }
}
class E : C
{
    public new void Display()
    {
        WriteLine("E");
    }
}
