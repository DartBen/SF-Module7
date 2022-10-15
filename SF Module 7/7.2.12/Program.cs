internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Obj
{
    public int Value;
    public static Obj operator +(Obj A, Obj B)
    {
        return new Obj { Value = A.Value + B.Value;
    }

    public static Obj operator -(Obj A, Obj B)
    {
        return new Obj { Value = A.Value - B.Value;
    }
}