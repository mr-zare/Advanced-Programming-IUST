using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        class Circle
        {
            int arz;
            int tool;
            int r;
            public Circle(int a,int t,int sh)
            {
                arz = a;
                tool = t;
                r = sh;
            }
            public static Circle operator +(Circle aval,Circle dovom)
            {
                return new Circle(aval.arz + dovom.arz, aval.tool + dovom.tool, aval.r + dovom.r);
            }
            public static Circle operator -(Circle aval, Circle dovom)
            {
                return new Circle(aval.arz - dovom.arz, aval.tool - dovom.tool, aval.r - dovom.r);
            }
            public static Circle operator *(Circle aval, Circle dovom)
            {
                return new Circle(aval.arz * dovom.arz, aval.tool * dovom.tool, aval.r * dovom.r);
            }
            public void print()
            {
                Console.WriteLine($"arz:{arz},tool:{tool},shoae:{r}");
            }
        }
        static void Main(string[] args)
        {
            Circle c1 = new Circle(0, 0, 10);
            Circle c2 = new Circle(5, 3, 6);
            Circle c3 = c1 + c2;
            c3.print();
            c3 = c1 - c2;
            c3.print();
            c3 = c1 * c3;
            c3.print();


        }
    }
}
