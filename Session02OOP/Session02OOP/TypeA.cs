using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal class TypeA
    {
        public int x;
        //
        public void PrintHello()
        {
            Console.WriteLine("hello in class A");
        }

        public  virtual void PrintHello2() { Console.WriteLine("hello2"); }
    }
}
