using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duearray
{
     class ass3
    {
        public static void Main(string[] args)
        {
            string s = "Hello Welcome to Nest Digital and blesson saju";
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    count++;
            }


            Console.Write("Number of spaces = " + count);

        }
    }
}
