using System;

namespace ConsoleApp1
{
    enum noe { strategy,mental,sport}
    enum style {avalshakhs,sevomshakhs}
    enum ages {child,teen,young }
    class Program
    {
        class Media
        {
            int id;
            string name;
            int price;
            int tedad;
            public Media(int id, string nam, int fee, int t)
            {
                this.id = id;
                if (nam == null || nam == "" || nam == " ")
                {
                    throw new Exception("nam nemishe space ya null ya hichi bashe. :|");
                }
                name = nam;
                if (fee < 0)
                {
                    throw new Exception("price nemitoone manfi bashe. :|");
                }
                price = fee;
                if (t < 0)
                {
                    throw new Exception("tedad nemitoone manfi bashe. :|");
                }
                tedad = t;
            }
            public int mojodi()
            {
                return tedad;
            }
            public int qeimat()
            {
                return price;
            }
            public virtual void show()
            {
                Console.Write("nam:{0} price:{1}", name, price);
                if (tedad == 0)
                {
                    Console.Write(" mojood nist :(");
                }
                else
                {
                    Console.Write(" mojoode :)");
                }
            }
            public  void charge(int adad)
            {
                tedad = tedad + adad;
            }
            public void decharge(int a)
            {
                tedad = tedad - a;
            }
        }
        class Book : Media
        {
            string writer
            {
                get;
            }
            int sal
            {
                get;
            }
            public Book(int id, string nam, int fee, int t, string nevisande, int tarikh) : base(id, nam, fee, t)
            {
                writer = nevisande;
                sal = tarikh;
            }
            public override void show()
            {
                base.show();
                Console.Write(" writer: {0}  sal: {1} ", writer, sal);

            }
            public virtual void buy(int tedad,int hazine)
            {
                int t =base.mojodi();
                if(t<tedad)
                {
                    throw new Exception("mojoodi kafi nis:(");
                }
                int m=base.qeimat();
                m = m * t;
                if(m>hazine)
                {
                    throw new Exception("poolet kame:(");
                }
                base.decharge(tedad);
                Console.WriteLine("successful");
            }
        }

        class Magazine:Book
        {
            int mah;
            int tsafhe;
            int tfooroosh=0;
            public override void buy(int tedad, int hazine)
            {
                base.buy(tedad, hazine);
                tfooroosh += tedad;
            }
            public Magazine(int id, string nam, int fee, int t, string nevisande, int tarikh,int mah1,int tsafhe1)
                :base( id,  nam, fee, t,  nevisande, tarikh)
            {
                mah = mah1;
                tsafhe = tsafhe1;
            }
        }

        class Game : Media
        {
            noe noebazi
            {
                get;
            }
            style sabk
            {
                get;
            }
            ages rade
            {
                get;
            }
            public Game(int id, string nam, int fee, int t, noe a, style b, ages c) : base(id, nam, fee, t)
            {
                noebazi = a;
                sabk = b;
                rade = c;
            }
            public override void show()
            {
                base.show();
                Console.Write(" noe:{0} sabk:{1} radeseni:{2} ", noebazi.ToString(), sabk.ToString(), rade.ToString());
            }
            public override void buy(int teda, int hazine)
            {
                int t = base.mojodi();
                if (t < teda)
                {
                    throw new Exception("mojoodi kafi nis:(");
                }
                int m = base.qeimat();
                m = m * t;
                if (m > hazine)
                {
                    throw new Exception("poolet kame:(");
                }
                base.decharge(teda);
                Console.WriteLine("successful");
            }
        }

        static void Main(string[] args)
        {
            //id marboot be Media bayad check she ke yekta bashe//
            //baraye enum ha check shavad exceptionashh//

        }
    }
}
