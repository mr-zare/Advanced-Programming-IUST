using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        interface IPersonality
        {
            string name
            {
                get;
                set;
            }
            int score
            {
                get;
                set;
            }
            string Personality();
        }

        class Bear:IPersonality
        {
            int _score;
            string _name ;
            public int score
            {
                get =>_score;
                set => _score=value;
            }
            public string name
            {
                get => _name;
                set => _name = value;
            }
            public Bear(string nam, int emtiaz)
            {
                name = nam;
                score = emtiaz;
            }
            public string Personality()
            {
                string a = "Pooh is Yellow bear\nHe loves honey\n";
                string b =  name+" rate is "+score+"\n";
                string c = a + b;
                return c;
            }
        }
        class Tiger:IPersonality
        {
            int _score;
            string _name;
            public int score
            {
                get => _score ;
                set => _score = value;
            }
            public string name
            {
                get => _name ;
                set => _name = value;
            }
            public Tiger(string nam, int emtiaz)
            {
                name = nam;
                score = emtiaz;
            }
            public string Personality()
            {
                string a = "Tiger is tiger\nHe is smiling\n";
                string b = name + " rate is " + score + "\n";
                string c = a + b;
                return c;
            }
        }
        class Pig : IPersonality
        {
            int _score;
            string _name;
            public int score
            {
                get => _score;
                set => _score = value;
            }
            public string name
            {
                get => _name ;
                set => _name = value;
            }
            public Pig(string nam, int emtiaz)
            {
                name = nam;
                score = emtiaz;
            }
            public string Personality()
            {
                string a = "Piglet is pink pig\nHe is cowardly\n";
                string b = name + " rate is " + score + "\n";
                string c = a + b;
                return c;
            }
        }
       
        class Kangaroo : IPersonality
        {
            int _score;
            string _name;
            public int score
            {
                get => _score ;
                set => _score = value;
            }
            public string name
            {
                get => _name ;
                set => _name = value;
            }
            public Kangaroo(string nam, int emtiaz)
            {
                name = nam;
                score = emtiaz;
            }
            public string Personality()
            {
                string a = "Roo is playful kangroo kid\nHe is teager's freind\n";
                string b = name + " rate is " + score + "\n";
                string c = a + b;
                return c;
            }
        }
        class Donkey : IPersonality
        {
            int _score;
            string _name;
            public int score
            {
                get => _score;
                set => _score = value;
            }
            public string name
            {
                get => _name ;
                set => _name = value;
            }
            public Donkey(string nam, int emtiaz)
            {
                name = nam;
                score = emtiaz;
            }
            public string Personality()
            {
                string a = "Eeyore is tired donkey\nHe always naging\n";
                string b = name + " rate is " + score + "\n";
                string c = a + b;
                return c;
            }
        }
        class Freind<T> where T : IPersonality
        {
            T animal;
            public Freind (T m)
            {
                animal = m;
            }
            public static implicit operator Freind<T>(T a)
            {
                if(a!=null)
                {
                    return new Freind<T>(a);
                }
                else
                {
                    return null;
                }
            }
            public string back()
            {
                return animal.Personality();
            }
        }
        static void Main(string[] args)
        {
            Freind<Bear> bear = new Bear("Pooh", 5);
            Freind<Pig> pig = new Pig("Piglet", 4);
            Freind<Tiger> tiger = new Tiger("Tiger", 3);
            Freind<Kangaroo> kangoroo = new Kangaroo("Roo", 2);
            Freind<Donkey> donkey = new Donkey("Eeyore", 1);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", bear.back(), pig.back(),
                tiger.back(), kangoroo.back(), donkey.back());
        }
    }
}
