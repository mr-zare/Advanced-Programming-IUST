using System;

namespace soal2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            string[] arr=a.Split(' ');
            string key=Console.ReadLine();
            string meq=Console.ReadLine();
            int m;
            for (int i = 0; i < arr.Length; i++)
            {
                m=string.Compare(arr[i],key);
                if (m==0)
                {
                    arr[i]=meq;
                }
            }
            for (int i =arr.Length-1; i > 0; i--)
            {
                Console.Write(arr[i]+"&");
            }
            Console.Write(arr[0]);
        }
    }
}
