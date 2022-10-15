internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }
}

class DerivedClass : BaseClass
{
    public override int Counter
    {
        get { return Counter; }
        set
        {
            if (value < 0)
            { Console.WriteLine("Значение меньше 0"); }
            else { Counter = value; }
        }
    }
}