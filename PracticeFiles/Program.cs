using PracticeFiles.ClassesAndObjects;
using PracticeFiles.Inheritance;
using System;

namespace PracticeFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OopsProgram1 p1 = new OopsProgram1();
            //p1.insert(101, "Priyanka");
            //p1.display();
            //Constructore con=new Constructore();
            //Constructore con2 = new Constructore(101, "Priyanka");
            //con2.display();
            Programmer p1 = new Programmer();
            Console.WriteLine("salary:"+p1.salary);
            Console.WriteLine("Bounus:" +p1.bonus);
 
        }
    }
}
