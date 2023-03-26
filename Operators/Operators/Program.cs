namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            Console.WriteLine(a+b);

             a = 10;
             b = 3;
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);
            Console.WriteLine(a & b);
            Console.WriteLine(a ^ b);
        }
    }
}