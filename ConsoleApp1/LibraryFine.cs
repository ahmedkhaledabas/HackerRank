using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LibraryFine
    {
        public int FineLibrary(int d1 ,int m1 , int y1,int d2 , int m2 , int y2)
        {
            if (y1 > y2) return 10000;
            else if (y2 > y1) return 0;
            else if (m1 > m2) return 500 * (m1 - m2);
            else if(m2 > m1) return 0;
            else if (d1 > d2) return 15 * (d1 - d2);
            return 0;
        }
    }
}
