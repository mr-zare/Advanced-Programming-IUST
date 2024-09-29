using System;

namespace soal1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            int n=int.Parse(a);
            int i,f;
            for ( i = 2; i <=n ; i++)
            {
                f=0;
                while(n%i==0)
                {
                    n/=i;
                    f=1;
                }
                if (f==1)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
