using System;

namespace ketabkhane
{
    class book
    {
        string name;
        int id;
        int tedad;
        public book(string nam, int sh, int te)
        {
            name = nam;
            id = sh;
            tedad = te;
        }
        public int idbook()
        {
            int m = id;
            return m;
        }
        public int tedadketab()
        {
            int a = tedad;
            return a;
        }
        public string esm()
        {
            string b = name;
            return b;
        }
        public void taqirtedadketab()
        {
            tedad--;
        }
        public void passketab()
        {
            tedad++;

        }
    }
    class person
    {
        string name;
        int id;
        book[] amanat=new book[5];
        public person(string nam,int sh)
        {
            name = nam;
            id = sh;
        }
        public int check()
        {
            int m = id;
            return m;
        }
        public void ketab(int idketab,book[] a,int tb)
        {
            int k=0;
            int n = 0;
            if (amanat != null)
            {
                n = amanat.Length;
            }
            else
            {
                n = 0;
            }
            for(int i=0;i<tb;i++)
            {
                int m = a[i].idbook();
                if (m==idketab)
                {
                    k = i;
                    break;
                }
            }
            int e = 0;
            while(e<5 && amanat[e]!=null)
            {
                e++;
            }
            if ((e + 1) > 5)
            {
                Console.WriteLine("maxreached : name:{0} memberid: {1}", name, id);
            }

            else if (a[k].tedadketab() == 0)
            {
                int q = a[k].idbook();
                string a1 = a[k].esm();
                Console.WriteLine("NotAvailable: bookname:{0} bookid:{1}", a1, q);
            }
            else
            {
                amanat[e] = a[k];
                a[k].taqirtedadketab();
            }
            
        }
        public void passdadanketab(int idbok)
        {
            int w = 0;
            while(w<5 && amanat[w]!=null)
            {
                w++;
            }
            for(int i=0;i<w;i++)
            {
                int m = amanat[i].idbook();
                if(m==idbok)
                {
                    amanat[i].passketab();
                    amanat[i] = null;
                    
                }
            }
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w - 1; j++)
                {
                    if (amanat[j] == null)
                    {
                        book temp;
                        temp = amanat[j];
                        amanat[j] = amanat[j + 1];
                        amanat[j + 1] = temp;
                    }
                }
            }
         
        }
        public bool ketabcheck(int id)
        {
            int q = 0;
            while(q<5 && amanat[q]!=null)
            {
                q++;
            }
            for(int i=0;i<q;i++)
            {
                int r = amanat[i].idbook();
                if (r==id)
                {
                    return true;
                }
            }
            return false;

        }
        public string namfard()
        {
            string a = name;
            return a;
        }
        public void chap()
        {
            int q = 0;
            while(q<5 && amanat[q]!=null)
            {
                q++;
            }
            for(int i=0;i<q;i++)
            {
                Console.Write("ketabname: {0} ketabid:{1}  ", amanat[i].esm(), amanat[i].idbook());
            }
            Console.Write("\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book[] ketab = new book[50];
            int tb = 0;
            int tper = 0;
            person[] fard = new person[50];
         
            string a1 = Console.ReadLine();
            int i = 0;
            int j=0;
            string[] a = a1.Split(" ");
            while(a[0]!="out")
            {
                if(a[0]=="addbook" && i<50)
                {
                    int m = int.Parse(a[1]);
                    int n = int.Parse(a[3]);
                    ketab[i]=new book(a[2],m,n);
                    i++;
                    tb++;
                }
                if (a[0] == "addmember" && j<50)
                {
                    int m1 = int.Parse(a[1]);
                    fard[j] = new person(a[2],m1);
                    j++;
                    tper++;
                }
                if (a[0] == "get")
                {
                    int q = int.Parse(a[1]);
                    for(int k=0; k<j;k++)
                    {
                        int w = fard[k].check();
                        if(w==q)
                        {
                            fard[k].ketab(int.Parse(a[2]), ketab,tb);
                        }
                    }
                }
                if (a[0] == "return")
                {
                    int f = 0;
                    int u=0;
                    int q = int.Parse(a[1]);
                    for (int k = 0; k < j; k++)
                    {
                        int w = fard[k].check();
                        if (w == q)
                        {
                            fard[k].passdadanketab(int.Parse(a[2]));
                            u = k;
                            f = 1;
                        }
                    }
                    for (int t = 0; t < i; t++)
                    {
                        int w = ketab[t].idbook();
                        if (w == (int.Parse(a[2])))
                        {
                            bool y = fard[u].ketabcheck(w);
                            if (f == 0)
                            {


                                Console.WriteLine("in fard chenin ketabi amanat nagerefte");

                            }
                        }
                    }
                }
                if (a[0] == "memberstat")
                {
                    for(int k=0;k<j;k++)
                    {
                        Console.WriteLine("namefard: {0} idfard: {1}  ", fard[k].namfard(), fard[k].check());
                        fard[k].chap();
                    }

                }
                if (a[0] == "bookstat")
                {
                    for(int t=0;t<i;t++)
                    {
                        Console.WriteLine("namebook: {0} idbook: {1} countbook: {2}", ketab[t].esm(), ketab[t].idbook(), ketab[t].tedadketab());
                    }
                }
                a1 = Console.ReadLine();
                a = a1.Split(" ");

            }
        }
    }
}
