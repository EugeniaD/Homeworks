using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    class Human
    {
        public string name;
        public int age;
        public void SayHi()
        {
            Console.WriteLine($"{name}, Hi!");
        }
        public Human(string name)
        {
            this.name = name;
        }
       
        public Human(int age)
        {
            this.age = age;
            name = "Undefined";
        }
        public Human(string name = "name", int age=-1)
        {
            this.name = name;
            this.age = age;
            SayHi();
        }

        public void GetInfo()
        {
            Console.WriteLine($"name {name}, age {age}");
        }
    }
}
