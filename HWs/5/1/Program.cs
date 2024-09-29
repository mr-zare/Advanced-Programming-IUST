using System;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleApp1
{

    class Point
    {
        public virtual double NumberShape()
        {
            return x + y;
        }
        protected double x
        {
            get;
            set;
        }
        protected double y
        {
            get;
            set;
        }
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void print()
        {
            Console.WriteLine("Point  tool:{0} arz:{1}", x, y);
        }
    }
    class Circle:Point
    {
        public override double NumberShape()
        {
            return x + y+r;
        }
        protected double r { get; set; }
        double area, circumference;
        public Circle(double x,double y,double r):base(x,y)
        {
            if(r<0)
            {
                throw new Exception("shoa bayad mosbat bashe");
            }
            this.r = r;
        }
        public override void print()
        {
            Console.WriteLine("dayere: toolmarkaz:{0} arzmarkaz:{1} shoa:{2}",x,y,r);
        }
        public virtual double mohit()
        {
            circumference = 2 * 3.14 * r;
            return circumference;
        }
        public virtual double masahat()
        {
            area = 3.14 * r * r;
            return area;
        }

    }
    class Cylinder:Circle
    {
        public override double NumberShape()
        {
            return x + y + r+h;
        }
        double h;
        double area, circumference,v;
        public Cylinder(double x,double y ,double r,double h):base(x,y,r)
        {
            this.h = h;
        }
        public override double mohit()
        {
            circumference = 4 * r + 2 * h;
            return circumference;
        }
        public override double masahat()
        {
            area =(2 * base.masahat())+(base.mohit() *h);
            return area;
        }
        public double hajm()
        {
            v = base.masahat() * h;
            return v;
        }
        public override void print()
        {
            Console.WriteLine("ostovane: toolmarkaz:{0}  arzmarkaz:{1} shoa:{2} ertefa{3}",x,y,r,h);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            string vo;
            double x, y, r, h,mas,mo;
            
            List<Point> list = new List<Point>();
            do
            {
                Console.WriteLine("Circle\nCylinder\nPoint\nShow All\nExit");
                vo = Console.ReadLine();
                try
                {
                    if (string.Equals(vo, "Circle"))
                    {
                        Console.WriteLine("tool");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("arz");
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine("shoa");
                        r = double.Parse(Console.ReadLine());
                        Circle a = new Circle(x, y, r);
                        list.Add(a);
                        mas =a.masahat();
                        mas = Math.Round(mas, 4);
                        mo = a.mohit();
                        mo = Math.Round(mo, 4);
                        a.print();
                        Console.WriteLine("mohit{0} masahat:{1} shenase{2}", mo, mas, a.NumberShape());
                    }
                    if (string.Equals(vo, "Point"))
                    {
                        Console.WriteLine("tool");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("arz");
                        y = double.Parse(Console.ReadLine());
                        Point a = new Point(x, y);
                        list.Add(a);
                        a.print();
                        Console.WriteLine("shenase: {0}",a.NumberShape());
                    }
                    if (string.Equals(vo, "Cylinder"))
                    {
                        Console.WriteLine("tool");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("arz");
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine("shoa");
                        r = double.Parse(Console.ReadLine());
                        Console.WriteLine("ertefa");
                        h = double.Parse(Console.ReadLine());
                        Cylinder a = new Cylinder(x, y, r,h);
                        list.Add(a);
                        mas = a.masahat();
                        mas = Math.Round(mas, 4);
                        mo = a.mohit();
                        mo = Math.Round(mo, 4);
                        a.print();
                        Console.WriteLine("mohit{0} masahat:{1} hajm:{2} shenase{3}", mo, mas,Math.Round(a.hajm(),4), a.NumberShape());
                    }
                    if (string.Equals(vo, "Show All"))
                    {
                        for(int i=0;i<list.Count;i++)
                        {
                            if(list[i] is Cylinder)
                            {
                                Cylinder c;
                                c = list[i] as Cylinder;
                                mas = c.masahat();
                                mas = Math.Round(mas, 4);
                                mo = c.mohit();
                                mo = Math.Round(mo, 4);
                                list[i].print();
                                Console.WriteLine("mohit{0} masahat:{1} hajm:{2} ", mo, mas,Math.Round(c.hajm(),4));
                                continue;
                            }
                            if (list[i] is Circle)
                            {
                                Circle c;
                                c = list[i] as Circle;
                                mas = c.masahat();
                                mas = Math.Round(mas, 4);
                                mo = c.mohit();
                                mo = Math.Round(mo, 4);
                                list[i].print();
                                Console.WriteLine("mohit{0} masahat:{1} ", mo, mas);
                                continue;
                            }
                            if (list[i] is Point)
                            {
                                list[i].print();
                            }
                        }
                    }
                    if (!string.Equals(vo, "Circle") && !string.Equals(vo, "Cylinder")
                    && !string.Equals(vo, "Point") && !string.Equals(vo, "Exit") && !string.Equals(vo, "Show All"))
                    {
                        throw new Exception("vorodi dorost vared kon :|");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!string.Equals(vo, "Exit"));
        }
    }
}
