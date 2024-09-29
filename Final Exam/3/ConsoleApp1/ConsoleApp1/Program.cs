using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        interface Iprintable
        {
            string print();
        }
        class ba<t> : Iprintable where t:IEnumerable<t>
        {
            t a;
            public void gunFun(t a)
            {
                int m=a.Count();
                Random shansi = new Random();
                int n = shansi.Next(1000, 10000);
                string t = "OUT" + n.ToString()+".txt";
                StreamWriter f = new StreamWriter(t);
            }
            public string print()
            {
                return a.ToString();
            }
            public IEnumerator<t> GetEnumerator()
            {
                foreach (var i in a)
                {
                    yield return i;
                }
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
