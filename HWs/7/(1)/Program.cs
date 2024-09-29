using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class program
    {
        class Vector<T> : IEquatable<Vector<T>>, IEnumerable<T>
        {
            List<T> majmoe = new List<T>();

            public Vector(int zarf = 0)
            {
                if (zarf < 0)
                    throw new Exception("zarfiat nemishe manfi bashe ");
            }

            public int Capacity => majmoe.Count();

            public void Add(T bakhsh)
            {
                majmoe.Add(bakhsh);
            }
            public override string ToString()
            {
                return "[" + string.Join(",", majmoe) + "]";
            }
            public IEnumerator<T> GetEnumerator()
            {
                foreach (var item in majmoe)
                    yield return item;
            }
            public bool Equals(Vector<T> m)
            {
                if (m == null)
                    return false;

                if (this.ToString() == m.ToString())
                    return true;
                else
                    return false;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
            


            public static Vector<T> operator +(Vector<T> aval, Vector<T> dovom)
            {
                if (aval.Capacity != dovom.Capacity)
                    throw new Exception("bordar ha zarfiateshoon yeki nist ke:) ");

                Vector<T> vector = new Vector<T>();
                var f = aval.majmoe;
                for (int i = 0; i < aval.Capacity; i++)
                    vector.Add((dynamic)aval.majmoe[i] + (dynamic)dovom.majmoe[i]);

                return vector;
            }
            public static bool operator !=(Vector<T> aval, Vector<T> dovom)
            {
                return aval.ToString() != dovom.ToString();
            }
            public static bool operator ==(Vector<T> aval, Vector<T> dovom)
            {
                return aval.ToString() == dovom.ToString();
            }
        }

        class Matrix<T> : IEquatable<T>, IEnumerable<T>
        {
            List<Vector<T>> maj = new List<Vector<T>>();

            public Matrix(int satr = 0, int soton = 0)
            {
                if (satr < 0 || soton < 0)
                    throw new Exception("satr ya soton nemitoone manfi bashe");
            }
            public Matrix(params Vector<T>[] t)
            {
                maj = new List<Vector<T>>(t);
            }
            public void Add(Vector<T> t) => maj.Add(t);
            public int satr => maj.Count;
            public int soton => maj.Count;

            public override string ToString()
            {
                int tedad = maj.Count;
                string a = " ";
                foreach (var c in maj)
                {
                    a = a + c.ToString();
                    tedad = tedad - 1;
                    if (tedad > 0)
                    {
                        a = a + ",\n";
                    }
                }

                return "[\n" + a + "\n]";
            }

            public bool Equals(T t)
            {
                if (t == null)
                    return false;

                if (this.ToString() == t.ToString())
                    return true;
                else
                    return false;
            }
            public IEnumerator<T> GetEnumerator()
            {
                foreach (var c in maj)
                    foreach (var d in c)
                        yield return d;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public static Matrix<T> operator +(Matrix<T> one, Matrix<T> two)
            {
                if (one.satr == 0 || two.satr == 0)
                    throw new Exception("hadaqal ye khoone matris moshkel dare :|");
                if (one.satr != two.satr)
                    throw new Exception("satr haye matris yeki nis:(");

                for (int i = 0; i < one.satr; i++)
                    if (one.maj[0].Capacity != one.maj[i].Capacity)
                        throw new Exception("size satr monaseb nis :(");
                for (int i = 0; i < two.satr; i++)
                    if (two.maj[0].Capacity != two.maj[i].Capacity)
                        throw new Exception("size matris ok nis ke :|");

                if (one.soton == 0 || two.soton == 0)
                    throw new Exception("hadaqal ye khoone matris moshkel dare :|");
                if (one.soton != two.soton)
                    throw new Exception("soton haye matris yeki nis:(");

                for (int i = 0; i < one.soton; i++)
                    if (one.maj[0].Capacity != one.maj[i].Capacity)
                        throw new Exception("size sotoon monaseb nis :(");
                for (int i = 0; i < two.satr; i++)
                    if (two.maj[0].Capacity != two.maj[i].Capacity)
                        throw new Exception("size matris ok nis ke :|");

                Matrix<T> mat = new Matrix<T>();
                for (int i = 0; i < one.satr; i++)
                    mat.Add(one.maj[i] + two.maj[i]);

                return mat;
            }

            public static bool operator ==(Matrix<T> one, Matrix<T> two)
            {
                return one.ToString() == two.ToString();
            }
            public static bool operator !=(Matrix<T> one, Matrix<T> two)
            {
                return one.ToString() != two.ToString();
            }
        }

        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            
            List<Vector<int>> vec = new List<Vector<int>>();
             
            vec.Add(new Vector<int>(2) { 1, 0 });
            vec.Add(new Vector<int>(3) { 0, 1, 5 });
            vec.Add(new Vector<int>(3) { 0, 1, 5 });

            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            Console.WriteLine(vec[0].ToString());

            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            try
            {
                Vector<int> vec3 = vec[0] +vec[1];
                Console.WriteLine(vec3.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //agar kar nakard khali nabashe:)  //
            Vector<int> v4 = vec[1] + vec[2];
            Console.WriteLine(v4.ToString());

            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            if (vec[2] == vec[1])
                Console.WriteLine("yeksan :)");
            else
                Console.WriteLine("na barabar :(");

            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            Matrix<int> mat1 = new Matrix<int>(2, 3)
            {
                new Vector <int >(3) {1, 2, 3},
                new Vector <int >(3) {3, -2, 0},
                new Vector<int>(3) {3,-2,0 }
            };
            Matrix<int> mat2 = new Matrix<int>(2, 3)
            {
                new Vector <int >(3) {3, 5, 2},
                new Vector <int >(3) {1, 2, 4},
                new Vector <int >(3) {0, 3, 2}
            };
            Matrix<int> mat3 = new Matrix<int>(2, 3)
            {
                new Vector <int >(3) {3, 5, 2},
                new Vector <int >(3) {1, 2, 4},
                new Vector<int>(3) {0,3,2}
            };


            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            Console.WriteLine(mat1.ToString());


            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            try
            {
                Matrix<int> mat4 = mat1 + mat3;
                Console.WriteLine(mat4.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            var mat5 = mat1 + mat3;
            Console.WriteLine(mat5.ToString());


            Console.WriteLine($"\n************(-----(:]***************\n number:{i}");
            i++;
            if (mat3 == mat2)
            {
                Console.WriteLine("yeksan hastand :)");
            }
            else
            {
                Console.WriteLine("yeki nistand :(");
            }
            string m = Console.ReadLine();
        }
        
    }
}