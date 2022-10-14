internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;

    public DerivedClass(string Name, string Description) : base(Name)
    {
        this.Description = Description;
    }

    public DerivedClass(string Name, string Description, int Counter) : this(Name, Description)
    {
        this.Counter = Counter;
    }

}