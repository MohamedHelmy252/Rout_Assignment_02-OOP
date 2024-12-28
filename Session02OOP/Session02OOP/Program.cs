using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Besm Allh El Rhman El Rahim");

            #region Indexer 
            PhoneNote Note = new PhoneNote(3);
            Note.AddNewNumber(0, "mohamed", 01140898481);
            Note.AddNewNumber(1, "saad", 01240898481);
            Note.AddNewNumber(2, "ahmed", 01040898481);
            Note.AddNewNumber(3, "mohamed eid", 01540898481);
            //////Get Number By Name 
            //Console.WriteLine( Note.GetNumber("rana"));// Return(-1) Because Name Not Found
            //Console.WriteLine(Note.GetNumber("mohamed"));
            //Console.WriteLine(Note.GetNumber("mohamed eid"));// Return(-1) Because Name Not In Range Of Array  
            //////Set Number (Edit) By Name
            //Note.SetNumber("ahmed",1111);
            //Console.WriteLine(Note.GetNumber("ahmed"));//`1111

            //=========================================================================
            //===================Use Indexer ==========================================
            //=========================================================================
            //Console.WriteLine("======Indexer======");
            //Indexer => Is special Property  , Encapsulation Method 
            //1-Name Allows KeyWord => [(this)]
            //2-Can Take Parameter 


            //Note["mohamed"]=7777;//Set For Mohamed = 0000
            //Console.WriteLine(Note["mohamed"]);// = 7777


            #endregion
            #region Class  And Constructor Chainnig

            //  Car car1 = new Car(1,"BMW"); //Constructor 1  //Constructor 2
            // Car car1 = new Car("Frary");//Constructor 1  // Constructor 3





            #endregion
            #region Inheritance
            //Child mohamed = new Parent(1,"mo");//Invalid
            //Parent p1=new Parent (1,"ahmed"); //valid
            //Parent p2 = new Child(10,"ali",20);//valid
            //Console.WriteLine(p2);


            //Child c = new Child(110,"a",10);
            //Console.WriteLine(c);
            #endregion
            #region Relation 
            // inheritance  (is a)
            //Assosiation Aggregation (Has A)  B-->A اذا اتحذف اي كلاس لم يوثر علي الاخر
            //Compstion (Part Of)  B-->A  اذا اتحذف كلاس اي  يحذف بي 
            #endregion
            #region Polymorphism [overloading]
            //Console.WriteLine(sum(1,2));
            //Console.WriteLine(sum(2,3,4));    
            //Console.WriteLine(sum(3.6,4));
            //Console.WriteLine(sum(3, 4.6));


            #endregion
            #region Polymorphism [override] With Inheritance
            //TypeB typeB = new TypeB();
            //typeB.PrintHello();//hello in class A بدون معدل عليها 
            //typeB .PrintHello2 ();  //hello in class B and class A virsual

            #endregion


        }

        //Functions To explain Method Overloadinf
        #region
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sum(int x, int y,int z)
        {
            return x + y;
        }

        public static double sum(double x, int y)
        {
            return x + y;
        }
        public static double sum(int y, double x)
        {
            return x + y;
        }

        #endregion

    }
}
