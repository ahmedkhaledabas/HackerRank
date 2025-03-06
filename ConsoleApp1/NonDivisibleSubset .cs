using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NonDivisibleSubset
    {
        public int nonDivisibleSubset(int k, List<int> s)
        {
            int[] remainderCount = new int[k];

            foreach (int num in s)
            {
                remainderCount[num % k]++;
            }

            int result = Math.Min(remainderCount[0], 1);

            for (int i = 1; i <= k / 2; i++)
            {
                if (i == k - i)
                    result += Math.Min(remainderCount[i], 1);
                else
                    result += Math.Max(remainderCount[i], remainderCount[k - i]);
            }

            return result;
        }
    }
}
