using System;
using System.ComponentModel;
using System.IO;

namespace class_dayere
{
    class Circle
    {
        double r;
        double tool;
        double arz;
        public Circle(double a,double b,double c)
        {
            r = a;
            tool = b;
            arz = c;
        }
        public double Mohit()
        {
            double m = 3.14 * 2 * r;
            Console.Write("mohit {0} ", m);
            return m;
        }
        public double Masahat()
        {
            double s = 3.14 * Math.Pow(r, 2);
            Console.WriteLine("masahat {0} ", s);
            return s;
        }
        public static double fasmo(Circle c)
        {
             return (Math.Sqrt ( Math.Pow(c.tool, 2) + Math.Pow(c.arz, 2)));
        }
        public double fasras(double a1,double b1)
        {
            double p = Math.Sqrt(Math.Pow((a1 - tool), 2) + Math.Pow((b1 - arz), 2));
            Console.Write("fasele ta ras {0}", p);
            return p;
        }
        public void check(double a2,double b2)
        {
            double q =Math.Sqrt(Math.Pow((a2 - tool), 2) + Math.Pow((b2 - arz), 2));
            if (q == r)
            {
                Console.WriteLine("  rooye dayere");
            }
            if(q<r)
            {
                Console.WriteLine("  dakhel dayere");
            }
            if(q>r)
            {
                Console.WriteLine("  kharej dayere");
            }
        }
        public Circle Copy()
        {
            Circle c1;
            double a = 2 * r - 3;
            if(a==0)
            {
                a = 1;
            }
            if(a<0)
            {
                a = a * -1;
            }
            double b = tool - 2;
            double d = arz + 1;
            c1 = new Circle(a, b, d);
            Console.WriteLine("shoa:{0},tool:{1},arz:{2}", a, b, d);
            return c1;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            int n = int.Parse(n1);
            Circle[] dayere=new Circle[2*n];
            double[] fastamar = new double[2*n];
            double[] mas = new double[2*n];
            double[] moh = new double[2*n];
            double[] fas = new double[2*n];
            for (int i = 0; i < n; i++)
            {
                string r1 = Console.ReadLine();
                double r2 = double.Parse(r1);
                while (r2 <= 0)
                {
                    Console.Write("dorost vared kon: ");
                    r1 = Console.ReadLine();
                    r2 = double.Parse(r1);
                }
                string x1 = Console.ReadLine();
                string y1 = Console.ReadLine();
                double x2 = double.Parse(x1);
                double y2 = double.Parse(y1);
                dayere[i] = new Circle(r2, x2, y2);
                moh[i]=dayere[i].Mohit();
                mas[i]=dayere[i].Masahat();
                string a3 = Console.ReadLine();
                string b3 = Console.ReadLine();
                double a = double.Parse(a3);
                double b = double.Parse(b3);
                fas[i]=dayere[i].fasras(a, b);
                dayere[i].check(a, b);
                dayere[i + n] = dayere[i].Copy();
                moh[i+n]=dayere[i+n].Mohit();
                mas[i+n]=dayere[i + n].Masahat();
                fas[i+n]=dayere[i + n].fasras(a, b);
                dayere[i + n].check(a, b);
                fastamar[i] = Circle.fasmo(dayere[i]);
                fastamar[i + n] = Circle.fasmo(dayere[i + n]);
            }
            for (int i = 0; i < 2 * n; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    if (moh[j] > moh[j + 1])
                    {
                        double temp = moh[j];
                        moh[j] = moh[j + 1];
                        moh[j + 1] = temp;

                    }
                    if (mas[j] > mas[j + 1])
                    {
                        double temp1 = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp1;

                    }
                    if (fas[j] > fas[j + 1])
                    {
                        double temp2 = fas[j];
                        fas[j] = fas[j + 1];
                        fas[j + 1] = temp2;
                    }
                    if (fastamar[j] > fastamar[j + 1])
                    {
                        double temp2 = fastamar[j];
                        fastamar[j] = fastamar[j + 1];
                        fastamar[j + 1] = temp2;
                    }
                }
            }
            Console.Write("\n mohit:");
            for (int e2 = 0; e2 <2*n ; e2++)
            {
                Console.Write("{0}:  {1},", e2, moh[e2]);
            }
            Console.Write("\n masahat:");
            for (int j = 0; j < 2*n ; j++)
            {
                Console.Write("{0}:  {1},", j, mas[j]);
            }
            Console.Write("\n fasele ta ras:");
            for (int k = 0; k < 2*n ; k++)
            {
                Console.Write("{0}: {1},", k, fas[k]);
            }
            StreamWriter writer;
            writer = new StreamWriter("Circle.txt");
            writer.Write("mohit  ");
            for (int w = 0; w <2*n ; w++)
            {
                writer.Write(moh[w]+ " ");
            }
            writer.WriteLine(" ");
            writer.Write("masahat  ");
            for (int w = 0; w < 2 * n ; w++)
            {
                writer.Write(mas[w] + " ");
            }
            writer.WriteLine(" ");
            writer.Write("fasele ta markaz mokhtasat  ");
            for (int w = 0; w < 2 * n ; w++)
            {
                writer.Write(fastamar[w] + " ");
            }
            writer.WriteLine(" ");
            writer.Close();
        }
    }
}
