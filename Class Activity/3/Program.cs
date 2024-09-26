using System;

namespace faalit3
{
    class Student
    {
        string[] name=new string[100];
        int shomare;
        public Student(string[] esm,int adad)
        {
            name[0]=esm[0];
            name[1]=esm[1];
            shomare=adad;
        }
        public Student Clone()
        {
            Student m1;
            m1=new Student(name,shomare);
            return m1;
           
        }
        public Student badClone()
        {
            return (Student)this.MemberwiseClone();
        }
        public string stdInfo()
        {
            string q=name[0]+" "+name[1]+" "+shomare;
            return q;
        }
        public void changeInfo(char a,int n)
        {
            char[] e=new char[name[0].Length];
            e[0]=a;
            for (int i = 1; i < name[0].Length; i++)
            {
                e[i]=name[0][i];
            }
            string e1=new string(e);
            name[0]=e1;
            shomare+=n;
        }
    }
    class Program
    {
        static void studentInfo(params Student[] b)
        {  
            foreach (var item in b)
            {
                string w=item.stdInfo();
                Console.WriteLine(w);
            }
        }
        static void Main(string[] args)
        {
            string adad1,adad2,adad3,nam1,nam2,nam3; 
            nam1=Console.ReadLine();
            adad1=Console.ReadLine();
            nam2=Console.ReadLine();
            adad2=Console.ReadLine();
            nam3=Console.ReadLine();
            adad3=Console.ReadLine();
            int adad11 = int.Parse(adad1);
            int adad22 = int.Parse(adad2);
            int adad33 = int.Parse(adad3);
            string[] nam11=nam1.Split(' ');
            string[] nam22=nam2.Split(' ');
            string[] nam33=nam3.Split(' ');
            Student s1;
            s1=new Student(nam11,adad11);
            Student s2;
            s2 = new Student(nam22,adad22);
            Student s3;
            s3 = new Student(nam33,adad33);
            studentInfo(s1,s2,s3);
            Student s4;
            s4=s1.Clone();
            char p='w';
            int pop=105;
            s1.changeInfo(p,pop);
            studentInfo(s1,s4);
            Student s5;
            s5=s2.badClone();
            s2.changeInfo(p,pop);
            studentInfo(s2,s5);
            
        }
    }
}
