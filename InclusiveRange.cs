using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCardio
{
    class InclusiveRange
    {
        public int findLarger(int x, int y)
        {
            if ((x > y) && (x >= 20 && x <= 30) && (y >= 20 && y <= 30))
            {
                return x;
            }
            else if ((y > x) && (x >= 20 && x <= 30) && (y >= 20 && y <= 30))
            {
                return y;
            }
            else return 0;
            
        }


    }
}



/*Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range.*/