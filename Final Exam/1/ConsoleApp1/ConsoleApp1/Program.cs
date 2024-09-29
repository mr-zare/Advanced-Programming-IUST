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
        public static int CountZeros( int adad)
        {
            int ts = 0;
            int a = adad;
            int t;
            while (a != 0)
            {
                t = a % 10;
                a = a / 10;
                if (t == 0)
                {
                    ts++;
                }
            }
            return ts;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("adad ra vared konid");
                int n = int.Parse(Console.ReadLine());
                int z = CountZeros(n);
                Console.WriteLine($"javab:{z}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
