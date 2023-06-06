using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeFiles.Inheritance
{
    public class MethodOverriding//Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("I eat a Food");
        }
    }
    public class Dog2 : MethodOverriding
    {
        public override void eat()
        {
            Console.WriteLine("I eat a dog Food");
        }
    }
}
