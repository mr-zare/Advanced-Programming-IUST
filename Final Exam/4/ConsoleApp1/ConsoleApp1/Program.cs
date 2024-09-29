using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        class GenCol<T1> : IEnumerable<T1> where T1:IComparable<T1>
        {
            List<T1> m = new List<T1>();
            public void add(T1 a,T1 b)
            {
                if(a.CompareTo(b)>0)
                {
                    m.Add(b);
                }
                else
                {
                    m.Add(a);
                }
                sort1();
            }
            public T1 Remove()
            {
                T1 temp=m[0];
                for(int i=0;i<m.Count;i++)
                {
                    if(temp.CompareTo(m[i])<0)
                    {
                        temp = m[i];
                    }
                }
                m.Remove(temp);
                sort1();
                return temp;
            }
            public List<T1> sort1()
            {
                T1 temp;
                for (int i = 0; i < m.Count; i++)
                {
                    for (int k = 0; k < m.Count - 1; k++)
                    {
                        if (m[k].CompareTo(m[k + 1]) > 0)
                        {
                            temp = m[k];
                            m[k] = m[k + 1];
                            m[k + 1] = m[k];
                        }
                    }
                }
                return m;
            }
            IEnumerator<T1> IEnumerable<T1>.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
