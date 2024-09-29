using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp1
{
    enum jens
    { Phone=1,car=2,watch=3,T_shirt = 4, Laptop = 5, Tablet = 6, Charger = 7, Glass = 8, Robot = 9}
    class Product
    {
        
        int _id, _price,_nomre;
        string _name;
        int id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public string name { 
            set
            {
                _name = value;
            } 
            get
            {
                return _name;
            }
        }
        public int price
        {
            set
            {
                _price = value;
            }
            get
            {
                return _price;
            }
        }
        int nomre
        {
            set
            {
                _nomre = value;
            }
            get
            {
                return _nomre;
            }
        }
        char karkhoone {get;}
        static List<int> listid = new List<int>();
        //check shodan id ro benevis
        public Product(int idd,string nam,int fee,int rate)
        {
            id = idd;
            name = nam;
            price = fee;
            nomre = rate;
            int q = listid.Count;
            for(int i=0;i<listid.Count;i++)
            {
                if(listid[i]==id)
                {
                    throw new Exception("id tekrarie ke");
                }
            }

            listid.Add(idd);
            if(id>=1 && id<=5)
            {
                karkhoone = 'a';
            }
            if (id >= 6 && id <= 10)
            {
                karkhoone = 'b';
            }
            if (id >= 10)
            {
                karkhoone = 'c';
            }
        }

    }
    class category
    {
        int id;
        List<Product> list = new List<Product>(); 
        jens name;
        public category(jens nam)
        {
            this.id = (int)nam;
            name = nam;
        }
        public void AddProductCategory(List<Product> m)
        {
            int t = list.Count;
            for(int i=0;i<m.Count;i++)
            {
                list.Add(m[i]);
            }
        }
        public List<Product> FilterByPrice(int low,int high)
        {
            List<Product> m = new List<Product>();
            int j = 0;
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].price>low &&list[i].price<high)
                {
                    m.Add(list[i]);
                    j++;
                }
            }
            return m;
        }
        public void ShowSupply()
        {
            for(int i=0;i<list.Count;i++)
            {
                for(int j=i+1;j<list.Count ; j++)
                {
                    if(list[j].price<list[i].price)
                    {
                        Product temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine("name:{0} price:{1}", list[i].name, list[i].price);
            }
        }

    }
    struct people
    {
        string name;
        string family;
        int sen;
        string shomare;
        public people(string nam,string famil,int years,string tel)
        {
            name = nam;
            family = famil;
            sen = years;
            int t = tel.Length;
            if(t!=11)
            {
                throw new Exception("bayad shomare 11raqami bashe");
            }
            long m = long.Parse(tel);
            if(m/1000000000 !=9 || tel[0]!='0')
            {
                throw new Exception("bayad sakhtar shomare ba 09 shoroe she");
            }
            shomare = tel;
        }
        public void Info()
        {
            Console.WriteLine("name:{0} familyname:{1} tel:{2}", name, family, shomare);
        }
    }
    class Cart
    {
        people saheb;
        List<Product> sabad=new List<Product>();
        //in ja soal she ke saheb chetor  meqdar dehi she
        public Cart (people a)
        {
            saheb = a;
        }
        public void AddProductToCart(List<Product> m)
        {
            for (int i = 0; i < m.Count; i++)
            {
                sabad.Add(m[i]);
            }
        }
        public void CalculatePrice()
        {
            int jam = 0;
            saheb.Info();
            for(int i=0;i<sabad.Count;i++)
            {
                Console.WriteLine("nameproduct:{0} price:{1}", sabad[i].name, sabad[i].price);
                jam += sabad[i].price;
            }
            Console.WriteLine("jam e qeimat mahsolat:{0}", jam);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string vo;
            jens code=jens.car;
            int ncode=0;
            int flag = 0, f = 0, tedad, t = 0, t1, id, price, rate, low, high, age, n, tabah = 0;
            people happy;
            Cart man;
            string vo1,vo2, nam;
            string name, familyname, tel;
            List<Product> list=new List<Product>();
            List<Product> listcart = new List<Product>();
            do
            {
                Console.WriteLine("Category\nCart\nExit");
                vo = Console.ReadLine();

                try
                {
                    if(string.Equals(vo,"Category"))
                    {
                        category a;
                        do
                        {
                            try
                            {
                                Console.WriteLine("nam mahsool ravared konid:");
                                code = (jens)Enum.Parse(typeof(jens), Console.ReadLine(), false);
                                ncode = (int)code;
                                if (ncode != 1 && ncode != 2 && ncode != 3 && ncode != 4 && ncode != 5 && ncode != 6 &&
                                    ncode != 7 && ncode != 8 && ncode != 9)
                                {
                                    throw new Exception("dorost vared konid");
                                }
                                else
                                {
                                    flag = 1;        
                                   
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            
                        } while (flag == 0);
                         a = new category(code);
                        flag = 0;
                        do
                        {
                            Console.WriteLine("AddProductCategory\nFilterByPrice\nShowSupply");
                            vo1 = Console.ReadLine();
                            if (string.Equals(vo1,"AddProductCategory"))
                            {
                                Console.WriteLine("tedad mahsool ra befarmaiid:");
                                tedad = int.Parse(Console.ReadLine());
                                do
                                {
                                    try
                                    {
                                        Console.WriteLine("nam e mahsool ra vared konid");
                                        nam = Console.ReadLine();
                                        Console.WriteLine("id e mahsool ra vared konid");
                                        id = int.Parse(Console.ReadLine());
                                        Console.WriteLine("qeimat e mahsool ra vared konid");
                                        price =int.Parse (Console.ReadLine());
                                        Console.WriteLine("emtiaz e mahsool ra vared konid");
                                        rate =int.Parse(Console.ReadLine());
                                        list.Add(new Product(id, nam, price, rate));
                                        t++;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }
                                } while (t < tedad);
                                t = 0;
                                a.AddProductCategory(list);
                            }
                            if (string.Equals(vo1, "FilterByPrice"))
                            {
                                Console.WriteLine("kamtarin fee va bishtarin fee ra vared,ta ajnas beynshan ra begoyam ");
                                low =int.Parse(Console.ReadLine());
                                high =int .Parse(Console.ReadLine());
                                List<Product> w=a.FilterByPrice(low, high);
                                Console.WriteLine("name:{0} id:{1}", code.ToString(), ncode);
                                for (int i=0;i<w.Count;i++)
                                {
                                    Console.WriteLine("product:{0} price:{1}", w[i].name, w[i].price);
                                }
                            }
                            if (string.Equals(vo1, "ShowSupply"))
                            {
                                Console.WriteLine("name:{0} id:{1}", code.ToString(), ncode);
                                a.ShowSupply();
                            }
                            if(!string.Equals(vo1, "ShowSupply") && !string.Equals(vo1, "FilterByPrice") 
                                && !string.Equals(vo1, "AddProductCategory"))
                            {
                                Console.WriteLine("voroodi mojood nis ke.dobare talash kon");
                            }
                            
                        } while (!string.Equals(vo1, "Back"));

                    }
                    if(string.Equals(vo,"Cart"))
                    {
                        Console.WriteLine("whats your name:");
                        name = Console.ReadLine();
                        Console.WriteLine("whats your familyname:");
                        familyname = Console.ReadLine();
                        Console.WriteLine("how old are you");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("whats your phone number:");
                        tel = Console.ReadLine();
                        do
                        {
                            try
                            {
                                t1 = tel.Length;
                                if (t1 != 11)
                                {
                                    throw new Exception("bayad shomare 11raqami bashe");
                                }
                                long m = long.Parse(tel);
                                if (m / 1000000000 != 9 || tel[0] != '0')
                                {
                                    throw new Exception("bayad sakhtar shomare ba 09 shoroe she");
                                }
                                else if(t1==11 && m / 1000000000 == 9 && tel[0] == '0')
                                {
                                    f = 1;
                                }

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.WriteLine("whats your phone number:");
                                tel = Console.ReadLine();
                            }
                        } while (f == 0);
                        f = 0;
                        happy = new people(name, familyname, age, tel);
                        man = new Cart(happy);
                        
                        do
                        {
                            Console.WriteLine("AddProductTocart\nBack\nCalculatePrice");
                            vo2 = Console.ReadLine();
                            try
                            {
                                if (string.Equals(vo2, "AddProductTocart"))
                                {
                                    Console.WriteLine("tedad ro vared konid:");
                                    n = int.Parse(Console.ReadLine());
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("nam e mahsool ra vared konid");
                                            nam = Console.ReadLine();
                                            Console.WriteLine("id e mahsool ra vared konid");
                                            id = int.Parse(Console.ReadLine());
                                            Console.WriteLine("qeimat e mahsool ra vared konid");
                                            price = int.Parse(Console.ReadLine());
                                            Console.WriteLine("emtiaz e mahsool ra vared konid");
                                            rate = int.Parse(Console.ReadLine());
                                            listcart.Add( new Product(id, nam, price, rate));
                                            tabah++;
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine(e.Message);
                                        }
                                    } while (tabah < n);
                                    tabah = 0;
                                    man.AddProductToCart(listcart);
                                    
                                }
                                if (string.Equals(vo2, "CalculatePrice"))
                                {
                                    man.CalculatePrice();
                                }
                                else if (!string.Equals(vo2, "CalculatePrice") && !string.Equals(vo2, "AddProductTocart"))
                                {
                                    throw new Exception("voroodi dorost vared nashode.dobare vared kon");
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (!string.Equals(vo2, "Back"));

                    }
                    if(!string.Equals(vo,"Category") && !string.Equals(vo,"Cart") && !string.Equals(vo, "Exit"))
                    {
                        throw new Exception("voroodi dorost vared konid");
                    }
                   // Console.WriteLine("AddProductCategory\nFilterByPrice\nShowSupply ");
                 //   vo1 = Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (!string.Equals(vo, "Exit"));
         
            
        }
    }
}
