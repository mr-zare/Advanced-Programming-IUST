using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class LimitedCollections<t>:IEnumerable<t> where t : IComparable<t>
    {
        t hadbala;
        t hadpaiin;
        List<t> list1 = new List<t>();
        public LimitedCollections(t paiin, t bala)
        {
            if(paiin.CompareTo(bala)>0)
            {
                t temp = paiin;
                paiin = bala;
                bala = temp;
            }
            hadbala = bala;
            hadpaiin = paiin;
        }
        public IEnumerator<t> GetEnumerator()
        {
            foreach(var i in list1)
            {
                yield return i;
            }
        }
        public IEnumerable<t> reverse
        {
            get
            {
                for(int i=list1.Count-1;i>=0; i--)
                {
                    yield return list1[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public int tedad
        {
            get { return list1.Count; }
        }
        public void insert(t a)
        {
            if(a.CompareTo(hadpaiin)>=0 && a.CompareTo(hadbala)<=0)
            {
                list1.Add(a);

            }
            else
            {
                Console.WriteLine("voroodi {0} dar mahdoode nis",a);
            }
        }
        public t Remove()
        {
            if(list1.Count==0)
            {
                throw new Exception("list khalie va nemishe chizi remove kard");
            }
            else
            {
                for(int i=0;i<list1.Count;i++)
                {
                    for(int j=0;j<list1.Count ;j++)
                    {
                        if(list1[i].CompareTo(list1[j])>0)
                        {
                            t temp;
                            temp = list1[i];
                            list1[i] = list1[j];
                            list1[j] = temp;
                        }
                    }

                }
                int t1 = list1.Count - 1;
                t ret = list1[t1];
                list1.Remove(list1[t1]);
                return ret;
            }
        }     
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" had paiin string");
                string hp = Console.ReadLine();
                Console.WriteLine("had bala string");
                string hb = Console.ReadLine();
                LimitedCollections<string> st = new LimitedCollections<string>(hp, hb);
                Console.WriteLine("reshto voroodi ha ra ke ba (-) joda sshodan vared konid");
                string reshte = Console.ReadLine();
                string[] reshte1 = reshte.Split('-');
                for (int  j= 0; j < reshte1.Length; j++)
                {
                    st.insert(reshte1[j]);
                }
                st.Remove();
                Console.WriteLine("\nmoratab shode ba pak shode update:");
                foreach(string q in st)
                {
                    Console.Write(q + " ");
                }
                Console.WriteLine("\nmoratab shode ba pak shode reverse:");
                foreach (string q in st.reverse)
                {
                    Console.Write(q + " ");
                }
                Console.WriteLine("tedad ozv:{0}", st.tedad);


                Console.WriteLine(" had paiin adad sahih");
                int hp1 = int.Parse(Console.ReadLine());
                Console.WriteLine("had bala adad sahih");
                int hb1 = int.Parse(Console.ReadLine());
                LimitedCollections<int> adad = new LimitedCollections<int>(hp1, hb1);
                Console.WriteLine("adadhaye voroodi ha ra ke ba (-) joda shodan vared konid");
                string reshte0 = Console.ReadLine();
                string[] reshte11 = reshte0.Split('-');
                int[] voroodi = new int[reshte11.Length];
                int i = 0;
                while (i < reshte11.Length)
                {
                    try
                    {
                        voroodi[i] = int.Parse(reshte11[i]);
                        i++;
                    }
                    catch(Exception )
                    {
                        Console.WriteLine("voroodi bayad adad bashe :|");
                    }
                }
                for (i = 0; i < voroodi.Length; i++)
                {
                    adad.insert(voroodi[i]);
                }
                adad.Remove();
                Console.WriteLine("\nmoratab shode ba pak shode update:");
                foreach(int w in adad)
                {
                    Console.Write(w + " ");
                }
                Console.WriteLine("\nmoratab shode ba pak shode reverse:");
                foreach (int w in adad.reverse)
                {
                    Console.Write(w + " ");
                }
                Console.WriteLine("tedad ozv:{0}", adad.tedad);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
