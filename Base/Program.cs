internal partial class Program
{
    private static void Main(string[] args)
    {
        int a = 5;
        int b = 7;
        int c = 9;
        int d = 18;
        int e = 6;
        int max = a;

        if (a > max) max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;
        if (e > max) max = e;

        Console.Write("max = ");
        Console.WriteLine(max);
    }
}