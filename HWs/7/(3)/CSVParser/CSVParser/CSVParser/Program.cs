using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines(@"..\..\IMDB-Movie-Data.csv")
                .Skip(1)
                .Select(line => new IMDBData(line));
            Console.WriteLine($"The film with highest metascore : {data.GetHighestMetascore().Title}");
            // If necessary, you can use more than one extension method to calculate these answers.
            /* Console.WriteLine($"Question 1: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 2: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 3: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 4: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 5: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 6: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 7: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 8: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 9: {data.ExtensionMethodPlaceHolder()}");
             Console.WriteLine($"Question 10: {data.ExtensionMethodPlaceHolder()}");*/
            List<IMDBData> win = data.windesieldirector();
            List<IMDBData> hund = data.Hundredmingenre();
            Console.WriteLine($"1:\n");
            for (int i=0;i<hund.Count;i++)
            {
                Console.WriteLine($"genre:{hund[i].Genre}");
            }
            Console.WriteLine($"2:\n");
            for (int i = 0; i < win.Count; i++)
            {
                Console.WriteLine($"title:{win[i].Title} director:{win[i].Director}");
            }
            Console.WriteLine($"3:\nactors:{data.best2016().Actor1},{data.best2016().Actor2},{data.best2016().Actor3},{data.best2016().Actor4}\ndirector:{data.best2016().Director}" +
                $"\ngenre:{data.best2016().Genre}\nmetascore:{data.best2016().Metascore}\nrank:{data.best2016().Rank}\nrating:{data.best2016().Rating}\nrevenue:{data.best2016().Revenue}" +
                $"\nruntime:{data.best2016().Runtime}\ntitle:{data.best2016().Title}\nvotes:{data.best2016().Votes}\nyear:{data.best2016().Year}");
            List<IMDBData> a = data.bryansinger();
            Console.Write("4:\n");
            for (int i = a.Count -1; i>= 0; i--)
                Console.WriteLine($"title:{a[i].Title} revenue:{a[i].Revenue}");
            Console.WriteLine($"5:\n{data.sumrevenue()}");
            List<IMDBData> b = data.top10action();
            Console.Write($"6:\n");
            for(int i=0;i<b.Count;i++)
            {
                Console.WriteLine($"{b[i].Title}");
            }
            List<IMDBData> c = data.adaddar();
            Console.Write($"7:\n");
            for (int i = 0; i < c.Count; i++)
            {
                Console.WriteLine($"{c[i].Title}");
            }
            List<IMDBData> anne = data.anne();
            List<IMDBData> jennifer = data.lawrence();
            Console.Write($"8:\nanne:\n");
            for (int i = 0; i < anne.Count; i++)
            {
                Console.WriteLine($"{anne[i].Title}");
            }
            Console.WriteLine("jennifer lawrence:");
            for (int i = 0; i < jennifer.Count; i++)
            {
                Console.WriteLine($"{jennifer[i].Title}");
            }
            List<string> comedy = data.comedy();
            List<string> drama = data.drama();
            Console.Write("9:\ncomedy:\n");
            for(int i=0;i<comedy.Count;i++)
            {
                Console.WriteLine($"{comedy[i]}");
            }
            Console.WriteLine("drama:");
            for (int i = 0; i < drama.Count; i++)
            {
                Console.WriteLine($"{drama[i]}");
            }
            Console.WriteLine($"comedy:{data.comedy().Count}\ndrama:{data.drama().Count}");
            Console.WriteLine($"10:");
        }
    }

    public static class Extensions
    {
        public static Nullable<int> ParseIntOrNull(this string str)
            => !string.IsNullOrEmpty(str) ? int.Parse(str) as Nullable<int> : null;
        public static string ParseStringOrNull(this string str)
            => !string.IsNullOrEmpty(str) ? str : null;

        //For example
        public static IMDBData GetHighestMetascore(this IEnumerable<IMDBData> data)
            => data.OrderByDescending(x => x.Metascore).First();

        /// <summary>
        /// you must modify the name of this method and its 
        /// implementation to fit your need and create more methods like this
        public static IMDBData ExtensionMethodPlaceHolder(this IEnumerable<IMDBData> data)
            => data.First();
        public static bool checkwin(this IMDBData data)
        {
            if(data.Actor1=="\"Vin Diesel" || data.Actor2==" Vin Diesel" || data.Actor3=="Vin Diesel" || data.Actor4=="Vin Diesel\"")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static List<IMDBData> Hundredmingenre(this IEnumerable<IMDBData> data)
            => (List<IMDBData>) data.Where(x => x.Runtime < 100).ToList<IMDBData>();
        public static List<IMDBData> windesieldirector(this IEnumerable<IMDBData> data)
            => (List<IMDBData>)data.Where(x => x.checkwin()==true)
            .ToList<IMDBData>();
        public static IMDBData best2016(this IEnumerable<IMDBData> data)
            => data.Where(x => x.Year == 2016).Aggregate((i1, i2) => i1.Votes > i2.Votes ? i1 : i2);

        public static List<IMDBData> bryansinger(this IEnumerable<IMDBData> data)
          => (List<IMDBData>)data.Where(x => x.Director == "Bryan Singer").ToList<IMDBData>();
        //dar chap kardanesh bayad nam va foroosh anha chap she//
        public static double sumrevenue(this IEnumerable<IMDBData> data)
          => (double)data.Where(x => x.Year == 2011).Sum(y => (double.Parse(y.Revenue)));
        public static List<IMDBData> top10action(this IEnumerable<IMDBData> data)
        => (List<IMDBData>)data.Where(x => x.Genre == "Action" && x.Runtime > 120).OrderByDescending(y=>y.Revenue).Take(10).ToList<IMDBData>();
        public static bool raqam(this string a)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]=='0' ||a[i]=='1' || a[i] == '2' || a[i] == '3' || a[i] == '4' || a[i] == '5' ||
                    a[i] == '6' || a[i] == '7' || a[i] == '8' || a[i] == '9')
                {
                    return true;
                }
            }
            return false;

        }

        //film hayi ke dar nameshan adad ast//
        public static List<IMDBData> adaddar(this IEnumerable<IMDBData> data)
           => (List<IMDBData>)data.Where(y => (bool)y.Title.raqam()== true).ToList<IMDBData>();

        public static List<IMDBData> lawrence(this IEnumerable<IMDBData> data)
            => (List<IMDBData>)data.Where(x => x.Actor1 == "\"Jennifer Lawrence" ||  x.Actor2 == " Jennifer Lawrence" || x.Actor3 == " Jennifer Lawrence"
             || x.Actor4 == "Jennifer Lawrence\"").OrderBy(y => y.Year).ThenBy(z => z.Rating).ToList<IMDBData>();
        public static List<IMDBData> anne(this IEnumerable<IMDBData> data)
            => (List<IMDBData>)data.Where(x => x.Actor1 == "\"Anne Hathaway" || x.Actor2 == " Anne Hathaway" || x.Actor3 == " Anne Hathaway"
             || x.Actor4 == "Anne Hathaway\"").OrderBy(y => y.Year).ThenBy(z => z.Rating).ToList<IMDBData>();

        public static List<string> comedy(this IEnumerable<IMDBData> data)
        => (List<string>)data.Where(x => x.Genre == "Comedy" && double.Parse(x.Rating)>8).Select(y => y.Title).ToList<string>();
        public static List<string> drama(this IEnumerable<IMDBData> data)
        => (List<string>)data.Where(x => x.Genre == "Drama" && double.Parse(x.Rating)>8).Select(y => y.Title).ToList<string>();
        //public static string badactor(this IEnumerable<IMDBData> data)
          //  => data.GroupBy(x => x.Actor1, x=> x.Actor2 ,x=>x.Actor3 ,x=> x.Actor4);

    }



    public class IMDBData
    {
        public IMDBData(string line)
        {
            var toks = line.Split(',');
            Rank = int.Parse(toks[0]);
            Title = toks[1];
            Genre = toks[2];
            Director = toks[3];
            Actor1 = toks[4];
            Actor2 = toks[5];
            Actor3 = toks[6];
            Actor4 = toks[7];
            Year = int.Parse(toks[8]);
            Runtime = int.Parse(toks[9]);
            Rating = (toks[10]);
            Votes = int.Parse(toks[11]);
            Revenue = toks[12].ParseStringOrNull();
            Metascore = toks[13].ParseIntOrNull();
        }
        public int Rank;
        public string Title;
        public string Genre;
        public string Director;
        public string Actor1;
        public string Actor2;
        public string Actor3;
        public string Actor4;
        public int Year;
        public int Runtime;
        public string Rating;
        public int Votes;
        public string Revenue;
        public Nullable<int> Metascore;
    }
}
