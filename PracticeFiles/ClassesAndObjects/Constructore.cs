using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeFiles.ClassesAndObjects
{
    public class Constructore
    {
        public int id;
        public string name;
        public Constructore()
        {
            Console.WriteLine("Default Constructor");
        }
        public Constructore(int i,string n)
        {
            id=i;
            name=n;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name);
        }
    }
}
