﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duearray
{
    internal class ass6
    {
        public int id, mark1, mark2, mark3, total;
        public string name;
        public void read()
        {
            Console.WriteLine("Enter id ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter mark1 ");
            mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark2 ");
            mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark3 ");
            mark3 = int.Parse(Console.ReadLine());
        }
        public void calculate()
        {
            total = mark1 + mark2 + mark3;
        }
        public void display()
        {
            Console.WriteLine("id=" + id);
            Console.WriteLine("name=" + name);
            Console.WriteLine("mark1=" + mark1);
            Console.WriteLine("mark2=" + mark2);
            Console.WriteLine("mark3=" + mark3);
            Console.WriteLine("total=" + total);
        }
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of students");
            n = int.Parse(Console.ReadLine());
            ass6[] s = new ass6[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = new ass6();
                s[i].read();
                s[i].calculate();
                s[i].display();
            }
        }
    }
}
