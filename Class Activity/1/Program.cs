using System;
namespace csharp
{
    class Program
    {
        static void MaxNum(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
        static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int j = 0; j < n; j++)
            {
                array[j] = int.Parse(Console.ReadLine());
            }
            if (n > 1)
            {
                MaxNum(array);
            }
            else
            {
                Console.WriteLine("doostam adad bish az 1bayad midadi");
            }
        }
    }
}
