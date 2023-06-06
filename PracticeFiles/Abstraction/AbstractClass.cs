using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeFiles.Abstraction
{
    public abstract class AbstractClass
    {
        public abstract void add(int x,int y);
    }
    public class World1 : AbstractClass
    {
        public override void add(int x,int y)
        {
            int c = x + y;
            Console.WriteLine("c:"+c);
        }
    }
}
