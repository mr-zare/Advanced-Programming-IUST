using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Digimon> digimonlist = File.ReadAllLines(@"D:\computer\ap\quiz\quiz5\1\DigiDB_digimonlist.csv")
                .Skip(1)
                .Select(line => new Digimon(
                    int.Parse(line.Split(',')[0]),
                    line.Split(',')[1],
                    line.Split(',')[2],
                    line.Split(',')[3],
                    line.Split(',')[4],
                    int.Parse(line.Split(',')[5]),
                    int.Parse(line.Split(',')[6]),
                    int.Parse(line.Split(',')[7]),
                    int.Parse(line.Split(',')[8]),
                    int.Parse(line.Split(',')[9]),
                    int.Parse(line.Split(',')[10]),
                    int.Parse(line.Split(',')[11]),
                    int.Parse(line.Split(',')[12])))
                .ToList<Digimon>();
            printList(digimonlist, 5);
            // start coding from here
            List<Digimon> j1 = digimonlist.Where(x => x.Type == "Virus" && x.SP > 100).ToList();
            Console.WriteLine("soal1");
            for(int i=0;i<j1.Count;i++)
            {
                Console.WriteLine($"{j1[i].DigimonName}");
            }
            Console.WriteLine("soal2");
            List<Digimon> j2 = digimonlist.Where(x => x.Attribute == "Fire").ToList();
            for (int i = 0; i < j2.Count; i++)
            {
                Console.WriteLine($"[{j2[i].DigimonName},{j2[i].Stage},{j2[i].HP},{j2[i].Atk}]");
            }
            Console.WriteLine("soal3");
            var j3 = digimonlist.GroupBy(x=>x.Attribute);
            foreach(var m in j3)
            {
                Console.WriteLine($"{m.Key},count:{m.Count()}");
            }
            Console.WriteLine("soal4");
            int n = digimonlist.Count;
            double a = digimonlist.Average(x => x.Atk);
            double b = digimonlist.Average(x => x.HP);
            double c = digimonlist.Average(x => x.SP);
            for (int i = 0; i < digimonlist.Count; i++)
            {
                if(digimonlist[i].Atk>a || digimonlist[i].HP > b || digimonlist[i].SP > c)
                {
                    Console.WriteLine($"{digimonlist[i].DigimonName}");
                }
            }
            Console.WriteLine("soal5");
            List<Digimon> j5 = digimonlist.Where(x => x.Type == "Free").OrderByDescending(y=>y.Memory).Take(5).ToList<Digimon>();
            for (int i = 0; i < j5.Count; i++)
            {   
                Console.WriteLine($"{j5[i].DigimonName}");
            }
            Console.WriteLine("soal6");
            var j6 = digimonlist.GroupBy(x => x.Stage);
            foreach (var t in j3)
            {
                Console.WriteLine($"{t.Key},count:{t.Count()}");
            }

        }
        
        public static void printList(List<Digimon> digilist, int top)
        {
            int counter = 0;
            Digimon.printHeaders();
            foreach (Digimon i in digilist)
            {
                if (counter == top) break;
                counter++;
                i.print();
            }
        }

        public class Digimon
        {
            public int Number;
            public string DigimonName;
            public string Stage;
            public string Type;
            public string Attribute;
            public int Memory;
            public int Equip_Slots;
            public int HP;
            public int SP;
            public int Atk;
            public int Def;
            public int Int;
            public int Spd;
            public Digimon(int Number,
            string DigimonName,
            string Stage,
            string Type,
            string Attribute,
            int Memory,
            int Equip_Slots,
            int HP,
            int SP,
            int Atk,
            int Def,
            int Int,
            int Spd)
            {
                this.Number = Number;
                this.DigimonName = DigimonName;
                this.Stage = Stage;
                this.Type = Type;
                this.Attribute = Attribute;
                this.Memory = Memory;
                this.Equip_Slots = Equip_Slots;
                this.HP = HP;
                this.SP = SP;
                this.Atk = Atk;
                this.Def = Def;
                this.Int = Int;
                this.Spd = Spd;
            }

            public void print()
            {
                Console.WriteLine(String.Format("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,-10} {6,-16} {7,-6} {8,-6} {9,-6} {10,-6} {11,-6} {12,-6}\n",
            Number,
            DigimonName,
            Stage,
            Type,
            Attribute,
            Memory,
            Equip_Slots,
            HP,
            SP,
            Atk,
            Def,
             Int,
             Spd));
            }
            public static void printHeaders()
            {
                Console.WriteLine(String.Format("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,-10} {6,-16} {7,-6} {8,-6} {9,-6} {10,-6} {11,-6} {12,-6}\n",
            "Number",
            "DigimonName",
            "Stage",
            "Type",
            "Attribute",
            "Memory",
            "Equip Slots",
            "HP",
            "SP",
            "Atk",
            "Def",
            "Int",
            "Spd"));
            }
        }
    }
}