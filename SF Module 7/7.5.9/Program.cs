internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


static class intExtension
{
    public static int GetNegative(this int value)
    {
        int result;

        if (value <= 0) { result = value; }
        else { result = value * (-1); }

        return result;
    }

    public static int GetPositive(this int value)
    {
        int result;

        if (value >= 0) { result = value; }
        else { result = value * (-1); }

        return result;
    }



    
}