using System;

namespace ConsoleApp1
{
    class acount
    {
        protected static int tshey = 0;
        protected int id;
        //id kamel she
        protected int hesab
        {
            get;
        }
        protected string kart
        {
            get;
        }
        protected int[] idlist = new int[10];
        protected double mojoodi=0;
        public acount()
        {
            Random shansi = new Random();
            hesab = shansi.Next(10000000, 99999999);
            for(int i=0;i<3;i++)
            {
                int temp;
                temp = shansi.Next(1000, 9999);
                kart = kart + temp.ToString()+"_";
            }
            int temp1 = shansi.Next(1000, 9999);
            kart = kart + temp1.ToString();
            tshey++;
        }
        
        public virtual void variz(int adad)
        {
            Console.WriteLine("not implemented");
        }
        public virtual void bardasht(int adad)
        {
            Console.WriteLine("not implemented");
        }

        public virtual void sood(int mah)
        {
            Console.WriteLine("not implemented");
        }

        public virtual void log()
        {
            Console.WriteLine("not implemented");
        }

    }
    class juniorAcc : acount
    {
        int mahbala;
        int mahpaiin;
        float gainmah = 7 / 100;
        float mahbar = 1 / 2;
        public juniorAcc(int mahba, int mahpa,int id):base()
        {

            int f = 0;
            mahbala=mahba;
            if(mahpa<0)
            {
                throw new Exception("nabayad mahdoode kamtar az 0 bashe");
            }
            mahpaiin=mahpa;
            for (int i = 0; i < tshey; i++)
            {
                if (id == idlist[i])
                {
                    f = 1;
                }
            }
            if (f == 0)
            {
                idlist[tshey] = id;
            }
            else
            {
                throw new Exception("id tekrarie");
            }
        }
        public override void variz(int adad)
        {
            if (adad < 0)
            {
                throw new Exception("variz manfi nabayad bashe");
            }
            mojoodi += adad;
            if(mojoodi>mahbala)
            {
                mojoodi -= adad;
                throw new Exception("mojoodi balatar az hade");
            }
            if(mojoodi<mahpaiin)
            {
                throw new Exception("mojoodi paiin tar az hade");
            }
            if(mojoodi<0)
            {
                throw new Exception("mojoodi nabayad manfi she");
            }
        }
        public override void bardasht(int adad)
        {
            if (adad < 0)
            {
                throw new Exception("bardasht manfi nabayad bashe");
            }
            if ((mojoodi*mahbar) > adad)
            {
                mojoodi -= adad;
            }
            else
            {
                throw new Exception("bardashti az nesf mojoodi bishtare");
            }
            if (mojoodi > mahbala)
            {
                mojoodi -= adad;
                throw new Exception("mojoodi balatar az hade");
            }
            if (mojoodi < mahpaiin)
            {
                throw new Exception("mojoodi paiin tar az hade");
            }
            if (mojoodi < 0)
            {
                throw new Exception("mojoodi nabayad manfi she");
            }
        }

        public override void sood(int mah)
        {
            if (mah < 0)
            {
                throw new Exception("sal manfi nabayad bashe");
            }
            double a = Math.Pow((1 + gainmah), mah);
            mojoodi =  a * mojoodi;
            if (mojoodi > mahbala)
            {
                mojoodi -= (a * mojoodi);
                throw new Exception("mojoodi balatar az hade");
            }
        }
        public override void log()
        {
            Console.WriteLine("mahbala:{0}  mahpaiin:{1}  mojoodi:{2}  shkart:{3}  shhesab:{4}", mahbala.ToString(), mahpaiin.ToString(),
                mojoodi.ToString(), kart, hesab.ToString());
        }
        public void gift()
        {
            Random shansi = new Random();
            int a = shansi.Next(0, 21);
            double a1 = a / 100;
            mojoodi = (1 + a1) * mojoodi;
        }
    }
    class LongTimeAcc:acount
    {
        int mahpa;
        float gainsal = 15 / 100;
        string tarikh;
        bool block = false;
        public LongTimeAcc(int mahpaiin,string time,int id):base()
        {
            int f = 0;
            mahpa = mahpaiin;
            tarikh = time;
            for (int i = 0; i < tshey; i++)
            {
                if (id == idlist[i])
                {
                    f = 1;
                }
            }
            if (f == 0)
            {
                idlist[tshey] = id;
            }
            else
            {
                throw new Exception("id tekrarie");
            }
        }
        public override void variz(int adad)
        {
            if (block== false)
            {
                if (adad < 0)
                {
                    throw new Exception("variz manfi nabayad bashe");
                }

                if (mojoodi < mahpa)
                {
                    throw new Exception("mojoodi paiin tar az hade");
                }
                if (mojoodi < 0)
                {
                    throw new Exception("mojoodi nabayad manfi she");
                }
                mojoodi += adad;
            }
            else
            {
                Console.WriteLine("nemishe block true shode;");
            }
        }
        public override void bardasht(int adad)
        {
            if (block == false)
            {
                if (adad < 0)
                {
                    throw new Exception("bardasht manfi nabayad bashe");
                }
                mojoodi -= adad;
                if (mojoodi < mahpa)
                {
                    throw new Exception("mojoodi paiin tar az hade");
                }
                if (mojoodi < 0)
                {
                    throw new Exception("mojoodi nabayad manfi she");
                }
            }
            else
            {
                Console.WriteLine("nemishe block true shode;");
            }
        }

        public override void sood(int sal)
        {
            if(sal<0)
            {
                throw new Exception("sal manfi nabayad bashe");
            }
            double ad = gainsal / 12;
            double a1 = Math.Pow((1 + ad), sal;
            mojoodi = mojoodi * a1;

        }

        public override void log()
        {
            Console.WriteLine("mahpaiin:{0}  tarikh:{1} mojoodi:{2}  shkart:{3}  shhesab:{4}", mahpa.ToString(),tarikh,
                mojoodi.ToString(), kart, hesab.ToString());
        }
        public void blockunblock()
        {
            if(block==false)
            {
                block = true;
            }
            else
            {
                block = false;
            }
        }


    
    }
    class person
    {
        object hesab;
        string name;
        int code;
        public virtual void ijad()
        {
            
        }
        public virtual void amaliat()
        {

        }
        public virtual void bastan()
        {

        }
    }
    class bank:person
    {
        static string[] list = new string[10];
        public int mande { get; }

        public override void ijad()
        {

        }
        public override void amaliat()
        {

        }
        public override void bastan()
        {

        }
        public void bardassht()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            



        }
    }
}
