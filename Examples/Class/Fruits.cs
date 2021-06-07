using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Fruits: Plants 
    {
        public string FruitName;
        public string FruitColor;
        public int FruitNumber;


        public Fruits(string nameOfFruit, string colorOfFruit, int NumberOfFruit) //constructor with parameters
        {
            FruitName = nameOfFruit;
            FruitColor = colorOfFruit;
            FruitNumber = NumberOfFruit;
        }

        public void myFruit() //Method
        {

            Console.WriteLine($"Fruit: {FruitName}, {FruitColor}, {FruitNumber}.");
        }


        //using get and set property

        private string season; //field
        public string Season //property
        {
            get { return season; }
            set { season = value; }
        }

        public string TypeOfPlant //property; using automatic short hand
        { get; set; }

        public override void tree() //body of abstract method
        {
            Console.WriteLine("This is a tree.");
        }
    }



}
