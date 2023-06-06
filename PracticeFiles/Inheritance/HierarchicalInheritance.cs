using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeFiles.Inheritance
{
   public class HierarchicalInheritance//Animal
    {
        public string name;
        public void Name()
        {
            Console.WriteLine("hello I am Animal Class");
        }
    }
    public class Dog1:HierarchicalInheritance
    {
        public void dogname()
        {
            Console.WriteLine("my name is:"+name);
        }
    }
    public class bird : HierarchicalInheritance
    {
        public void birdname()
        {
            Console.WriteLine("my name is:"+name);
        }
    }
}
