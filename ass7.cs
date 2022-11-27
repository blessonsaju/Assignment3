using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duearray
{
    class ass7
    {
        public int id;
        public string name;
        public int mark;
        public void read()
        {
            Console.WriteLine("Enter the id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark");
            mark = int.Parse(Console.ReadLine());
        }
        public void swap(ass7 val, ass7 val2)
        {
            ass7 temp = new ass7();
            temp = val;
            val = val2;
            val2 = temp;
            Console.WriteLine("After Swapping");
            val.display();
            val2.display();
        }
        public void display()
        {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Mark: {0}", mark);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            ass7 s1 = new ass7();
            ass7 s2 = new ass7();
            s1.read();
            s2.read();
            Console.WriteLine("Before Swapping");
            s1.display();
            s2.display();
            s1.swap(s1, s2);

            Console.ReadLine();
        }
    }
}
