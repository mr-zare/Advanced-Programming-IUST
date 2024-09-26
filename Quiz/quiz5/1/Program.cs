using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Digimon> digimonlist = File.ReadAllLines(@"E:\AP-TA\Quiz 5\DigiDB_digimonlist.csv")
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
            int Number;
            string DigimonName;
            string Stage;
            string Type;
            string Attribute;
            int Memory;
            int Equip_Slots;
            int HP;
            int SP;
            int Atk;
            int Def;
            int Int;
            int Spd;
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
