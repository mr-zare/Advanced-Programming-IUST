using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Acount
        {
            public string nam;
            public int code;
            public int shomare;
            public double mojod;
        }
        static void Main(string[] args)
        {
            List<Acount> m=infos 
            for(int i=0;i<infos.count;i++)
            {
                for (int j = 0; j < m.count; j++)
                {
                    if (m.code[j] == m.code[j + 1})
                    {
                        m.Remove(m[j]);
                    }
                }
            }
            List<Acount> t = m.orderbydescending(x => x.code);
            int z = m.where(x => x.shomare % 100 = 0).sum(y=>y.mojod);
            int e = m.groupby(x => x.code);
    list<int> f = new list<int>();
    list<int> r = new list<int>();
        for(int i=0;i<e.count();i++)
        {
            f.add(e.key);
            r.add(e.sum)());
        }
        r.sort();
Console.WriteLine($"{r[0]}");
    }
}
