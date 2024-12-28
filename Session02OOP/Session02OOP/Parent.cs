using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal class Parent
    {
        //Property 
        private protected int Id { get; set; } 
        public string Name { get; set; }
        //Constructor
        public Parent(int _Id, string _Name)
        { 
            Id = _Id;   
            Name = _Name;   
        }
        //Method 
        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name}";
        }



    }
}
