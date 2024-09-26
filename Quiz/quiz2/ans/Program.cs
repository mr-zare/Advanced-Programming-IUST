using System;

namespace soal2
{
    class Person
    {
        string name;
         string family;
         int age;
        int price;
        int hours;
        public static int tedadobj;
        public static Person[] obj;

        public Person(string nam,string famil,int saat, int sen=18,int fee=200)
        {
            if (nam != "")
            {

                name = nam;
            }
            else
                while(nam=="")
                {
                    nam = Console.ReadLine();
                }
            if(sen<0)
            {
                while(sen<0)
                {
                    sen = int.Parse(Console.ReadLine());
                }
            }
            age = sen;
            if (fee < 0)
            {
                while (fee < 0)
                {
                    fee = int.Parse(Console.ReadLine());
                }
            }
            price = fee;

            if (saat < 0)
            {
                while (saat < 0)
                {
                    saat = int.Parse(Console.ReadLine());
                }
            }
            hours = saat;
            name = nam;
            family = famil;
            hours = saat;
        }
        public Person()
        {
            name = "erfan";
            family = "zare";
            age = 20;
            price = 100;
            hours = 8;
        }
        public int feesali()
        {
            return price;
        }
        public int kar()
        {
            return hours;
        }
        public string nam()
        {
            return name;
        }
        public string famil()
        {
            return family;
        }
        public int sen2()
        {
            return age;
        }

        public int pool()
        {
            return price;
        }
        public int saat()
        {
            return hours;
        }



    }

    class Program
    {
        static int hoghogh(Person a)
        {
            int a1 = a.feesali();
            int a2 = a.kar();
            int n = a1 * a2 * 289;
            return n; 
        }
        static int saatkar(Person b)
        {
            int b1 = b.kar();
            int m = b1 * 289;
            return m;
        }
        static int tedadshey()
        {
            
            int n=Person.tedadobj;
            return n;

        }
        static Person[] search1(string e)
        {
            int n;
            n = Person.tedadobj;
            Person[] sh1 = new Person[n];
            Person[] ne = new Person[n];
            sh1 = Person.obj;
            int j = 0;
            for(int i=0;i<n;i++)
            {
                string m = sh1[i].nam();
                if(m==e)
                {
                    Console.WriteLine("too shomarre {0} hast", i);
                    ne[j] = sh1[i];
                    j++;
                }
                return ne;
            }

        }
        static void chap(Person a)
        {
            int n = hoghogh(a);
            string a1=a.nam();
            string a2 = a.famil();
            int a3 = a.sen2();
            int a4 = a.pool();
            int a5 = a.saat();
            int m = saatkar(a);
            Console.WriteLine("{0} {1} {2} {3} {4} {5} pool saliane {6} saatkar {7}", a1, a2, a3, a4, a5, n, m);
        }
        static Person clone (Person a)
        {
            string a1 = a.nam();
            string a2 = a.famil();
            int a3 = a.saat();
            return new Person(a1,a2,a3,18,200);
        }
        static Person shallowclone(Person a,int pool,int senn)
        {
            string a1 = a.nam();
            string a2 = a.famil();
            int a3 = a.saat();
            return new Person(a1,a2,a3,senn,pool);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            object[] sh = new object[n];
            sh = Person.obj;
            for(int i=0;i<n;i++)
            {
                string esm = Console.ReadLine();
                string khane = Console.ReadLine();
                int time = int.Parse(Console.ReadLine());
                Person a = new Person(esm, khane, 18, 200, time);
                sh[i] = a;
                Person.tedadobj++;
            }
            for (int j = 0; j < n; j++)
            {
                hoghogh((Person)sh[j]);
            }
            int meqdar = int.Parse(Console.ReadLine());
            int sen1 = int.Parse(Console.ReadLine());
            Person a2 = shallowclone((Person)sh[1],meqdar,sen1);
            Person a3 = clone((Person)sh[1]);
        }
    }
}
