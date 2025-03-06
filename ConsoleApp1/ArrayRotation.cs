using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayRotation
    {
        public List<int> CircularArrayRotation(List<int> a , int k , List<int> q)
        {
            List<int> result = new List<int>();

            for(int i = 1; i <= k; i++)
            {
                int lastElement = a[^1];
                a.RemoveAt(a.Count-1);
                a.Insert(0, lastElement);
            }
            for(int i = 0; i < q.Count; i++)
            {
                result.Add(a[q[i]]);
            }
            return result;
        }
    }
}
