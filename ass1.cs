using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duearray
{
     class ass1
    {

         public string name;
         public int rollnum;

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll Number: " + rollnum);
        }
    }

    class abc
    {
        public static void Main(string[] args)
        {
            ass1 s1 = new ass1();
            s1.name = "saju";
            s1.rollnum = 1;

            ass1 s2 = new ass1();
            s2.name = "blesson";
            s2.rollnum = 2;

            s1.DisplayDetails();
            s2.DisplayDetails();
        }
    }
}

