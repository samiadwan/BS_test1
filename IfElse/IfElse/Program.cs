namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            if (a > b)
            {
                Console.WriteLine("a is greater than  b");
            }
            else if (b > a)
            {
                Console.WriteLine("b is greater than  a");
            }
            else { Console.WriteLine("a is equal to b"); }
            
        }
    }
}