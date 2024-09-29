using System;

namespace soal6
{
    
    class Program
    {
        static void Square(ref int m)
        {
            double a=Math.Pow(m,2);
            m=(int)a;
        }
        static void Sum(out int s,int[] array)
        {
            s=0;
            for (int i = 0; i < 10; i++)
            {
                s+=array[i];
            }
            Console.Write(s);
        }
        static void Main(string[] args)
        {
            int jam;
            int[] a=new int[10];
            for (int i = 0; i < 10; i++)
            {
                Random shansi=new Random();
                a[i]=shansi.Next(-600,600);
                Console.Write(a[i]+" ");
                Square(ref a[i]);
            }
            Sum(out jam,a);
            
        }
    }
}
