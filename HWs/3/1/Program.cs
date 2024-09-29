using System;
using System.IO;
using System.Drawing;
namespace ConsoleApp1
{
    class Program
    {
        public enum search {IT=21,ImageProcessing=27,IOT=45,AI=36,Database=55,Web=83,Exit=0 }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int tIt = 0, tip = 0, tiot = 0, tai = 0, tdb = 0, tweb = 0;
            string a1, b, c, vo = "hel", pass, check, p1, p2;
            bool a;
            search[] input;
            StreamReader file1;
            StreamWriter file2;
            StreamWriter file3;
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Admin or User");

                        a1 = Console.ReadLine();
                        a1 = a1.ToLower();
                        if (!string.Equals(a1, "admin") && !string.Equals(a1, "user"))
                        {
                            throw new Exception("bayad user ya admin bashe");
                        }
                    }
                    catch (Exception w)
                    {
                        Console.WriteLine(w.Message);
                        continue;
                    }
                    break;
                } while (1 == 1);
                if (string.Equals(a1, "admin"))
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("lotfan ramz vorood ra vared konid");
                            b = Console.ReadLine();
                            a = File.Exists("password.txt");
                            if (a == true)
                            {
                                file1 = new StreamReader("Password.txt");
                                c = file1.ReadLine();

                                if (c != b)
                                {
                                    while (c != b)
                                    {
                                        Console.WriteLine("ramz vared shode ba ramz zakhire hamkhani nadare.lotfan dobare talash konid");
                                        b = Console.ReadLine();
                                    }
                                }
                                if (c == b)
                                {
                                    
                                    file1.Close();
                                    do
                                    {
                                        Console.WriteLine("Count");
                                        Console.WriteLine("ChangePassword");
                                        Console.WriteLine("Exit");
                                        vo = Console.ReadLine();
                                        if (vo == "Count")
                                        {
                                            Console.WriteLine("21 IT {0}", tIt);
                                            Console.WriteLine("27 ImageProcessing {0}", tip);
                                            Console.WriteLine("45 IOT {0}", tiot);
                                            Console.WriteLine("36 AI {0}", tai);
                                            Console.WriteLine("55 DataBase {0}", tdb);
                                            Console.WriteLine("83 Web {0}", tweb);
                                        }
                                        if (vo == "ChangePassword")
                                        {
                                            Console.WriteLine("password qabl ra vared konid");
                                            pass = Console.ReadLine();
                                            file1 =new StreamReader("Password.txt");
                                            check = file1.ReadLine();
                                            file1.Close();
                                            if (check == pass)
                                            {
                                                Console.WriteLine("ramz jadid va tekraresh ro vared kon:");
                                                p1 = Console.ReadLine();
                                                p2 = Console.ReadLine();
                                                while (p1 != p2)
                                                {
                                                    Console.WriteLine("do ramz vorodi yeksan nist.dobare vared konid");
                                                    p1 = Console.ReadLine();
                                                    p2 = Console.ReadLine();
                                                }

                                                file2 = new StreamWriter("password.txt");
                                                file2.WriteLine(p1);
                                                file2.Close();
                                            }
                                            if (vo != "ChangePassword" && vo != "Count" && vo != "Exit")
                                            {
                                                new Exception("in dastoor mojood nis.bar asas dastooratmojod voroodi dahid");

                                            }
                                        }
                                    } while (!string.Equals(vo, "Exit"));
                                }
                            }
                            else
                            {
                                file3 = new StreamWriter("password.txt");
                                while (!string.Equals(b, "Hello@P"))
                                {
                                    b = Console.ReadLine();
                                }
                                file3.WriteLine(b);
                                file3.Close();
                                Console.WriteLine("Count");
                                Console.WriteLine("ChangePassword");
                                Console.WriteLine("Exit");
                                do
                                {
                                    vo = Console.ReadLine();
                                    if (vo == "Count")
                                    {
                                        Console.WriteLine("21 IT {0}", tIt);
                                        Console.WriteLine("27 ImageProcessing {0}", tip);
                                        Console.WriteLine("45 IOT {0}", tiot);
                                        Console.WriteLine("36 AI {0}", tai);
                                        Console.WriteLine("55 DataBase {0}", tdb);
                                        Console.WriteLine("83 Web {0}", tweb);
                                    }
                                    if (vo == "ChangePassword")
                                    {
                                        Console.WriteLine("password qabl ra vared konid");
                                        pass = Console.ReadLine();
                                        if (string.Equals(pass, "Hello@P"))
                                        {
                                            Console.WriteLine("ramz jadid va tekraresh ro vared kon:");
                                            p1 = Console.ReadLine();
                                            p2 = Console.ReadLine();
                                            while (p1 != p2)
                                            {
                                                Console.WriteLine("do ramz vorodi yeksan nist.dobare vared konid");
                                                p1 = Console.ReadLine();
                                                p2 = Console.ReadLine();
                                            }
                                            file2 = new StreamWriter("password.txt");
                                            file2.WriteLine(p1);
                                            file2.Close();


                                        }
                                        if (vo != "ChangePassword" && vo != "Count" && vo != "Exit")
                                        {
                                            new Exception("in dastoor mojood nis.bar asas dastooratmojod voroodi dahid");

                                        }
                                    }
                                } while (!string.Equals(vo, "exit"));

                            }
                        }

                        catch (Exception w1)
                        {
                            Console.WriteLine(w1.Message);
                        }
                    }
                    while (!string.Equals(vo,"Exit"));
                }
                do
                {
                    try
                    {
                        int i = 0;
                        if (string.Equals(a1, "user"))
                        {
                            input = new search[100];
                            input[i] = (search)Enum.Parse(typeof(search), Console.ReadLine().ToLower(),true);
                            i++;
                            while (input[i - 1] != search.Exit)
                            {
                                if (input[i - 1] == search.Web)
                                {
                                    tweb++;
                                    Console.WriteLine("web development about build maintanance of website ");
                                }
                                if (input[i - 1] == search.AI)
                                {
                                    Console.WriteLine("about simulation human intelligent,machine that programming for think ");
                                    tai++;
                                }
                                if (input[i - 1] == search.Database)
                                {
                                    Console.WriteLine("collection of structured information,data,etc.. ");
                                    tdb++;
                                }
                                if (input[i - 1] == search.IOT)
                                {
                                    Console.WriteLine("the internet of things," +
                                        "internet-connected objects that are able to collect and transfer data over a wirless network ");
                                    tiot++;
                                }
                                if (input[i - 1] == search.ImageProcessing)
                                {
                                    Console.WriteLine("a method to preform some aporations on an image ");
                                    tip++;
                                }
                                if (input[i - 1] == search.IT)
                                {
                                    Console.WriteLine("information technollogy, about anything related to computer technology ");
                                    tIt++;
                                }
                                input[i] = (search)Enum.Parse(typeof(search), Console.ReadLine(), true);
                                i++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("sharmande.aknoon in mored ro nadarim vali dar ayande mojood mishe.");
                        continue;
                    }
                    break;
                }
                while (1 == 1);

            } while (true);
        }
    }
}
