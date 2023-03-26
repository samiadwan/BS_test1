namespace AndOr_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 5;
            if(a%2 == 0 && a!=0) 
            {
                Console.WriteLine("EVEN");
            }
            if(b%2 != 0 || b<a) { Console.WriteLine("ODD");  }
        }
            
    }
}