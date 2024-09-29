using System;

namespace soal3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            int n=int.Parse(a);
            int i,f=1;
            for ( i = 2; i < n ; i++)
            {
                if (n%i==0)
                {
                    f=0;
                    break;
                }
            }
            if((n-1)%6!=0 && n!=3)
            {
                f=0;
            }
            if(f==1)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}
