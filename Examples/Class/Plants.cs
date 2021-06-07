using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    abstract class Plants //abstract class
    {
        public string leafColor = "Green"; //Plant field
        public void inWinter() //Plant Method
        {
           Console.WriteLine("No Leaves in winter.");
        }

        public virtual void Fruit() //polymorphism: by addind virtual in base class, lets you overrride the method if override is added in derived class
        {
            Console.WriteLine("Fruits Present");
        }

        public abstract void tree();  //abstract method, has no body in parent class
      
    }

    enum Size  //enum: a group of constants
    {
        Tall,
        Medium,
        Short
    }
}
