using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Flowers myFlowerRose = new Flowers();  //create an object of class Flowers
            myFlowerRose.color1 = "Pink";
            myFlowerRose.numberOfPetals = 15;

            myFlowerRose.typeOfPlant(); //calling the method
            Console.WriteLine($"{myFlowerRose.color1} Rose with {myFlowerRose.numberOfPetals} petals.");


            Flowers myFlowerViola = new Flowers(); //create multiple class
            myFlowerViola.color1 = "Purple";
            myFlowerViola.numberOfPetals = 5;

            myFlowerRose.typeOfPlant(); //calling the method
            Console.WriteLine($"{myFlowerRose.color1} Rose with {myFlowerRose.numberOfPetals} petals.");
            Console.WriteLine();

            Console.WriteLine($"Rose color: {myFlowerRose.color}");
            Console.WriteLine($"Voila color: {myFlowerViola.color}");
            Console.WriteLine();

            //Create an object of class Flowers which will call the constructor and print the value 
            Flowers myFlowerDaisy = new Flowers();
            Console.WriteLine($"Daisy is {myFlowerDaisy.color1}");
            myFlowerDaisy.Fruit();
            myFlowerDaisy.tree();  
            Console.WriteLine();


            //Creating an object of class fruit(will call the constructor fruit)
            Fruits myApple = new Fruits("Apple", "Red", 4);     
            myApple.myFruit(); ///calling the method

            myApple.Season = "Summer";
            Console.WriteLine(myApple.Season);
            myApple.Fruit();

            myApple.TypeOfPlant = "Annual";
            Console.WriteLine(myApple.TypeOfPlant);

            Console.WriteLine($"Leaf Color: {myApple.leafColor}");

            myApple.inWinter();

            myApple.tree(); //calling abstract method
            Console.WriteLine();

            //Creating an object Vegetable 
            Vegetable myPumpkin = new Vegetable("Pumpkin", "Orange", 2);
            myPumpkin.myVegetable();
            myPumpkin.veggie();

            Size plantSize = Size.Medium; //access enum 
            Console.WriteLine(plantSize);


        }
    }
}
