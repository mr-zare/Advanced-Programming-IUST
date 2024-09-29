using System;
using System.IO;
namespace ConsoleApp1
{
    struct book
    {
        string namebook;
        string writer;
        int price;
        int id;
        string nasher;
        char flag;
        public int shenase()
        {
            if (flag == '\0')
            {
                return id;
            }
            else
            {
                return -1;
            }
        }
        public char f()
        {
            return flag;
        }
        public string nam()
        {
            return namebook;
        }
        public book(string nam, string nevisande, int adad, int fee, string publication)
        {
            namebook = nam;
            writer = nevisande;
            price = fee;
            id = adad;
            nasher = publication;
            flag = '\0';
        }
        public void chap(StreamWriter a)
        {
            if (flag == '\0')
            {
                Console.WriteLine("book");
                Console.WriteLine("name:{0}", namebook);
                Console.WriteLine("writer:{0}", writer);
                Console.WriteLine("price:{0}", price);
                Console.WriteLine("id:{0}", id);
                Console.WriteLine("publication:{0}\n", nasher);

                a.WriteLine("book");
                a.WriteLine("name:{0}", namebook);
                a.WriteLine("writer:{0}", writer);
                a.WriteLine("price:{0}", price);
                a.WriteLine("id:{0}", id);
                a.WriteLine("publication:{0}\n", nasher);
            }
        }
        public int check(int id)
        {
            if (this.id == id && this.flag=='\0')
            {
                Console.WriteLine("name:{0}", namebook);
                Console.WriteLine("writer:{0}", writer);
                Console.WriteLine("price:{0}", price);
                Console.WriteLine("publication:{0}", nasher);
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int pak(int id)
        {
            if (this.id == id && this.flag=='\0')
            {
                flag = '*';
                return 0;
            }
            return 1;

        }
        public static void sortbyname(book[] ketab, int a,int a1)
        {
            string[] nam1 = new string[a];
            int K = 0;
            for (int i = 0; i < a1; i++)
            {
                if (ketab[i].f() == '\0')
                {
                    nam1[K] = ketab[i].nam();
                    K++;
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a-1; j++)
                {
                    string temp;
                    if (string.Compare(nam1[j], nam1[j + 1]) == 1)
                    {
                        temp = nam1[j];
                        nam1[j] = nam1[j + 1];
                        nam1[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0}", nam1[i]);
            }
        }
        public static void sortbyid(book[] ketab, int a,int a1)
        {
            int[] id1 = new int[a];
            int K = 0;
            for (int i = 0; i < a1; i++)
            {
                if (ketab[i].f() == '\0')
                {
                    id1[K] = ketab[i].shenase();
                    K++;
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a-1; j++)
                {
                    int temp;
                    if (id1[j] > id1[j + 1])
                    {
                        temp = id1[j];
                        id1[j] = id1[j + 1];
                        id1[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0}", id1[i]);
            }

        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            book[] ketab = new book[10];

            int price, id,a=0,a1=0,search,flag1=0,flag2=0,delete;
            string name,writer,nasher,vo2;
            Console.WriteLine("ADD \nLIST \nSEARCH\nDELETE \nSORT\nEXIT");
            string vo = Console.ReadLine();
            StreamWriter file;
            do
            {
                try
                {
                    if(string.Equals(vo,"ADD"))
                    {
                        Console.WriteLine("please enter information of the book");
                        Console.WriteLine("please enter name of the book");
                        name = Console.ReadLine();
                        Console.WriteLine("please enter writer of the book");
                        writer = Console.ReadLine();
                        Console.WriteLine("please enter id of the book");
                        id = int.Parse(Console.ReadLine());
                        for(int i=0;i<a1;i++)
                        {
                            if(ketab[i].shenase()==id)
                            {
                                throw new Exception("shenase tekrari mibashad");
                            }
                        }
                        Console.WriteLine("please enter price of the book");
                        price = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter publication of the book");
                        nasher = Console.ReadLine();
                        ketab[a] = new book(name, writer, id, price, nasher);
                        a++;
                        a1++;
                    }
                    if (string.Equals(vo, "LIST"))
                    {
                        file = new StreamWriter("info.txt");
                        for(int i=0;i<a1;i++)
                        {
                            ketab[i].chap(file);
                        }
                        file.Close();
                    }
                    if (string.Equals(vo, "SEARCH"))
                    {
                        Console.WriteLine("id ra vared konid:");
                        flag1= 0;
                        search = int.Parse(Console.ReadLine());
                        for(int i=0;i<a1;i++)
                        {
                            flag1=ketab[i].check(search);
                            if(flag1==1)
                            {
                                break;
                            }
                        }
                        if(flag1==0)
                        {
                            throw new Exception("chenin id mojood nis.lotfan deqat konid"); 
                        }
                    }
                    if (string.Equals(vo, "DELETE"))
                    {
                        Console.WriteLine("ID ravared konid:");
                        flag2 = 1;
                        delete =int.Parse(Console.ReadLine());
                        for(int i=0;i<a1;i++)
                        {
                            flag2 = ketab[i].pak(delete);
                            if(flag2==0)
                            {
                                a--;
                                break;
                            }
                        }
                        if(flag2==1)
                        {
                            throw new Exception("chenin id baraye delete mojood nis.");
                        }
                    }
                    if (string.Equals(vo, "SORT"))
                    {
                        Console.WriteLine("SORTBYNAME OR SORTBYID ?");
                        vo2 = Console.ReadLine();
                        if(string.Equals(vo2,"SORTBYNAME"))
                        {
                            book.sortbyname(ketab,a,a1);
                        }
                        if(string.Equals(vo2,"SORTBYID"))
                        {
                            book.sortbyid(ketab, a,a1);
                        }
                        if(!string.Equals(vo2,"SORTBYID") && (!string.Equals(vo2,"SORTBYNAME")))
                        {
                            throw new Exception("chenin noe sorti nadarim.");

                        }

                    }
                    if(!string.Equals(vo,"ADD") && (!string.Equals(vo, "SEARCH")) && (!string.Equals(vo, "SORT")) &&
                        (!string.Equals(vo, "LIST")) && (!string.Equals(vo, "DELETE")))
                    {
                        throw new Exception("chenin gozine ii nadarim ke.deqat kon");
                    }
                    Console.WriteLine("ADD \nLIST \nSEARCH\nDELETE \nSORT\nEXIT");
                    vo = Console.ReadLine();
                }
                catch(Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("ADD \nLIST \nSEARCH\nDELETE \nSORT\nEXIT");
                    vo = Console.ReadLine();
                }
            } while (!String.Equals(vo,"EXIT"));
        }
    }
}
