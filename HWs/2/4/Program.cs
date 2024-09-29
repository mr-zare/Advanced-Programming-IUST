using System;

namespace adad_mokhtalet
{
    class TwoComplex
    {
        int a, b;
        int c, d;
        public void start()
        {
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            string d1 = Console.ReadLine();
            a = int.Parse(a1);
            b = int.Parse(b1);
            c = int.Parse(c1);
            d = int.Parse(d1);

        }
        public void Add()
        {
            double hasels = a + c;
            double haselm = b + d;
            Console.Write(hasels+" ");
            Console.Write(haselm+"\n");
        }
        public void Sub()
        {
            double hasels = a - c;
            double haselm = b - d;
            Console.Write(hasels + " ");
            Console.Write(haselm+"\n");
        }
        public void mul()
        {
            double hasels = a * c - b * d;
            double haselm = a * d + b * c;
            Console.Write(hasels +" ");
            Console.Write(haselm+"\n");
        }
        public void div()
        {
            double hasels = (a * c + b * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));
            double haselm = (b * c - a * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));
            Console.Write(hasels + " ");
            Console.Write(haselm+"\n");
        }
        public void changeNumbers()
        {
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            string d1 = Console.ReadLine();
            a = int.Parse(a1);
            b = int.Parse(b1);
            c = int.Parse(c1);
            d = int.Parse(d1);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TwoComplex obj=new TwoComplex();
            obj.start();
            Console.WriteLine("+:1");
            Console.WriteLine("-:2");
            Console.WriteLine("*:3");
            Console.WriteLine("/:4");
            Console.WriteLine("change:5");
            Console.WriteLine("exit:zz");
            string m = Console.ReadLine();
            while (m != "zz")
            {

                if (m == "1")
                {
                    obj.Add();
                }
                if (m == "2")
                {
                    obj.Sub();
                }
                if (m == "3")
                {
                    obj.mul();
                }
                if (m == "4")
                {
                    obj.div();
                }
                if (m == "5")
                {
                    obj.changeNumbers();
                }
                Console.WriteLine("+:1");
                Console.WriteLine("-:2");
                Console.WriteLine("*:3");
                Console.WriteLine("/:4");
                Console.WriteLine("change:5");
                Console.WriteLine("exit:zz");
                m = Console.ReadLine();
            }
        }
    }
}
