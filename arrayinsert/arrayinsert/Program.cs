namespace arrayinsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            for(int i=1;i<=15; i++)
            {
                array[i-1] = i;
            }

            string[] array2 = new string[15];
            int count = 0;
            while(count < array2.Length)
            {
                array2[count++] = "1";
            }

            double[] array3 = new double[15];
            int j = 0;
            foreach(var item  in array3)
            {
                array3[j++] = j * 1.3;
            }

            Console.WriteLine("Printing array1:");
            for(int i = 0; i < array.Length; i++) {
                if (i == 5)
                {
                    continue; 
                }
                if (i > 10)
                {
                    break; 
                }
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\nPrinting array2:");
            count = 0;
            while (count < array2.Length)
            {
                if (count == 5)
                {
                    count++; 
                    continue;
                }
                if (count > 10)
                {
                    break; 
                }
                Console.WriteLine(array2[count]);
                count++;
            }

            Console.WriteLine("\nPrinting array3:");
            j = 0;
            foreach (var item in array3)
            {
                if (j == 5)
                {
                    j++; 
                    continue;
                }
                if (j > 10)
                {
                    break; 
                }
                Console.WriteLine(array3[j]);
                j++;
            }
        }
    }
}