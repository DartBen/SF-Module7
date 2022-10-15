using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        BaseClass b=new BaseClass();
        DerivedClass d1=new DerivedClass();
        DerivedClassSecond d2 = new DerivedClassSecond();

        b.Display();
        d1.Display();
        d2.Display();


    }
}

class BaseClass
{
    public virtual void Display() { WriteLine("Метод класса BaseClass"); }
}

class DerivedClass : BaseClass
{
    public override void Display() { WriteLine("Метод класса DerivedClass"); }
}


class DerivedClassSecond : DerivedClass
{
    public override void Display()
    {
        WriteLine("Метод класса DerivedClassSecond");
    }
}

