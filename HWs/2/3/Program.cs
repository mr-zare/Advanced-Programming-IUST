using System;

namespace modiriat_karkhoone
{
    class employee
    {
        int degree;
        int balanced;
        bool special = false;
        bool loaned = false;
        bool hired = false;
        public string name;
        public employee(string nam,int daraje)
        {
            balanced = 0;
            degree = daraje;
            name = nam;
            hired = true;
            loaned = false;
            special = false;
        }
        public static bool smallcheck(string l)
        {
            string a = l.ToLower();
            if(l!=a)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool qeirtekrari (employee[] a,string l,int tedadkarmand)
        {
            if(tedadkarmand==0)
            {
                return true;
            }
            for(int i=0;i<tedadkarmand;i++)
            {
                if(a[i].name==l)
                {
                    return false;
                }
            }
            return true;
        }
        public static void pay(employee[] a,string nam,int tedadkarmand)
        {
            for(int i=0;i<tedadkarmand;i++)
            {
                if(a[i].name==nam)
                {
                    if(a[i].degree==1)
                    {
                        a[i].balanced += 100;
                    }
                    if (a[i].degree == 2)
                    {
                        a[i].balanced += 300;
                    }
                    if (a[i].degree == 3)
                    {
                        a[i].balanced += 700;
                    }
                    if (a[i].degree == 4)
                    {
                        a[i].balanced += 900;
                    }

                }
            }

        }
        public static void get(string nam,int quantity,employee[] a,int tedadkarmand)
        {
            for(int i=0;i<tedadkarmand;i++)
            {
                if(a[i].name==nam)
                {
                    if (quantity <= a[i].balanced)
                    {
                        a[i].balanced -= quantity;
                    }
                    else
                    {
                        Console.WriteLine("not enough money:(");
                    }
                }
            }
        }
        public static void vizhe (string nam,employee[] a,int tedadkarmand)
        {
            for(int i=0;i<tedadkarmand;i++)
            {
                if(a[i].name==nam && a[i].special!=true)
                {
                    a[i].special = true;
                }
            }

        }
        public static void vam(string nam,employee[] a,int tedadkarmand)
        {
            for(int i=0;i<tedadkarmand;i++)
            {
                if(a[i].name==nam)
                {
                    if(a[i].loaned==false && a[i].special==true)
                    {
                        if(a[i].degree==1)
                        {
                            a[i].balanced += 3 * 100;
                        }
                        if (a[i].degree == 2)
                        {
                            a[i].balanced += 3 * 300;
                        }
                        if (a[i].degree == 3)
                        {
                            a[i].balanced += 3 * 700;
                        }
                        if (a[i].degree == 4)
                        {
                            a[i].balanced += 3 * 900;
                        }
                        a[i].loaned = true;
                        Console.WriteLine("accepted");
                    }
                    else
                    {
                        Console.WriteLine("rejected");
                    }
                }
            }
        }
        public static void  erteqa(employee[] a,int tedadkarmand)
        {
            for(int i=0;i<tedadkarmand;i++)
            {
                if (a[i].special == true)
                {
                    if (a[i].degree >= 1 && a[i].degree < 4)
                    {
                        a[i].degree = a[i].degree + 1;
                    }
                    else if (a[i].degree == 4)
                    {
                        a[i].degree = 5;
                        for (int j = 0; j < tedadkarmand; j++)
                        {
                            if (a[j].loaned == true && a[j].special == true)
                            {
                                a[j].loaned = false;
                            }
                        }
                    }
                }
            }
        }
        public static void tanazol(employee[] a, int tedadkarmand)
        {
            for (int i = 0; i < tedadkarmand; i++)
            {
                if (a[i].special == false)
                {
                    if (a[i].degree >= 1 && a[i].degree<=4)
                    {
                        a[i].degree = a[i].degree - 1;
                    }
                }
            }
        }
        public static void gozaresh(string nam,employee[] a,int tedadkarmand)
        {
            for(int i=0;i<tedadkarmand;i++)
            {
                if(a[i].name==nam)
                {
                    if (a[i].special == true)
                    {
                        Console.WriteLine("special name:{0} degree:{1} credit:{2}", a[i].name, a[i].degree, a[i].balanced);
                    }
                    else
                    {
                        Console.WriteLine("name:{0} degree:{1} credit:{2}", a[i].name, a[i].degree, a[i].balanced);
                    }
                }

            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            employee[] a = new employee[100];
            string a1 = Console.ReadLine();
            string[] v = a1.Split(" ");
            int tedad = 0;
            while(v[0]!="end")
            {
                while(v[0]!="hire" && v[0]!="pay" && v[0] != "get" && v[0] != "special" && v[0] != "loan" && v[0] != "promote" 
                    && v[0] != "regress" && v[0]!="report" && v[0]!="end")
                {
                    Console.WriteLine("input is not valid");
                    a1 = Console.ReadLine();
                    v = a1.Split(" ");
                    if(v[0]=="end")
                    {
                        break;
                    }

                }
                if(v[0]=="hire")
                {
                    bool w = employee.smallcheck(v[1]);
                    bool w1 = employee.qeirtekrari(a, v[1], tedad);
                    if(w==true )
                    {
                        if (w1 == false)
                        {
                            while (w1 == false)
                            {
                                Console.WriteLine("esm tekrarie:faghat ye esm bede");
                                string q = Console.ReadLine();
                                int n = int.Parse(v[2]);
                                w1 = employee.qeirtekrari(a, q, tedad);
                            }
                        }
                        if (w1 == true)
                        {
                            int n = int.Parse(v[2]);
                            a[tedad] = new employee(v[1], n);
                            tedad++;
                        }
                      
                    }
                    else
                    {
                        while(w==false)
                        {
                            Console.WriteLine("esm bahorof koochak vared kon:");
                            string q = Console.ReadLine();
                            w = employee.smallcheck(q);
                            int n = int.Parse(v[2]);
                            w1 = employee.qeirtekrari(a, q, tedad);
                            if (w1 == false)
                            {
                                while (w1 == false)
                                {
                                    Console.WriteLine("esm tekrarie:faghat ye esm  bede");
                                    q = Console.ReadLine();
                                    n = int.Parse(v[2]);
                                    w1 = employee.qeirtekrari(a, q, tedad);
                                }
                            }
                            if (w1 == true)
                            {
                                n = int.Parse(v[2]);
                                a[tedad] = new employee(v[1], n);
                                tedad++;
                            }

                        }
                    }
                }
                if (v[0] == "pay")
                {
                    employee.pay(a,v[1],tedad);
                }
                if (v[0] == "get")
                {
                    int r = int.Parse(v[2]);
                    employee.get(v[1], r, a, tedad);
                }
                if (v[0] == "special")
                {
                    employee.vizhe(v[1], a, tedad);
                }
                if (v[0] == "loan")
                {
                    employee.vam(v[1], a, tedad);
                }
                if (v[0] == "promote")
                {
                    employee.erteqa(a, tedad);
                }
                if (v[0] == "regress")
                {
                    employee.tanazol(a, tedad);
                }
                if (v[0] == "report")
                {
                    employee.gozaresh(v[1], a, tedad);
                }
                a1 = Console.ReadLine();
                v = a1.Split(" ");
            }






        }
    }
}
