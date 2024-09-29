using System;

namespace soal2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            int n=int.Parse(a);
            int i,j,m=1;
            for ( i = 0; i < n; i++,m++)
            {
                for ( j = 0; j < n-m ; j++)
                {
                    Console.Write(" ");
                }
                for ( j = 0; j < m; j++)
                {
                    Console.Write("* ");
                }
                for (j = 0; j < n-m ; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            m-=2;
            for (i = 0; i < n ; i++, m--)
            {
                for (j = 0; j < n-m ; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < m; j++)
                {
                    Console.Write("* ");
                }
                for (j = 0; j < n-m ; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
