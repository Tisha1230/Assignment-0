using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Flowers: Plants //Inheritence (Plants: base class, Flowers: derived class)
    {
        public string color = "red";

        public string color1; //field
        public int numberOfPetals;  //filed

        public void typeOfPlant() //Method
        {
            Console.WriteLine("Annuals");
        }

        //create a class constructor
        public Flowers()
        {
            color1 = "White"; //set initial value
        }

        public override void Fruit() //polymorphism: by adding override in derived class and virtual keyword in base class, overrides the base class method
        {
            Console.WriteLine("No Fruits.");
        }

        public override void tree() //body of abstract method
        {
            Console.WriteLine("This is not a tree. ");
        }
    }
}
