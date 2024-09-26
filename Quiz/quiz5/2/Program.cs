//
//func: baraye oonaii ke khoroji darand estefade mishavad .pass baraye haalat 2 ke voide khorooji qalate va nabayad estefade she.
//bara halat 1 amaa mishee estefade kard chon khoroji dare.
//action:baraye delegate haye ba khorooji void mibashad va khorooji nadare(voide).pass haalat 1 ro support nemikone va baraye haalat 2 okaye.

//3 ba writeline kardan dar method mishe.vali agar manzoor int dadane kheir
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
        static void fact(int i)
        {
            int m = 1;
            for (int j = 1; j <= i; j++)
            {
                m = m * j;
            }
            Console.WriteLine($"javab:{m}");
        }
        static void Main(string[] args)
        {
            Action<int> apple = fact;
            int a = int.Parse(Console.ReadLine());
            fact(a);
        }
    }
}
