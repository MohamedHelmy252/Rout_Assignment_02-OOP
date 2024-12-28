using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal class Child:Parent
    {
        //Property
        public int Age { set; get; }
        //Constructor chaining 
        public Child(int _Id , string _Name , int _Age ):base(_Id,_Name)
        { 
            Age = _Age; 
        }

    }
}
