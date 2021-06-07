using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Vegetable: IGarden //Vegetable "implements" the IGarden interface 
    {
        public string VegetableName;
        public string VegetableColor;
        public int VegetableNumber;

        public Vegetable(string nameOfVegetable, string colorOfVegetable, int numberOfVegetable) //constructor with parameters
        {
            VegetableName = nameOfVegetable;
            VegetableColor = colorOfVegetable;
            VegetableNumber = numberOfVegetable;

        }

        public void myVegetable() //method
        {
            Console.WriteLine($"Vegetable: {VegetableName}, {VegetableColor}, {VegetableNumber}");
        }
        public void veggie() //interface method body
        {
            Console.WriteLine("This is a Vegetable.");
        }
    }
}
