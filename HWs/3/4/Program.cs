using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    string name = Console.ReadLine();
                    string nahaii = Console.ReadLine();
                    StreamReader file1 = new StreamReader(name);
                    StreamWriter file2 = new StreamWriter(nahaii);
                    int tkhat = 0, tadad = 0, tspace = 0, tseda = 0;
                    while (file1.EndOfStream == false)
                    {
                        string a = file1.ReadLine();
                        string[] a1 = a.Split(' ');
                        tkhat++;
                        tspace += a1.Length - 1;
                        for (int i = 0; i < a1.Length - 1; i++)
                        {
                            file2.Write("{0}*", a1[i]);

                            if ((i + 1) == a1.Length - 1)
                            {
                                file2.WriteLine("{0}", a1[i + 1]);
                            }
                        }
                        for (int i = 0; i < a1.Length; i++)
                        {
                            for (int j = 0; j < a1[i].Length; j++)
                            {
                                if (a1[i][j] == '0' || a1[i][j] == '1' || a1[i][j] == '2' || a1[i][j] == '3' || a1[i][j] == '4' || a1[i][j] == '5' ||
                                    a1[i][j] == '6' || a1[i][j] == '7' || a1[i][j] == '8' || a1[i][j] == '9')
                                {
                                    tadad++;
                                }
                                if (a1[i][j] == 'a' || a1[i][j] == 'e' || a1[i][j] == 'i' || a1[i][j] == 'o' || a1[i][j] == 'u' ||
                                    a1[i][j] == 'A' || a1[i][j] == 'E' || a1[i][j] == 'I' || a1[i][j] == 'O' || a1[i][j] == 'U')
                                {
                                    tseda++;
                                }
                            }
                        }
                    }

                    file1.Close();
                    file2.Close();
                    Console.WriteLine("stars : {0} \nnumbers : {1} \nhoroof seddar : {2} \nlines : {3}", tspace, tadad, tseda, tkhat);
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("lotfan name dorost file mojood ro hamrah (.txt) vared kon");
                    continue;
                }
                break;
            }
            while (1 == 1);
        }
    }
}
