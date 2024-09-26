using System;

namespace ConsoleApp1
{
    enum noe { Hatchbak,Sedan,SUV,Coupe }
    interface IDrive
    {
        string usefor();
    }
    class Vehicle
    {
        protected string name;
        protected int charkh;
        public Vehicle(string nam,int tedad)
        {
            name = nam;
            charkh = tedad;
        }
    }
    class car : Vehicle, IDrive
    {
        noe a;
        public car(string nam, int tedad, noe b) : base(nam, tedad)
        {
            a = b;
        }
        public string usefor()
        {
            return "car:safar kardan";
        }
        public void chap()
        {
            Console.WriteLine("car( name:{0}  charkh: {1} noe: {2})", name, charkh,a);
        }
    }
    class Truck:Vehicle,IDrive
    {
        Boolean havetrailer;
        public Truck(string nam, int tedad, bool a) : base(nam, tedad)
        {
            havetrailer = a;
        }
        public string usefor()
        {
            return "truck:barbari";
        }
        public void chap()
        {
            Console.WriteLine("truck( name:{0}  charkh:{1} havetrailer: {2})",name,charkh,havetrailer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("car info:nam,tedad charkh.");
                    string nam = Console.ReadLine();
                    int tcar = int.Parse(Console.ReadLine());
                    Random shansi = new Random();
                    noe z = (noe)shansi.Next(0, 2);
                    car c = new car(nam, tcar, z);
                    Console.WriteLine("truck info:nam,tedad charkh,trailer dare(true) ya nadare (false)");
                    string nam1 = Console.ReadLine();
                    int ttruck = int.Parse(Console.ReadLine());
                    string e = Console.ReadLine();
                    Boolean z1 = true;
                    e = e.ToLower();
                    if (e == "true")
                    {
                        z1 = true;
                    }
                    else if (e == "false")
                    {
                        z1 = false;
                    }
                    else if (e != "true" && e != "false")
                    {
                        throw new Exception("baraye truck meqdar bool ra true ya false vared kon");
                    }

                    Truck t = new Truck(nam1, ttruck, z1);
                    IDrive[] r = new IDrive[2];
                    r[0] = c;
                    r[1] = t;
                    string seda1 = r[0].usefor();
                    string seda2 = r[1].usefor();
                    Console.WriteLine("{0} \n{1}", seda1, seda2);
                    c.chap();
                    t.chap();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    Console.WriteLine(" dobare az aval etelaat ro vared kon");
                    continue;
                }
                break;
            } while (1 == 1);
        }
    }
}
