using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal class TypeB:TypeA
    {

        public new void PrintHello()
        {
            Console.WriteLine("hello in class B");

        }

        public override void PrintHello2()
        {
            Console.WriteLine("hello in class B and class A virsual ") ;
        }
    }
}
