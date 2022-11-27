using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duearray
{
     class ass2
    {
        public  virtual void Display()
        {
            Console.WriteLine("blesson saju");
        }
    }

    public class Dclass : ass2 //derived class
    {
        public override void Display()
        {
            Console.WriteLine("Welcome to Nest Digital");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            ass2 d = new ass2();
            d.Display();
            Dclass b = new Dclass();
            b.Display();

        }
    }
}
