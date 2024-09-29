using System;

namespace soal4
{
    class Program
    {
        static void Main(string[] args)
        {
            string m=Console.ReadLine();
            int n=int.Parse(m);
            string a=Console.ReadLine();
            char[] w=a.ToCharArray();
            string b=Console.ReadLine();
            string[] c=b.Split(" ");
            int s=int.Parse(c[0]),t=int.Parse(c[1]);
            int javab=0;
            if(s>t)
            {
                int q=s;
                s=t;
                t=q;
            }
            int i=s;
            while (i<t)
            {
                double k=0;
                while (w[i]!='P')
                {
                    i++;
                    k++;
                }
                while (k>0)
                {
                    int u=0;
                    while (Math.Pow(2,u)<=k)
                    {
                        u++;
                    }
                    javab++;
                    k=k-(Math.Pow(2,u-1));
                }
                i++;
            }
            Console.Write(javab);
        }
    }
}
