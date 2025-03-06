using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AppendAndDeleteChars
    {
        public bool AppendAndDelete(string s1, string s2, int k)
        {
            //s1 = hackerhappy => length = 10
            //s2 = hackerrank  => length = 10
            // k = 9
            // need => s1 == s2
            string sameChars = string.Empty;
            for (int i = 0; i < s2.Length; i++)
            {
                if (i == s1.Length || i == s2.Length ) break;
                    if (s1[i] == s2[i])
                {
                    sameChars+=(s2[i]); // hacker => length = 5
                    continue;
                }
                else
                {
                    break;
                }
            }
            int numOfDeletedChars = s1.Length - sameChars.Length;
            if (numOfDeletedChars > k) return false;
           
            for(int i = sameChars.Length; i < s2.Length; i++)
            {
                sameChars+=(s2[i]) ;
                numOfDeletedChars++;
                if (numOfDeletedChars > k) return false;
                if(i == s2.Length-1 )
            }

          
            return sameChars == s2 ;
        }
    }
}
