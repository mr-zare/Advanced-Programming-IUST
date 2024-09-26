using System;

namespace soal1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            string[] m=a.Split(' ');
            int index=0,t=0,f;
            string b;
            while (t<((m.Length)-1))
            {
                index=t;
                for (int i = t; i < m.Length; i++)
                {
                    f=string.Compare(m[index],m[i]);
                    if (f>0)
                    {
                        index=i;
                    }
                }
                b=m[t];
                m[t]=m[index];
                m[index]=b; 
                t++;
               for (int j = 0; j < m.Length; j++)
                {
                    Console.Write(m[j]+' ');
                }
                Console.Write("\n");
            }
            Console.Write("chap sort nahaii: ");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(m[i]+' ');
            }
        }
    }
}
