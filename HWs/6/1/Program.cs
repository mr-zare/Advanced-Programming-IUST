using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace ConsoleApp1
{
    static class string1
    {
        public static bool Codemelli(this string i)
        {
            int a = int.Parse(i[0].ToString());
            int b= (int.Parse(i[9].ToString())) * 10 + (int.Parse(i[8].ToString())) * 9 + (int.Parse(i[7].ToString())) * 8+ (int.Parse(i[6].ToString())) * 7+
                (int.Parse(i[5].ToString())) * 6 + (int.Parse(i[4].ToString())) * 5+ (int.Parse(i[3].ToString())) * 4+
                (int.Parse(i[2].ToString())) * 3 + (int.Parse(i[1].ToString())) * 2 ; 
            int c = b % 11;
            if((int.Parse(i[9].ToString())) == (int.Parse(i[8].ToString())) && (int.Parse(i[7].ToString())) == (int.Parse(i[6].ToString())) &&
                (int.Parse(i[5].ToString())) == (int.Parse(i[4].ToString())) && (int.Parse(i[3].ToString())) == (int.Parse(i[2].ToString())) &&
                (int.Parse(i[1].ToString())) == (int.Parse(i[0].ToString())))
            {
                return false;
            }
            if(c==0 && a==c)
            {
                return true;
            }
            if(c==1 && a==1)
            {
                return true;
            }
            if(c>1 && (11-c)==a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        enum dastresi { Admin,User,Exit};

        class Seller
        {
            string namkarbari;
            static string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex re = new Regex(pattern,RegexOptions.IgnoreCase);
            //bayad format namkarbari az noe email bashe alabate kamel shode ast//
            string pass;
            public Seller(string nam,string p,List<string> a)
            {
                int t = a.Count;
                pass = a[t - 3];
                if(re.IsMatch(nam))
                {
                    namkarbari = nam;
                }
                else
                {
                    throw new Exception("format email dorost nis");
                }
                if(p!=pass)
                {
                    throw new Exception("ramz vorood admin eshtebahe");
                }
            }

            public bool checkpass(string pas)
            {
                if(pass==pas)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void changepass(string ramz,StreamWriter a, int b)
            {
                DateTime c = DateTime.Now;
                pass = ramz;
                a.WriteLine(pass);
                a.WriteLine(b);
                a.WriteLine(c);
                a.Close();
            }
        }
        class Student
        {
            string nam;
            int shomare;
            public Student(string a, int b)
            {
                nam = a;
                //farakhani method check shomare va ijad khata darsoorat adam hamkhani//
                string pat = @"^9[0-9]{7}$";
                Regex reg = new Regex(pat);
                if (reg.IsMatch((b.ToString())))
                {
                    shomare = b;
                }
                else
                {
                    throw new Exception("format shomare daneshjooyi ghalate");
                }
                string f1;
                List<string> f2 = new List<string>();
                StreamReader f3 = new StreamReader("CustomersInfo.txt");
                while ((f1 = f3.ReadLine()) != null)
                {
                    f2.Add(f1);
                }
                f3.Close();
                StreamWriter m = new StreamWriter("CustomersInfo.txt");
                for(int i=0;i<f2.Count;i++)
                {
                    m.WriteLine(f2[i]);
                }
                Save(m);
                m.Close();
                //method baraye check karadan shomare bala neveshte//
            }
            public void Save(StreamWriter file1)
            {
                file1.WriteLine("Student");
                file1.WriteLine(nam);
                file1.WriteLine(shomare);
                file1.Close();
                //method save etelaat kamel she//
            }
        }
        class Teacher
        {
            string nam;
            string moasese;
            public Teacher(string a ,string b)
            {
                nam = a;
                moasese = b;
                string f1;
                List<string> f2 = new List<string>();
                StreamReader f3 = new StreamReader("CustomersInfo.txt");
                while ((f1 = f3.ReadLine()) != null)
                {
                    f2.Add(f1);
                }
                f3.Close();
                StreamWriter m = new StreamWriter("CustomersInfo.txt");
                for (int i = 0; i < f2.Count; i++)
                {
                    m.WriteLine(f2[i]);
                }
                Save(m);
                m.Close();
            }

            public void Save(StreamWriter file1)
            {
                file1.WriteLine("Teacher");
                file1.WriteLine(nam);
                file1.WriteLine(moasese);
                file1.Close();
            }
        }
        
        class Customer
        {
            string nam;
            string codemeli;
            //codemeli check she//
            public Customer(string a,string b)
            {
                nam = a;
                bool m1 = b.Codemelli();
                if (m1 == true)
                {
                    codemeli =b;
                }
                else
                {
                    throw new Exception("code melli nadoroste");
                }
                string f1;
                List<string> f2 = new List<string>();
                StreamReader f3 = new StreamReader("CustomersInfo.txt");
                while ((f1 = f3.ReadLine()) != null)
                {
                    f2.Add(f1);
                }
                f3.Close();
                StreamWriter m = new StreamWriter("CustomersInfo.txt");
                for (int i = 0; i < f2.Count; i++)
                {
                    m.WriteLine(f2[i]);
                }
                Save(m);
                m.Close();
            }
            public void Save(StreamWriter file1)
            {
                file1.WriteLine("Customers");
                file1.WriteLine(nam);
                file1.WriteLine(codemeli);
                file1.Close();
            }

        }
        class Media
        {
            public string name;
            public double price;
            public int id;
            public Media( string a,double b,int c)
            {
                name = a;
                price = b;
                id = c;
            }
            public virtual void add(StreamWriter a)
            {
                a.WriteLine(name);
                a.WriteLine(price);
                a.WriteLine(id);
                a.Close();
            }
        }
        class Videos:Media
        {
            public int min;
            public int tcd;
            public Videos(string nam, double fee, int idd,int zaman,int tedad):base(nam,fee,idd)
            {
                min = zaman;
                tcd = tedad;
                double m = maliaat(zaman, tedad);
                m = 1 + m;
                price = price * m;
            }
            public double maliaat(int m,int t)
            {
                double b = 0.03 * t + (int)(m / 60) * 0.05;
                return b;
            }
            public override void add(StreamWriter a)
            {
                a.WriteLine("Videos");
                a.WriteLine(name);
                a.WriteLine(price);
                a.WriteLine(id);
                a.WriteLine(min);
                a.WriteLine(tcd);
                a.Close();

            }
        }

        class Books:Media
        {
            public string writer;
            public string nasher;
            public Books(string nam, double fee, int idd, string nevis, string nash) : base(nam, fee, idd)
            {
                double b1 = maliat(fee);
                price = b1;
                writer = nevis;
                nasher = nash;
            }
            public double maliat(double a)
            {
                double b;
                b= a * 1.10;
                return b;
            }
            public override void add(StreamWriter a)
            {
                a.WriteLine("Books");
                a.WriteLine(name);
                a.WriteLine(price);
                a.WriteLine(id);
                a.WriteLine(writer);
                a.WriteLine(nasher);
                a.Close();
            }
        }
        class Magazines:Media
        {
            public string nasher;
            public int tsafhe;
            public double maliaat(int s)
            {
                if(s<=0)
                {
                    new Exception("tsafhe nemitoone manfi ya bashe");
                }
                double m = 1;
                if(s>=1 && s<=20)
                {
                    m = 1.02;
                }
                else if(s>=21 && s<=50)
                {
                    m = 1.03;
                }
                
                else if (s>50)
                {
                    m = 1.05;
                }
                return m;
            }
            public Magazines(string nam, double fee, int idd, string nash, int t) : base(nam,fee,idd)
            {
                nasher = nash;
                tsafhe = t;
                double m = maliaat(t);
                price = price * m;
            }
            public override void add(StreamWriter a)
            {
                a.WriteLine("Magazines");
                a.WriteLine(name);
                a.WriteLine(price);
                a.WriteLine(id);
                a.WriteLine(nasher);
                a.WriteLine(tsafhe);
                a.Close();
            }
        }

        class Library
        {
           public void add(Media a)
           {
                StreamReader b1 = new StreamReader("kala.txt");
                string line;
                List<string> c = new List<string>();
                while((line=b1.ReadLine())!=null)
                {
                    c.Add(line);
                }
                b1.Close();
                StreamWriter b = new StreamWriter("kala.txt");
                for (int i = 0; i < c.Count; i++)
                {
                    b.WriteLine(c[i]);
                }
                a.add(b);
                b.Close();
            }
            
            public void delete(int adad,List<Media> a)
            {
                int flag = 0;
                for(int i=0;i<a.Count;i++)
                {
                    if(a[i].id==adad)
                    {
                        a.Remove(a[i]);
                        flag = 1;
                    }
                }
                StreamWriter w = new StreamWriter("kala.txt");
                if (flag == 1)
                {
   
                    for (int i = 0; i < a.Count; i++)
                    {
                        a[i].add(w);
                    }
                    w.Close();
                }
                else
                {
                    throw new Exception("kala ba in id  dar beyn  mahsool ha mojood nis");
                }
            }
            public void search(int adad, StreamReader a)
            {

                string line;
                int count = 0;
                int f = 0;
                while ((line = a.ReadLine()) != null)
                {
                    count++;
                }
                int q = 0;
                string[] e = new string[6];
                StreamReader a1 = new StreamReader("kala.txt");
                for (int i = 0; i < count / 6; i++)
                {
                    if (f == 0)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            e[j] = a1.ReadLine();
                        }
                    }
                    q = int.Parse(e[3]);
                    if (q == adad && f==0)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.WriteLine(e[j]);
                            f = 1;
                        }
                    }
                }
                if (f == 0)
                {
                    throw new Exception("chenin id mojood nis");
                }
            }
        }
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime past;
            string email, pass,ramz;
            string name,writer,nasherbook,nashermagazine;
            int id,time,tedadcd,tsafhe,flag=0;
            int searchid;
            int hazfikala;
            double price;
            string vo,line;
            string namek, namekt, esmm,  namekc;
            int adad,t,count=0;
            string code;
            StreamReader g;
            Seller e;
            List<Library> list=new List<Library>();
            List<Media> media = new List<Media>();
            string alaki;
            List<string> alaki1 = new List<string>();
            StreamReader alaki2 = new StreamReader("kala.txt");
            List<string> password;
            while((alaki=alaki2.ReadLine())!=null)
            {
                alaki1.Add(alaki);
            }
            alaki2.Close();
            for(int i=0;i<alaki1.Count;i++)
            {
                if(i%6==0)
                {
                    string bb = alaki1[i];
                    if(bb=="Books")
                    {
                        Books ww = new Books(alaki1[i + 1], Double.Parse(alaki1[i + 2]), int.Parse(alaki1[i + 3])
                            , alaki1[i + 4], alaki1[i + 5]);
                        media.Add(ww);
                    }
                    if (bb == "Videos")
                    {
                        Videos ww1 = new Videos(alaki1[i + 1], Double.Parse(alaki1[i + 2]), int.Parse(alaki1[i + 3])
                            ,int.Parse(alaki1[i + 4]),int.Parse(alaki1[i + 5]));
                        media.Add(ww1);
                    }
                    if (bb == "Magazines")
                    {
                        Magazines ww2= new Magazines(alaki1[i + 1], Double.Parse(alaki1[i + 2]), int.Parse(alaki1[i + 3])
                            , alaki1[i + 4],int.Parse(alaki1[i + 5]));
                        media.Add(ww2);
                    }
                }
            }
            List<Media> sabad = new List<Media>();
            Books book;
            Magazines magazine;
            Videos video;
            Library lib;
            string vo1;
            string vo2,vo3,vo4,vo5,vo6;
            bool check;
            StreamWriter p;
            StreamReader p1;
            List<string> p2;
            string p3;
            List<string> f1;
            string f2;
            StreamReader f3;
            StreamReader x;
            int ttaviz=1;
            StreamReader passr = new StreamReader("pass.txt");
            password = new List<string>();
            string linep;
            while((linep=passr.ReadLine())!=null)
            {
                password.Add(linep);
            }
            passr.Close();
            StreamWriter passw;
            //passw.WriteLine("MyShop1234$");
            //passw.WriteLine(ttaviz);
            //passw.WriteLine(now);
            //passw.Close();
            //past = now;
            double majmoefee = 0;
            Random shansi;
            int n;
            double takhfif=1.00;
            int passcount;
            int flag4= 0,flag1 = 0,flag3 = 0;
            do
            {
                try
                {
                    Console.WriteLine("Admin or User or Exit?");
                    dastresi a = (dastresi)Enum.Parse(typeof(dastresi), Console.ReadLine());
                    if (a == dastresi.Admin)
                    {
                        Console.WriteLine("email ra vared konid");
                        email = Console.ReadLine();
                        //email check neveshte she//
                        Console.WriteLine("password ra vared konid");
                        pass = Console.ReadLine();
                        e = new Seller(email, pass,password);
                        check = e.checkpass(pass);
                        if (check==true)
                        {
                            do
                            {

                                try
                                {
                                    Console.WriteLine("ADD\nDELETE\nSEARCH\nSHOWCUSTOMERS\nCHANGEPASS\nEXIT");
                                    vo1 = Console.ReadLine();
                                    lib = new Library();
                                    if (vo1 == "ADD")
                                    {
                                        p2 = new List<string>();
                                        if (File.Exists("kala.txt")==true)
                                        {
                                            p1 = new StreamReader("kala.txt");
                                            while ((p3 = p1.ReadLine()) != null)
                                            {
                                                p2.Add(p3);
                                            }
                                            p1.Close();
                                        }
                                        p = new StreamWriter("kala.txt");
                                        for(int i=0;i<p2.Count;i++)
                                        {
                                            p.WriteLine(p2[i]);
                                        }
                                        p.Close();
                                        do
                                        {
                                            try
                                            {
                                                Console.WriteLine("entekhab kon:\nBooks\nVideos\nMagazines\nEXIT");
                                                vo2 = Console.ReadLine();
                                                if (vo2 == "Books")
                                                {
                                                    Console.WriteLine("nam e ketab:");
                                                    name = Console.ReadLine();
                                                    Console.WriteLine("qeimat e ketab:");
                                                    price =double.Parse(Console.ReadLine());
                                                    Console.WriteLine("id e ketab:");
                                                    id=int.Parse(Console.ReadLine());
                                                    Console.WriteLine("nevisande e ketab:");
                                                    writer = Console.ReadLine();
                                                    Console.WriteLine("nasher e ketab:");
                                                    nasherbook= Console.ReadLine();
                                                    book = new Books(name, price, id, writer, nasherbook);
                                                    lib.add(book);
                                                    list.Add(lib);
                                                    media.Add(book);
                                                }
                                                if (vo2 == "Videos")
                                                {
                                                    Console.WriteLine("nam e video:");
                                                    name = Console.ReadLine();
                                                    Console.WriteLine("qeimat e video:");
                                                    price = double.Parse(Console.ReadLine());
                                                    Console.WriteLine("id e video:");
                                                    id = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("time e video:");
                                                    time=int.Parse(Console.ReadLine());
                                                    Console.WriteLine("tedadcd e video:");
                                                    tedadcd =int.Parse(Console.ReadLine());
                                                    video = new Videos(name, price, id, time, tedadcd);
                                                    lib.add(video);
                                                    list.Add(lib);
                                                    media.Add(video);
                                                }
                                                if (vo2 == "Magazines")
                                                {
                                                    Console.WriteLine("nam e majale:");
                                                    name = Console.ReadLine();
                                                    Console.WriteLine("qeimat e majale:");
                                                    price = double.Parse(Console.ReadLine());
                                                    Console.WriteLine("id e majale:");
                                                    id = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("nasher e majale:");
                                                    nashermagazine = Console.ReadLine();
                                                    Console.WriteLine("tedad safhe e majale:");
                                                    tsafhe=int.Parse(Console.ReadLine());
                                                    magazine = new Magazines(name, price, id, nashermagazine, tsafhe);
                                                    lib.add(magazine);
                                                    list.Add(lib);
                                                    media.Add(magazine);
                                                }
                                                if (vo2 == "EXIT")
                                                {
                                                    break;
                                                }
                                                if (vo2 != "Books" && vo2 != "Videos" && vo2 != "Magazines" && vo2!="EXIT")
                                                {
                                                    throw new Exception("voroodi beyn 3ta halat kala nis dobare entekhab kon");
                                                }
                                            }
                                            catch(Exception y1)
                                            {
                                                Console.WriteLine(y1.Message);
                                            }
                                        } while (1 == 1);
                                    }
                                    if (vo1 == "SEARCH")
                                    {
                                        Console.WriteLine("id mahsooli ke mikhayn search konid vared konid:");
                                        searchid = int.Parse(Console.ReadLine());
                                        x = new StreamReader("kala.txt");   
                                        lib.search(searchid, x);
                                        x.Close();
                                    }
                                    if (vo1 == "SHOWCUSTOMERS")
                                    {
                                        g = new StreamReader("CustomersInfo.txt");
                                        string lines;
                                        while((lines=g.ReadLine())!=null)
                                        {
                                            Console.WriteLine(lines);
                                        }
                                        g.Close();
                                    }
                                    if (vo1 == "CHANGEPASS")
                                    {
                                        passcount = password.Count;
                                        past =DateTime.Parse(password[passcount - 1]);
                                        Console.WriteLine("time qabli:{0} tedadbar taviz:{1}", past,ttaviz);
                                        now = DateTime.Now;
                                        Console.WriteLine("ramz e jadid ro vared kon");
                                        ramz = Console.ReadLine();
                                        passw = new StreamWriter("pass.txt");
                                        for(int i=0;i<password.Count;i++)
                                        {
                                            passw.WriteLine(password[i]);
                                        }
                                        ttaviz++;
                                        e.changepass(ramz,passw,ttaviz);
                                        passw.Close();
                                        
                                    }
                                    if (vo1 == "DELETE")
                                    {
                                        Console.WriteLine("id kala hazfi ro vared kon");
                                        hazfikala = int.Parse(Console.ReadLine());
                                        lib.delete(hazfikala, media);
                                    }
                                    if (vo1 == "EXIT")
                                    {
                                        
                                        break;
                                    }
                                    if (vo1 != "ADD" && vo1 != "DELETE" && vo1 != "SEARCH" &&
                                        vo1 != "CHANGEPASS" && vo1 != "SHOWCUSTOMERS" && vo1 != "EXIT")
                                    {
                                        throw new Exception("voroodi dade shode beyn gozine ha nis.dobare vared konid");
                                    }
                                }
                                catch(Exception y)
                                {
                                    Console.WriteLine(y.Message);
                                }
                            } while (1 == 1);
                        }
                        else
                        {
                            throw new Exception("password nadoroste:|");
                        }
                    }
                    else if (a == dastresi.User)
                    {   
                        do
                        {
                            try
                            {
                                Console.WriteLine("Student \nTeacher\nCustomer");
                                vo = Console.ReadLine();
                                if (File.Exists("CustomersInfo.txt"))
                                {
                                    f1 = new List<string>();
                                    f3 = new StreamReader("CustomersInfo.txt");
                                    while((f2=f3.ReadLine())!=null)
                                    {
                                        f1.Add(f2);
                                    }
                                    f3.Close();
                                }
                                if (vo == "Student")
                                {
                                    Console.WriteLine("name vared konid");
                                    namek = Console.ReadLine();
                                    Console.WriteLine("shomareto vared konid");
                                    adad = int.Parse(Console.ReadLine());
                                    if (adad / 10000000 != 9)
                                    {
                                        new Exception("shomare daneshamoozi/daneshjooii bayad 8raqami va ba 9 shorooe she");
                                    }
                                    Student q2 = new Student(namek, adad);
                                    Console.WriteLine("tedad mahsool ra vared konid");
                                    t = int.Parse(Console.ReadLine());
                                    do
                                    {

                                        Console.WriteLine("SELECT\nEDIT\nBUY\nCHANCE\nEXIT");
                                        vo3 = Console.ReadLine();
                                        takhfif = 0.80;
                                        if (vo3 == "SELECT")
                                        {
                                            count = 0;
                                            x = new StreamReader("kala.txt");
                                            while ((line = x.ReadLine()) != null)
                                            {
                                                count++;
                                            }
                                            x.Close();
                                            x = new StreamReader("kala.txt");
                                            for (int i = 0; i < count; i++)
                                            {
                                                line = x.ReadLine();
                                                if (i % 6 == 1)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                            }
                                            x.Close();
                                            x = new StreamReader("kala.txt");
                                            Console.WriteLine("nam kala ra vared konid:");
                                            vo4 = Console.ReadLine();
                                            flag = 0;
                                            for (int i = 0; i < count; i++)
                                            {
                                                line = x.ReadLine();
                                                if (i % 6 == 1)
                                                {
                                                    if (line == vo4)
                                                    {
                                                        flag = 1;
                                                        for (int j = 0; j < count / 6; j++)
                                                        {
                                                            if (media[j].name == vo4)
                                                            {
                                                                if (sabad.Count < 20)
                                                                {
                                                                    sabad.Add(media[j]);
                                                                }
                                                                else
                                                                {
                                                                    throw new Exception("tedad mahsool bishtar az 2 ta nemitone bashe");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (flag == 0)
                                            {
                                                throw new Exception("nam kala vared shode mojood nis");
                                            }
                                            x.Close();
                                        }
                                        if (vo3 == "BUY")
                                        {
                                            foreach (Media i in sabad)
                                            {
                                                majmoefee = majmoefee + i.price;
                                            }
                                            majmoefee = majmoefee * takhfif;
                                            Console.WriteLine("jam qeimat: {0}", majmoefee);
                                            Console.WriteLine("OK?");
                                            vo5 = Console.ReadLine();
                                            if (vo5 == "OK")
                                            {
                                                Console.WriteLine("kharid anjam shod");
                                                sabad = new List<Media>();
                                            }

                                        }
                                        if (vo3 == "EDIT")
                                        {
                                            foreach (Media i in sabad)
                                            {
                                                Console.WriteLine(i.name);
                                                Console.WriteLine(i.price);
                                            }
                                            vo6 = Console.ReadLine();
                                            foreach (Media i in sabad)
                                            {
                                                if (i.name == vo6)
                                                {
                                                    sabad.Remove(i);
                                                    Console.WriteLine("OK");
                                                    break;
                                                }
                                            }
                                        }
                                        if (vo3 == "CHANCE")
                                        {
                                            shansi = new Random();
                                            n = shansi.Next(1, 10);
                                            if (n == 1)
                                            {
                                                takhfif = takhfif - 0.00;
                                            }
                                            if (n == 2)
                                            {
                                                takhfif = takhfif - 0.02;
                                            }
                                            if (n == 3)
                                            {
                                                takhfif = takhfif - 0.03;
                                            }
                                            if (n == 4)
                                            {
                                                takhfif = takhfif - 0.05;
                                            }
                                            if (n == 5)
                                            {
                                                takhfif = takhfif - 0.07;
                                            }
                                            if (n == 6)
                                            {
                                                takhfif = takhfif - 0.10;
                                            }
                                            if (n == 7)
                                            {
                                                takhfif = takhfif - 0.15;
                                            }
                                            if (n == 8)
                                            {
                                                takhfif = takhfif - 0.25;
                                            }
                                            if (n == 9)
                                            {
                                                takhfif = takhfif - 0.30;
                                            }
                                            Console.WriteLine(takhfif);

                                        }
                                        if (vo3 == "EXIT")
                                        {
                                            flag4= 1;
                                            break;
                                        }
                                        if (vo3 != "EXIT" && vo3 != "SELECT" && vo3 != "BUY" && vo3 != "EDIT" && vo3 != "CHANCE")
                                        {
                                            throw new Exception("voroodi dakhel gozine ha nis");
                                        }
                                    } while (flag4==0);
                                }
                                if (vo == "Teacher")
                                {
                                    Console.WriteLine("nam karbari teacher ro vared kon");
                                    namekt = Console.ReadLine();
                                    Console.WriteLine("nam moasse ro vared kon");
                                    esmm = Console.ReadLine();
                                    Teacher q1 = new Teacher(namekt, esmm);
                                    Console.WriteLine("tedad mahsool ra vared konid");
                                    t = int.Parse(Console.ReadLine());
                                    if (t >= 3)
                                    {
                                        takhfif = 0.85;
                                    }
                                    do
                                    {


                                        Console.WriteLine("SELECT\nEDIT\nBUY\nCHANCE\nEXIT");
                                        vo3 = Console.ReadLine();

                                        if (vo3 == "SELECT")
                                        {
                                            count = 0;
                                            x = new StreamReader("kala.txt");
                                            while ((line = x.ReadLine()) != null)
                                            {
                                                count++;
                                            }
                                            x.Close();
                                            x = new StreamReader("kala.txt");
                                            for (int i = 0; i < count; i++)
                                            {
                                                line = x.ReadLine();
                                                if (i % 6 == 1)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                            }
                                            x.Close();
                                            x = new StreamReader("kala.txt");
                                            Console.WriteLine("nam kala ra vared konid:");
                                            vo4 = Console.ReadLine();
                                            flag = 0;
                                            for (int i = 0; i < count; i++)
                                            {
                                                line = x.ReadLine();
                                                if (i % 6 == 1)
                                                {
                                                    if (line == vo4)
                                                    {
                                                        flag = 1;
                                                        for (int j = 0; j < count / 6; j++)
                                                        {
                                                            if (media[j].name == vo4)
                                                            {
                                                                if (sabad.Count < 20)
                                                                {
                                                                    sabad.Add(media[j]);
                                                                }
                                                                else
                                                                {
                                                                    throw new Exception("tedad mahsool bishtar az 2 ta nemitone bashe");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            x.Close();
                                            if (flag == 0)
                                            {
                                                throw new Exception("nam kala vared shode mojood nis");
                                            }
                                        }
                                        if (vo3 == "BUY")
                                        {
                                            foreach (Media i in sabad)
                                            {
                                                majmoefee = majmoefee + i.price;
                                            }
                                            majmoefee = majmoefee * takhfif;
                                            Console.WriteLine("jam qeimat: {0}", majmoefee);
                                            Console.WriteLine("OK?");
                                            vo5 = Console.ReadLine();
                                            if (vo5 == "OK")
                                            {
                                                Console.WriteLine("kharid anjam shod");
                                                sabad = new List<Media>();
                                            }

                                        }
                                        if (vo3 == "EDIT")
                                        {
                                            foreach (Media i in sabad)
                                            {
                                                Console.WriteLine(i.name);
                                            }
                                            vo6 = Console.ReadLine();
                                            foreach (Media i in sabad)
                                            {
                                                if (i.name == vo6)
                                                {
                                                    sabad.Remove(i);
                                                }
                                                Console.WriteLine("KALA pak shod");
                                                break;
                                            }
                                        }
                                        if (vo3 == "CHANCE")
                                        {
                                            shansi = new Random();
                                            n = shansi.Next(1, 10);
                                            if (n == 1)
                                            {
                                                takhfif = takhfif - 0.00;
                                            }
                                            if (n == 2)
                                            {
                                                takhfif = takhfif - 0.02;
                                            }
                                            if (n == 3)
                                            {
                                                takhfif = takhfif - 0.03;
                                            }
                                            if (n == 4)
                                            {
                                                takhfif = takhfif - 0.05;
                                            }
                                            if (n == 5)
                                            {
                                                takhfif = takhfif - 0.07;
                                            }
                                            if (n == 6)
                                            {
                                                takhfif = takhfif - 0.10;
                                            }
                                            if (n == 7)
                                            {
                                                takhfif = takhfif - 0.15;
                                            }
                                            if (n == 8)
                                            {
                                                takhfif = takhfif - 0.25;
                                            }
                                            if (n == 9)
                                            {
                                                takhfif = takhfif - 0.30;
                                            }
                                        }
                                        if (vo3 == "EXIT")
                                        {
                                            flag1 = 1;
                                            break;
                                        }
                                        if (vo3 != "EXIT" && vo3 != "SELECT" && vo3 != "BUY" && vo3 != "EDIT" && vo3 != "CHANCE")
                                        {
                                            throw new Exception("voroodi dakhel gozine ha nis");
                                        }
                                    } while (flag1==0);
                                }
                                if (vo == "Customer")
                                {
                                    Console.WriteLine("name  karbari customer vared she");
                                    namekc = Console.ReadLine();
                                    Console.WriteLine("code meli vared she");
                                    code = Console.ReadLine();
                                    Customer q = new Customer(namekc, code);
                                    Console.WriteLine("tedad mahsool ra vared konid");
                                    t = int.Parse(Console.ReadLine());
                                    if (t > 5)
                                    {
                                        takhfif = 0.95;
                                    }
                                    do
                                    {


                                        Console.WriteLine("SELECT\nEDIT\nBUY\nCHANCE\nEXIT");
                                        vo3 = Console.ReadLine();

                                        if (vo3 == "SELECT")
                                        {
                                            count = 0;
                                            x = new StreamReader("kala.txt");
                                            while ((line = x.ReadLine()) != null)
                                            {
                                                count++;
                                            }
                                            x.Close();
                                            x = new StreamReader("kala.txt");
                                            for (int i = 0; i < count; i++)
                                            {
                                                line = x.ReadLine();
                                                if (i % 6 == 1)
                                                {
                                                    Console.WriteLine(line);
                                                }
                                            }
                                            x.Close();
                                            x = new StreamReader("kala.txt");
                                            Console.WriteLine("nam kala ra vared konid:");
                                            vo4 = Console.ReadLine();
                                            flag = 0;
                                            for (int i = 0; i < count; i++)
                                            {
                                                line = x.ReadLine();
                                                if (i % 6 == 1)
                                                {
                                                    if (line == vo4)
                                                    {
                                                        flag = 1;
                                                        for (int j = 0; j < count / 6; j++)
                                                        {
                                                            if (media[j].name == vo4)
                                                            {
                                                                if (sabad.Count < 20)
                                                                {
                                                                    sabad.Add(media[j]);
                                                                }
                                                                else
                                                                {
                                                                    throw new Exception("tedad mahsool bishtar az 20 ta nemitone bashe");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            x.Close();
                                            if (flag == 0)
                                            {
                                                throw new Exception("nam kala vared shode mojood nis");
                                            }
                                        }
                                        if (vo3 == "BUY")
                                        {
                                            foreach (Media i in sabad)
                                            {
                                                majmoefee = majmoefee + i.price;
                                            }
                                            majmoefee = majmoefee * takhfif;
                                            Console.WriteLine("jam qeimat: {0}", majmoefee);
                                            Console.WriteLine("OK?");
                                            vo5 = Console.ReadLine();
                                            if (vo5 == "OK")
                                            {
                                                Console.WriteLine("kharid anjam shod");
                                                sabad = new List<Media>();
                                            }

                                        }
                                        if (vo3 == "EDIT")
                                        {
                                            foreach (Media i in sabad)
                                            {
                                                Console.WriteLine(i.name);
                                            }
                                            vo6 = Console.ReadLine();
                                            foreach (Media i in sabad)
                                            {
                                                if (i.name == vo6)
                                                {
                                                    sabad.Remove(i);
                                                }
                                            }
                                        }
                                        if (vo3 == "CHANCE")
                                        {
                                            shansi = new Random();
                                            n = shansi.Next(1, 10);
                                            if (n == 1)
                                            {
                                                takhfif = takhfif - 0.00;
                                            }
                                            if (n == 2)
                                            {
                                                takhfif = takhfif - 0.02;
                                            }
                                            if (n == 3)
                                            {
                                                takhfif = takhfif - 0.03;
                                            }
                                            if (n == 4)
                                            {
                                                takhfif = takhfif - 0.05;
                                            }
                                            if (n == 5)
                                            {
                                                takhfif = takhfif - 0.07;
                                            }
                                            if (n == 6)
                                            {
                                                takhfif = takhfif - 0.10;
                                            }
                                            if (n == 7)
                                            {
                                                takhfif = takhfif - 0.15;
                                            }
                                            if (n == 8)
                                            {
                                                takhfif = takhfif - 0.25;
                                            }
                                            if (n == 9)
                                            {
                                                takhfif = takhfif - 0.30;
                                            }
                                        }
                                        if (vo3 == "EXIT")
                                        {
                                            flag3 = 1;
                                            break;
                                        }
                                        if (vo3 != "EXIT" && vo3 != "SELECT" && vo3 != "BUY" && vo3 != "EDIT" && vo3 != "CHANCE")
                                        {
                                            throw new Exception("voroodi dakhel gozine ha nis");
                                        }

                                    } while (flag3==0);
                                if (vo == "Exit")
                                    {
                                        break;
                                    }
                                    if (vo != "Exit" && vo != "Student" && vo != "Teacher" && vo != "Customer")
                                    {
                                        throw new Exception("voroodi ro dorost vared kon");
                                    }
                                }
                            }
                            catch(Exception t1)
                            {
                                Console.WriteLine(t1.Message);
                                vo = Console.ReadLine();
                            }
                        }while (1 == 1) ;
                    }
                    else if(a==dastresi.Exit)
                    {
                        break;
                    }
                    else if (a != dastresi.User && a != dastresi.Admin)
                    {
                        throw new Exception("dorost voroodi vared kon.");

                    }
                }catch(Exception a)
                {
                    Console.WriteLine(a.Message);
                }
            } while (1 == 1);
        }
    }
}
