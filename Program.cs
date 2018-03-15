using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InitualizeOPPCshrpMarch1418
{
    class Program
    {

        public class Dog
        {

            private string name, color;
            private int age;

            public Dog()
            {
                name = "Fido";
                age = 3;
                color = "Black";
            }

            // set
            public void setName (string name) { this.name = name; }

            public void setAge(int age) { this.age = age; }
            public void setColor(string color) { this.color = color; }

            // get

            public string getName() { return name; }
            public int getAge() { return age; }

            public string getColor() { return color; }

            public string bark() { return "\nWoof, woof!\n"; }


            
        }




        static void Main(string[] args)
        {

            Dog fido;
            fido = new Dog();

            string tagF = String.Format("{0} is a {1} year old {2} dog",
                fido.getName(),
                fido.getAge(),
                fido.getColor());

            Console.WriteLine(tagF + fido.bark());






        }
    }
}
