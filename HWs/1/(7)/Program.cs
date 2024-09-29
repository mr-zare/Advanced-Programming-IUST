using System;

namespace soal7
{
    class Program
    {
        static double miangin(int[] arr,int t,int n)
        {
            if(t<0)
            {
                return 0;
            }
            else
            {
               return (double)arr[t]/n+ miangin(arr,t-1,n);
            }

        }
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            int n=int.Parse(a);
            int[] array=new int[n];
            string b=Console.ReadLine();
            string[] t=b.Split(' ');
            for (int i = 0; i < n; i++)
            {
                array[i]=int.Parse(t[i]);
            }
           double m=miangin(array,n-1,n);
           m=Math.Round(m,2);
           Console.WriteLine(m);
        }
    }
}
