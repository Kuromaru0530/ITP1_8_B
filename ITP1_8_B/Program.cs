using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_8_B
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                string Input = Console.ReadLine();
                if (Input == "0") break;
                int ans = 0;
                foreach(char num in Input)
                {
                    int integer = (int)Char.GetNumericValue(num);
                    ans += integer;
                }
                Console.WriteLine(ans);
            }
        }
    }
}