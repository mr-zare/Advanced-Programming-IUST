using System;

namespace faalit4
{
    class Person
    {
        string name;
        string family;
        int age;
        public Person(string nam, string famil, int sen)
        {
            name = nam;
            family = famil;
            age = sen;
        }
        public void Information()
        {
            Console.WriteLine("name:{0}  family:{1}  age:{2} ", name, family, age);
        }
    }
    class Student:Person
    {
        string schoolname;
        public Student (string nam,string famil,int sen,string school):base(nam,famil,sen)
        {
            schoolname = school;
        }
    }
    class Teacher:Person
    {
        string dars;
        public Teacher(string nam,string famil,int sen,string namdars):base(nam,famil,sen)
        {
            dars = namdars;
        }
    }
    
    class Program
    {
        static void Check(object o)
        {
            if(o is Student)
            {
                Console.WriteLine("Student");
            }
            if(o is Teacher)
            {
                Console.WriteLine("Teacher");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("student:\n name:");
            string nam = Console.ReadLine();
            Console.WriteLine("familyname:");
            string familyname = Console.ReadLine();
            Console.WriteLine("sen:");
            int sen = int.Parse(Console.ReadLine());
            Console.WriteLine("schoolname:");
            string schoolname = Console.ReadLine();
            Student daneshamooz = new Student(nam, familyname, sen, schoolname);
            
            Console.WriteLine("teacher:\n name:");
            string nam1 = Console.ReadLine();
            Console.WriteLine("familyname:");
            string familyname1 = Console.ReadLine();
            Console.WriteLine("sen:");
            int sen1 = int.Parse(Console.ReadLine());
            Console.WriteLine("darstadrisi:");
            string dars = Console.ReadLine();
            Teacher ostad = new Teacher(nam1, familyname1, sen1, dars);
            daneshamooz.Information();
            ostad.Information();
            Check(daneshamooz);
            Check(ostad);
        }
    }
}
