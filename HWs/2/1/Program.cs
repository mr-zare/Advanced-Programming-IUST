using System;
using System.ComponentModel;

namespace hamayesh_mavafaqiat
{
    class Participant
    {
        string nam;
        string family;
        int id;
        static int fee=900;
        public Participant(int adad)
        {
            id = adad;
        }
        public Participant(string esm, string famil, int shomare)
        {
            id = shomare;
            nam = esm;
            family = famil;
        }
        public static int CalculatePrice()
        {
            fee = fee + 100;
            return fee;
        }
        public static int CountParticipants(Participant[] w)
        {
            return w.Length;
        }
    }
    class Conference
    {
        string confname;
        string salonname;
        int faza;
        public Participant[] sabt;
        public Conference(string a, string b, int c)
        {
            confname = a;
            salonname = b;
            faza = c;
        }
        public void AddParticipant(Participant[] b1)
        {
            int a;
            if(sabt!=null)
            {
                a = Participant.CountParticipants(sabt);
                Console.WriteLine("andaze:{0}", a);
            }
            else
            {
                a = 0;
            }

            
            int b = b1.Length;
            if(a!=0 && (a+b)<=faza)
            {
                Participant[] a1 = new Participant[a + b];
                for(int i=0;i<a;i++)
                {
                    a1[i] = sabt[i];
                }
                int w = 0;
                for(int j=a; j<a+b; j++ , w++)
                {
                    a1[j] = b1[w];
                    Participant.CalculatePrice();
                    Console.WriteLine("qeimat belit: {0} ", Participant.CalculatePrice());
                }
                sabt = new Participant[a + b];
                sabt = a1;
                Console.WriteLine("okeye");
            }
            else if((a+b)>faza)
            {
                Console.WriteLine(" zarfyat pore");
                Console.WriteLine("tedad a:{0} tedad b:{1}", a, b);
            }
            if(a==0 && (a+b)<=faza)
            {
                Participant[] m = new Participant[b];
                for(int i=0;i<b;i++)
                {
                    m[i] = b1[i];
                    Participant.CalculatePrice();
                    Console.WriteLine("qeimat belit: {0} ", Participant.CalculatePrice());
                }
                sabt = m;
                Console.WriteLine("okeye");
            }
        }

        public Conference(string a, string b, int c, Participant[] d)
        {
            confname = a;
            salonname = b;
            faza = c;
            sabt = d;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            string esmconf = Console.ReadLine();
            string saloon = Console.ReadLine();
            int zarfiat = int.Parse(Console.ReadLine());
            Conference a = new Conference(esmconf, saloon, zarfiat);
            string n = Console.ReadLine();
            int n1 = int.Parse(n);
            Participant[] w = new Participant[n1];
            while(n!="zz")
            {
                for(int i=0;i<n1;i++)
                {
                    string nam = Console.ReadLine();
                    string famil = Console.ReadLine();
                    int t1=int.Parse(Console.ReadLine());
                    w[i] = new Participant(nam, famil, t1);
                }
                a.AddParticipant(w);
                n = Console.ReadLine();
                if (n != "zz")
                {
                    n1 = int.Parse(n);
                }
                    w = new Participant[n1];
            }
        }
    }
}
