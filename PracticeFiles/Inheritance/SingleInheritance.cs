using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeFiles.Inheritance
{
    public class SingleInheritance//Employee
    {
        public float salary = 40000;
    }
    public class Programmer:SingleInheritance
    {
        public float bonus = 10000;
    }
}
