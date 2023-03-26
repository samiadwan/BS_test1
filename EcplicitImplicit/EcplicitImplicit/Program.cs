namespace EcplicitImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string value_1 = "123";
            int value_2 = Convert.ToInt32(value_1);//explicit
            Console.WriteLine(value_2);

            int value_3 = 3;
            string value_4 = Convert.ToString(value_3);
            Console.WriteLine(value_4);

            long value_5 = (long)Convert.ToDouble(value_1);
            Console.WriteLine(value_5);

            long value_6 = 13124242;
            string value_7 = Convert.ToString(value_6);
            Console.WriteLine(value_7);

            double value_8 = Convert.ToDouble(value_1);
            Console.WriteLine(value_8);

            string value_9 = "12.66666";
            float value_10 = (float)Convert.ToDouble(value_9);
            Console.WriteLine(value_10);

            bool value_11 = Convert.ToBoolean(value_1);
            Console.WriteLine(value_11);

            int value_12 = 123;
            long value_13 = value_12;
            Console.WriteLine(value_13);
            long value_14 = 12134243599;
            int value_15 = Convert.ToInt32(value_14);

            char value_16 = 'R';
            int ascii = (int)value_16;
            Console.WriteLine(ascii);



        }
    }
}