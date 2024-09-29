using System;

namespace ConsoleApp1
{
    enum noe { TA, Rebel, Normal }
    class daneshjo
    {
        string name;
        string family;
        public int shomare;
        int saat;
        noe a;
        int rate;
        public void nomre()
        {
            if (saat <= 3)
            {
                rate = 0;
            }
            else if (saat >= 4 && saat <= 6)
            {
                rate = 6;
            }
            else if (saat > 6 && saat <= 8)
            {
                rate = 8;
            }
            if (a == noe.Rebel)
            {
                rate = rate / 2;
            }
            if (a == noe.TA)
            {
                rate = rate * 2;
            }

        }
        public daneshjo(string nam, string famil, int adad, int time, noe b)
        {
            name = nam;
            family = famil;
            shomare = adad;
            saat = time;
            a = b;
        }
        public daneshjo(string nam, string famil, int adad, noe b)
        {
            name = nam;
            family = famil;
            shomare = adad;
            saat = 6;
            a = b;
        }
        public void chap()
        {
            Console.WriteLine("{0} {1}: {2}", name, family, rate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            daneshjo[] w = new daneshjo[1];
            int t = 0;
            int u = 0, ad = 0, sa = 0;
            string a1;
            string[] m;
            noe a;
            Console.WriteLine("enter number of people:");
            do
            {
                try
                { t = int.Parse(Console.ReadLine()); }
                catch (Exception e1)
                {
                    Console.Write(e1.Message);
                    Console.WriteLine("format ro dorost vared kon");
                    continue;
                }
                break;
            } while (1 == 1);
            w = new daneshjo[t];
            do
            {
                try
                {
                    
                    Console.WriteLine("enter name,family.shomare,saat and group of person");
                    a1 = Console.ReadLine();
                    m = a1.Split(',');
                    if (m.Length == 5)
                    {
                        ad = int.Parse(m[2]);
                        if ((ad / 1000000) != 98 && (ad / 1000000) != 97 && (ad / 1000000) != 96 && (ad / 1000000) != 95 && (ad / 1000000) != 99)
                        {
                            throw new Exception("do raqam samt chap adad ke bayad 8raqami bashad , az 95 ta 99 mitone bashe");
                        }

                        sa = int.Parse(m[3]);
                        if (sa < 0 || sa > 8)
                        {
                            throw new Exception("saat voroodi ghalate v bayad az 0 ta 8 bashe");
                        }
                        for (int i = 0; i < u; i++)
                        {
                            if (ad == w[i].shomare)
                            {
                                throw new Exception("shomare daneshjooyi tekrarist");
                            }
                        }
                        a = (noe)Enum.Parse(typeof(noe), m[4], true);
                        if (a != noe.TA && a != noe.Rebel && a != noe.Normal)
                        {
                            throw new Exception("noe daneshjo ghalate va mojood nis ");
                        }
                        w[u] = new daneshjo(m[0], m[1], ad, sa, a);
                        w[u].nomre();
                        u++;

                    }
                    if (m.Length == 4)
                    {
                        ad = int.Parse(m[2]);
                        if ((ad / 1000000) != 98 && (ad / 1000000) != 97 && (ad / 1000000) != 96 && (ad / 1000000) != 95 && (ad / 1000000) != 99)
                        {
                            throw new Exception("do raqam samt chap adad 8raqamiman bayad az 95 ta 99 bashe");
                        }
                        
                        a = (noe)Enum.Parse(typeof(noe), m[3], true);
                        if(a!=noe.Normal && a!=noe.Rebel && a!=noe.TA)
                        {
                            throw new Exception("noe daneshjo ro benevis");
                        }
                        w[u] = new daneshjo(m[0], m[1], ad, a);
                        w[u].nomre();
                        u++;
                    }
                    if (m.Length != 4 && m.Length != 5)
                    {

                        throw new Exception("format voroodi eshtebah mibashad.lotfan dobare atelaat ro vared konid");
                    }

                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                    continue;
                }
            } while (u < t);
            for (int i = 0; i < t; i++)
            {
                w[i].chap();
            }
        }
            
    }
}
    
