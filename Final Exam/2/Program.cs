using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    //bara cons dovomi adad shansi qeir tekrari drost she//
    class Account
    {
        protected string name;
        protected int codemeli;
        protected int shomareh;
        protected double mojoodi;
        static List<int> hesab = new List<int>();
        public Account(string nam,int code,int sh,double baqi)
        {
            name = nam;
            codemeli = code;
            for(int i=0;i<hesab.Count;i++)
            {
                if(sh==hesab[i])
                {
                    throw new Exception("hesab tekrarie");
                }

            }
            if (sh / 1000 < 9 && sh / 1000 != 0)
            {
                shomareh = sh;
            }
            else
            {
                if(sh>9999)
                {
                    sh = sh % 10000;
                }
                if(sh<1000)
                {
                    if(sh<10)
                    {
                        string shh = "000" + sh;
                        sh = (int.Parse(shh));
                    }
                    if (sh < 100)
                    {
                        string shh = "00" + sh;
                        sh = (int.Parse(shh));
                    }
                    if (sh < 1000)
                    {
                        string shh = "0" + sh;
                        sh = (int.Parse(shh));
                    }
                }
            }
            shomareh = sh;
            hesab.Add(sh);
            if (baqi >= 0)
            {
                mojoodi = baqi;
            }
            else
            {
                throw new Exception("mojoodi nemitoone manfi bashe");
            }
        }
        public Account(string nam,int code)
        {
            Random shansi = new Random();
            int sh = shansi.Next(1000, 10000);
            for (int i = 0; i < hesab.Count; i++)
            {
                if (sh == hesab[i])
                {
                    throw new Exception("hesab tekrarie");
                }
            }
            name = nam;
            codemeli = code;
            shomareh = sh;
            Account a = new Account(nam, code, sh, 0);
        }
    }
    sealed class Babyaccount:Account
    {
        double saqf;
        int age;
        public Babyaccount(string nam, int code, int baqi, double saghf, int sen) : base(nam, code + 10000)
        {
            if (saghf >= 0)
            {
                saqf = saghf;
            }
            else
            {
                throw new Exception("saqf nabayad manfi bashe:(");
            }
            if (sen >= 1 && sen <= 18)
            {
                age = sen;
            }
            else
            {
                throw new Exception("sen bayad 1 ta 18 bashe");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("name ra vared konid");
            string nam = Console.ReadLine();
            Console.WriteLine("code ra vared konid");
            int code =int.Parse( Console.ReadLine());
            Console.WriteLine("shomare ra vared konid");
            int shomare =int.Parse(Console.ReadLine());
            Console.WriteLine("mojoodi ra vared konid");
            double mojoodi = double.Parse(Console.ReadLine());
            Account a1 = new Account(nam, code, shomare, mojoodi);
            */
        }
    }
}
