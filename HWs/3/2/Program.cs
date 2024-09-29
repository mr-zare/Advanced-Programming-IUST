using System;
using System.IO;
namespace ConsoleApp1
{
    enum animal { lion=9600,tiger=9611,monkey=9633,elephant=9644,girrafe=9655,boof=9666,bear=9622}

    class Care
    {
        private int id;
        private animal name;
        string location;
        string food;
        int number;
        int[] schedule = new int[3];
        public Care(int a, animal b, string mahal, string qaza, int tedad, int[] barname)
        {
            id = a;
            name = b;
            location = mahal;
            food = qaza;
            number = tedad;
            schedule = barname;
        }
        public void setcshedule()
        {
            Random shansi = new Random();
            if (food == "vegetable")
            {

                schedule[0] = shansi.Next(6, 23);
                schedule[1] = (schedule[0] + shansi.Next(2, 5))%24;
                schedule[2] = (schedule[1] + shansi.Next(2, 5))%24;
            }
            if (food == "meet")
            {
                for (int i = 0; i < 3; i++)
                {
                    if (schedule[i] == 22)
                    {
                        schedule[i] = shansi.Next(17, 22);
                    }
                }
            }
            SaveToFile();
        }
        public void SaveToFile()
        {
            StreamWriter file = new StreamWriter(id.ToString());
            file.WriteLine("ID:{0}", id);
            file.WriteLine("Location:{0}", location);
            file.WriteLine("Food:{0}", food);
            file.WriteLine("Schedule:{0}-{1}-{2}", schedule[0], schedule[1], schedule[2]);
            file.WriteLine("Number:{0}", number);
            file.Close();
            
        }
        public static void AllInfo(Care[] a)
        {
            StreamWriter file1 = new StreamWriter("AllINFO.txt");
            for(int i = 0;i<a.Length;i++)
            {
                file1.WriteLine("name:{0} id:{1}", a[i].name, a[i].id);
            }
            file1.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number of animal to save");
            int tedadsa = 0,tedadnum,u=0;
            animal code;
            string location1,food,b,c;
            string[] a1 = new string[3];
            int[] barname = new int[3];
            
            do
            {
                try
                {
                    tedadsa = int.Parse(Console.ReadLine());
                }
                catch(Exception a)
                {
                    Console.WriteLine(a.Message);
                    continue;
                }
                break;

            } while (1 == 1);
            Care[] list = new Care[tedadsa];
            while (u < tedadsa)
            {
                Console.WriteLine("enter the code:");
                do
                {
                    try
                    {
                        code = (animal)Enum.Parse(typeof(animal), Console.ReadLine(), true);
                        if((int)code!=9600 && (int)code != 9611 && (int)code != 9622 && (int)code != 9633 && (int)code != 9644 &&
                            (int)code != 9655 && (int)code != 9666)
                        {
                            throw new Exception("code varede mojod nis aslan:|");
                        }
                    }
                    
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                        continue;
                    }
                    break;

                } while (1 == 1);
                Console.WriteLine("enter the location:");
                location1 = Console.ReadLine();
                Console.WriteLine("enter the food:");
                do
                {
                    try
                    {
                        food = Console.ReadLine().ToLower();
                        if (!string.Equals(food, "meet") && !string.Equals(food, "vegetable"))
                        {
                            throw new Exception("esm food, meet ya vegetable hast");
                        }
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                        continue;
                    }
                    break;

                } while (1 == 1);

                Console.WriteLine("enter the schedule:");
                do
                {
                    try
                    {
                        b = Console.ReadLine();
                        a1 = b.Split('-');
                        barname[0] = int.Parse(a1[0]);
                        barname[1] = int.Parse(a1[1]);
                        barname[2] = int.Parse(a1[2]);
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                        continue;
                    }
                    break;

                } while (1 == 1);
                Console.WriteLine("enter the number:");
                do
                {
                    try
                    {
                        c = Console.ReadLine();
                        tedadnum = int.Parse(c);

                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                        continue;
                    }
                    break;
                } while (1 == 1);
                list[u] = new Care((int)code, code, location1, food, tedadnum, barname);
                u++;
            }
            for(int i=0;i<tedadsa;i++)
            {
                list[i].SaveToFile();
                list[i].setcshedule();
            }
            Care.AllInfo(list);
        }
    }
}
