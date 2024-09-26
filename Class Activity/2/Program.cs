using System;

namespace faalit2
{
    class Book
    {
        string name;
        int price;
        int number;
        public Book(string nam,int fee,int tedad)
        {
            name=nam;
            price=fee;
            number=tedad;
        }
        public Book(string nam1,int fee1)
        {
            name=nam1;
            price=fee1;
            Random shansi=new Random();
            number=shansi.Next(10,99);
        }
        public void PrintInfo()
        {
            Console.Write(name+" ");
            Console.Write(price+" ");
            Console.Write(number+"\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string m=Console.ReadLine();
            string[] matn=m.Split(' ');
            int qeimat=int.Parse(matn[1]),adad=int.Parse(matn[2]); 
            Book a;
            a=new Book(matn[0],qeimat,adad);

            string m1=Console.ReadLine();
            string[] matn1=m1.Split(' ');
            int qeimat1=int.Parse(matn1[1]);
            Book b;
            b=new Book(matn1[0],qeimat1);
            a.PrintInfo();
            b.PrintInfo();


        }
    }
}
