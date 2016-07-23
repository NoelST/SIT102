/*
Name: Chin Leong SAE TEO
Student number: 216020872
Student ID: csaeteo@deakin.edu.au
Unit: SIT102
Assignment: Project 1 Part 1
*/


using System;

namespace Proj1Part1
{
    class Program
    {
        static void Main()
        {
            //Declare variables
            string ChemicalName, Supplier;
            float Quantity, Cost, OverallRating;
            int YearPurchased, Toxicity, Flammability, Corrosiveness, Explosive, Harmful; //QN:Does it matter if YearPurchased is in int or string?

            //define constants - QN:Is the preference for definitions and delcarations on a single line?
            //QN:what is the difference between a constant and a variable?
            const float TOXICITY = 0.20F,
                        FLAMMIBILITY = 0.20F,
                        CORROSIVENESS = 0.145F,
                        EXPLOSIVE = 0.30F,
                        HARMFUL = 0.155F;

            //Displaying the appropriate prompts
            //Collecting the inputs
            Console.WriteLine("Enter the following chemical data");

            Console.Write("Chemical name > ");
            ChemicalName = Console.ReadLine(); //QN:Read and ReadLine

            Console.Write("Year purchased > "); //QN:Is it year purshased or year released?
            YearPurchased = int.Parse(Console.ReadLine());

            Console.Write("Supplier > ");
            Supplier = Console.ReadLine();

            Console.Write("Quantity (L/Kg) > ");
            Quantity = float.Parse(Console.ReadLine());

            Console.Write("Cost > ");
            Cost = float.Parse(Console.ReadLine());

            Console.WriteLine("Rate the following out of 10");

            Console.Write("Toxicity > ");
            Toxicity = int.Parse(Console.ReadLine());

            Console.Write("Flammability > ");
            Flammability = int.Parse(Console.ReadLine());

            Console.Write("Corrosiveness > ");
            Corrosiveness = int.Parse(Console.ReadLine());

            Console.Write("Explosive > ");
            Explosive = int.Parse(Console.ReadLine());

            Console.Write("Harmful > ");
            Harmful = int.Parse(Console.ReadLine());

            //Calculate overall rating
            //Sum of the individual ratings multiplied by the weights
            OverallRating = (Toxicity * TOXICITY) + (Flammability * FLAMMIBILITY) + (Corrosiveness * CORROSIVENESS) + (Explosive * EXPLOSIVE) + (Harmful * HARMFUL);

            //Output results to console
            //Using Math.Round to get an integer value for the overall rating
            Console.WriteLine("\nOverall rating is {0}/10: {1}", Math.Round(OverallRating), new string('*', 7));

        }
    }
}
