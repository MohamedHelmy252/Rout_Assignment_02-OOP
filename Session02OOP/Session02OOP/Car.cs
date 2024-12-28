using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal class Car
    {
        public int       Id { set; get; }
        public string Model { set; get; }
        public decimal Speed { set; get; }


        //Constructor And  Constructor Chainning

        public Car(int _Id , string _Model , decimal _Speed)
        {
            Console.WriteLine("Constructor 1 ");
            Id = _Id;
            Model = _Model;
            Speed = _Speed;
        }

        public Car(int _Id, string _Model):this (_Id , _Model,120)
        {
            Console.WriteLine("Constructor 2 ");
            //Id = _Id;
            //Model = _Model;
            //Speed = 120;

            //Not Clean Code
        }

        public Car(string _Model):this(10,_Model,200)
        {
            Console.WriteLine("Constructor 3 ");
        }



    }
}
