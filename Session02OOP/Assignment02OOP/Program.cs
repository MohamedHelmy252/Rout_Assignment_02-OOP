using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {






           HiringDate mohamed = new HiringDate(10,12,2024);
            HiringDate saad = new HiringDate(12,1,2025);
            HiringDate salma = new HiringDate(12, 1, 2025);

            Employees[]employees = new Employees[3];
            employees[0] = new Employees(1, "mohamed", SecurityLevel.Developer, 10_000, mohamed, 'M');
            employees[1] = new Employees(2, "saad", SecurityLevel.Developer,9_000, saad, 'M');
            employees[2] = new Employees(3, "salma", SecurityLevel.Developer, 9_000, salma, 'F');
            //Display
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }


        }


    }
}
