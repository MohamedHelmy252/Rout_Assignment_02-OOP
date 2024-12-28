using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{



    enum Gender
    {
        M, F
    }

    enum SecurityLevel
    {
        guest, Developer, secretary , DBA
    }








    internal class Employees
    {
        //⮚	Employee is identified by an ID, Name
        //, security level, salary, hire date and Gender.


        //Attributes 
      private  int Id;
      private  string Name;
      private SecurityLevel SecurityLevel;
      private decimal Salary;
      private HiringDate HireDate;
      private char gender;

     
        
     

        //Constructor
        public Employees(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
        { 
            Id = id; 
            Name = name;    
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        //Property

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    gender = '?';
                }

            }
        }




        //Method 

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , SecurityLevel : {SecurityLevel} , Salary : {Salary} , HireDate : {HireDate} , Gender : {gender}";
        }
    }
}
