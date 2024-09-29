using System;

namespace soal5
{
    class Program
    {
        static void Main(string[] args)
        {
            String m=Console.ReadLine();
            string[] t=m.Split(' ');
            int k=int.Parse(t[0]),a=int.Parse(t[1]),b=int.Parse(t[2]),
            c,javab=0;
            if(a<0 && b<0)
            {
                a*=-1;
                b*=-1;  
            }
            if (a>b)
            {
                c=a;
                a=b;
                b=c;
            }
            if(k>b && (a-(b-k)>(b-a)))
            {
                javab=b-a;
                b=a;
            }
            
            while (b!=a)
            {
                
                int i;
                if (k<0)
                {
                    k=k*-1;
                }
                if (b<0)
                {
                    i=(-1*b)%k;
                }
                else
                    i=b%k;
                if ((k-i)>=i)
                {
                    b=b-i;
                    javab+=i;
                }
                else
                {
                    b=b+(k-i);
                    javab=javab+(k-i);
                }
                int j=0;
                while ((b-j*k)>=a)
                {
                    j++;
                }
                j--;
                b=b-(j*k);
                javab=javab+j;
                
                if (a==b)
                {
                    break;
                }
                if ((b-a)<=(a-(b-k)))
                {
                    javab=javab+((b-a));
                    b=a;
                }
                else
                {
                    javab=javab+(a-(b-k))+1;
                    b=a;
                }
            }
            Console.Write(javab);
        }
    }
}