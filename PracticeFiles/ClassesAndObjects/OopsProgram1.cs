using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeFiles.ClassesAndObjects
{
    public class OopsProgram1
    {
        public int id;
        public string name;
        public void insert(int i,string n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name);
        }
    }
}
