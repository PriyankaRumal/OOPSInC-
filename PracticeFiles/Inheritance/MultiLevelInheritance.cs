using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeFiles.Inheritance
{
    public class MultiLevelInheritance//animal
    {
        public void eat()
        {
            Console.WriteLine("Eating..");
        }
    }
    public class Dog:MultiLevelInheritance
    {
        public void bark()
        {
            Console.WriteLine("Barking..");
        }
       
    }
    public class BabyDog:Dog
    {
        public void weep()
        {
            Console.WriteLine("weeping..");
        }
    }
}
