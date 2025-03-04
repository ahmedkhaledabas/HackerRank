using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ACMTeam
    {
        public List<int> CalcACMTeam(List<string> list)
        {
            //["10101" , "11110" , "00010" ]
            int n = list.Count;
            int maxTopics = 0;
            int teamCount = 0;

            for (int i = 0; i < n; i++) // i = 0 
            {
                for (int j = i + 1; j < n; j++) // j = 2
                {
                    int knownTopics = 0;
                    for(int k = 0; k < list[i].Length; k++) // k = 0
                    {
                        if (list[i][k] == '1' || list[j][k] == '1') // (list[0][0] == 1 ) || (list[2][0] == 1) => true
                        {
                            knownTopics++;  // 1
                        }
                    }
                    if (knownTopics > maxTopics)
                    {
                        maxTopics = knownTopics;
                        teamCount = 1;
                    }
                    else if (knownTopics == maxTopics) teamCount++;
                }
                
            }
            return new List<int> { maxTopics , teamCount };
        }

    }
}
