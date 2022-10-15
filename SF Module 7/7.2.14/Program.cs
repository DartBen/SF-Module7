internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6 };
        IndexingClass test = new IndexingClass(a);

    }
}

class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    public int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
}


