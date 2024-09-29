using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            int[,] sodo = new int[9, 9]{ { 5 , 3 , 0 , 0 , 7 , 0 , 0 , 0 , 0} , { 6,0,0,1,9,5,0,0,0,},{ 0,9,8,0,0,0,0,6,0}, { 8,0,0,0,6,0,0,0,3},{ 4,0,0,8,0,3,0,0,1},{ 7,0,0,0,2,0,0,0,6},
               { 0,6,0,0,0,0,2,8,0},{ 0,0,0,4,1,9,0,0,5},{ 0,0,0,0,8,0,0,7,9} };
             int[,] temp = new int[9, 9]{ { 5 , 3 , 0 , 0 , 7 , 0 , 0 , 0 , 0} , { 6,0,0,1,9,5,0,0,0,},{ 0,9,8,0,0,0,0,6,0}, { 8,0,0,0,6,0,0,0,3},{ 4,0,0,8,0,3,0,0,1},{ 7,0,0,0,2,0,0,0,6},
                 { 0,6,0,0,0,0,2,8,0},{ 0,0,0,4,1,9,0,0,5},{ 0,0,0,0,8,0,0,7,9} }; ;
            /*int[,] sodo = new int[9, 9];
            int[,] temp= new int[9, 9];
            Random shansi = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sodo[i, j] = 0;
                    temp[i, j] = 0;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int m = shansi.Next(1, 10);
                    int flag = 0;
                    for (int k = 0; k < i; k++)
                    {
                        if (sodo[k, j] == m)
                        {
                            flag = 1;
                        }
                    }
                    for (int k = 0; k < j; k++)
                    {
                        if (sodo[i, k] == m)
                        {
                            flag = 1;
                        }
                    }
                    for (int k = (i / 3) * 3; k < ((i / 3) + 1) * 3; k++)
                    {
                        for (int w = (j / 3) * 3; w < ((j / 3) + 1) * 3; w++)
                        {
                            if (sodo[k, w] == m)
                            {
                                flag = 1;
                            }
                        }
                    }
                    if (flag == 1)
                    {
                        while (flag == 1)
                        {
                            flag = 0;
                            m = shansi.Next(1, 10);
                            for (int k = 0; k < i; k++)
                            {
                                if (sodo[k, j] == m)
                                {
                                    flag = 1;
                                }
                            }
                            for (int k = 0; k < j; k++)
                            {
                                if (sodo[i, k] == m)
                                {
                                    flag = 1;
                                }
                            }
                            for (int k = (i / 3) * 3; k < ((i / 3) + 1) * 3; k++)
                            {
                                for (int w = (j / 3) * 3; w < ((j / 3) + 1) * 3; w++)
                                {
                                    if (sodo[k, w] == m)
                                    {
                                        flag = 1;
                                    }
                                }
                            }
                        }
                    }
                    sodo[i, j] = m;
                }
            }*/
            string vo1;
            string[] vo;
          //  string del1,add1;
           // string[] del, add;
            int satr, soton,adad,sacheck,socheck;
            do
            {
                Console.WriteLine("Add\nDel\nShowCart");
                vo1 = Console.ReadLine();
                vo = vo1.Split(" ");
                try
                {
                    if(string.Equals(vo[0],"Add"))
                    {
                        satr = int.Parse(vo[1]);
                        soton = int.Parse(vo[2]);
                        adad = int.Parse(vo[3]);
                        if(adad>9 || adad<=0)
                        {
                            throw new Exception("adad vorodi dar add kardan bayad dar baze 1 ta 9 bashe");
                        }
                        if (temp[satr - 1, soton - 1] != 0 || sodo[satr - 1, soton - 1] != 0)
                        {
                            throw new Exception("khane pishfarz meqdardehi shode ya qabla meqdar dehi kardi");
                        }
                        if (temp[satr - 1, soton - 1] == 0 && sodo[satr - 1,soton-1]==0)
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                if(satr!=i && sodo[i,soton-1]==adad)
                                {
                                    throw new Exception("adad vared shode dar sotoon mojoode");
                                }
                            }
                            for (int i = 0; i < 9; i++)
                            {
                                if (soton != i && sodo[satr-1, i] == adad)
                                {
                                    throw new Exception("adad vared shode dar satr mojoode");
                                }
                            }
                            sacheck = (satr-1) / 3;
                            socheck = (soton-1)/ 3;
                            for (int i = 3*sacheck; i < 3*(sacheck+1); i++)
                            {
                                for (int j =3*socheck ; j < 3*(socheck+1) ; j++)
                                {
                                    if(satr!=i ||soton!=j)
                                    {
                                        if(sodo[i,j]==adad)
                                        {
                                            throw new Exception("adad mored nazr dar bolok mojoode");
                                        }
                                    }
                                }
                            }
                            sodo[satr - 1, soton - 1] = adad;
                        }
                    }
                    if (string.Equals(vo[0], "Del"))
                    {
                        satr = int.Parse(vo[1]);
                        soton = int.Parse(vo[2]);
                        if(temp[satr-1,soton-1]==0)
                        {
                            sodo[satr - 1, soton - 1] = 0;
                        }
                        else 
                        {
                            throw new Exception("nemishe meqdar khane haye pishfarz meqdardehi shode ro taqiir dad");
                        }
                    }
                    if (string.Equals(vo[0], "ShowCart"))
                    {
                        for(int i=0;i<9;i++)
                        {
                            for(int j=0;j<9;j++)
                            {
                                Console.Write(sodo[i,j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    if (!string.Equals(vo[0], "Add") && !string.Equals(vo[0], "Del") && !string.Equals(vo[0], "ShowCart") && !string.Equals(vo[0], "Exit"))
                    {
                        throw new Exception("vorodi ra dorost vared kon:|");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (!string.Equals(vo1, "Exit"));
            

        }
    }
}
