//going to use different concepts like array,for-loops,random-generator,methods,highest value 
//inside array compare strings

using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeatherStationStimulator
{
    internal class Program
    //Declares a class Program. internal means it is accessible inside the same assembly.
    //This class holds the program logic.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            //Creates an integer array temperature with days elements to store
            //daily temperatures.

            string[] conditions = { "Rainy", "Sunny",  "Cloudy", "Snowy" };
            //Defines an array conditions containing the possible weather types.

            string[] weatherConditions = new string[days];
            //Creates a string array weatherConditions with days elements to
            //store the randomly chosen condition for each day.

            Random random = new Random();
            //Instantiates a Random object used to generate random temperature
            //values and pick random weather conditions.

            for (int i = 0; i < days; i++)
               {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }
            //A for loop that runs once per simulated day (i goes from 0 to days-1).

            // temperature[i] = random.Next(-10, 40); picks a random integer
            // temperature between -10(inclusive) and 40(exclusive).

            // weatherConditions[i] = conditions[random.Next(conditions.Length)];
            // picks one of the strings from conditions at random and stores it for that day.

            Console.WriteLine($"Average Temperature is: {CalculateAverage(temperature)}");
            //Calls the CalculateAverage method (defined below) to compute the average of
            //the temperature array and prints it. Uses string interpolation ($"...")
            //to insert the result.

            Console.WriteLine($"The max temp was: {temperature.Max()}");
            Console.WriteLine($"The min temp was: {temperature.Min()}");
            //Prints the maximum and minimum values from the temperature array
            //using LINQ extension methods Max() and Min().


            //Console.WriteLine($"The min temp (via method) was: {MinTemperature(temperature)}");
            //This line is commented out. If enabled, it would call a custom
            //MinTemperature method (also defined below) to find the minimum.
            //Currently unused because temperature.Min() already does that.

            Console.WriteLine($"Most common condition is: {MostCommonCondition(weatherConditions)}");
            //Calls MostCommonCondition and prints the result.

            //Important note: this currently passes the conditions array
            //(the set { "Sunny","Rainy","Cloudy","Snowy"}) to the method.
            //That means it finds the most common value inside the conditions array itself
            //— which will always return the first value("Sunny") because each item appears once.
            //If your goal is to find the most common condition across the simulated days,
            //pass weatherConditions instead: MostCommonCondition(weatherConditions).
            Console.ReadKey();
        }

        //helper methods
        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];
            //MostCommonCondition takes a string array and returns the value that appears most often.
            //count stores the highest frequency found so far.
            //mostCommon stores the currently most frequent string (starts with the first element).

            for (int i=0;i< conditions.Length; i++)
                //This loop selects one condition at a time to check how many times it appears.
               // Think of it like saying:
//“Let me check how many times ‘Sunny’ appears.Now let me check how many times
//‘Cloudy’ appears... and so on.”
            {
                int tempCount = 0;
                for(int j=0;j<conditions.Length;j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
            //For each condition selected by the outer loop, this inner loop goes through the entire list again to count how many times it appears.

            //Example:

               // Let’s say the array is:

//["Sunny", "Rainy", "Sunny", "Cloudy", "Sunny"]
//When i = 0, we are checking "Sunny".
//Inner loop will compare "Sunny" to every element:
//Sunny == Sunny ✅ → count = 1
//Sunny == Rainy ❌
//Sunny == Sunny ✅ → count = 2
//Sunny == Cloudy ❌
//Sunny == Sunny ✅ → count = 3
//So "Sunny" appears 3 times.
                if (tempCount>count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }
//After counting occurrences of one condition(like "Sunny" = 3 times), we check:
//Is this number greater than the highest count we’ve seen so far?
//If yes, we update:
//count → store the new highest count
//mostCommon → store the condition that currently appears the most

        // Finding the average temperature
        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;
            for (int i = 0; i < temperature.Length; i++)
                //temperature.Length means for how many days the temperature stimulated.
            {
                sum += temperature[i];
            }

            return sum / temperature.Length;
        }
        //CalculateAverage takes an int[] and returns the arithmetic mean as a double.
        // Adds all temperatures into sum.
        //Divides by temperature.Length(number of days) and returns the average.


        // Custom method to find minimum temperature
        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }
        //MinTemperature scans the array and returns the smallest value.
//Starts with the first element as min, then updates min whenever it finds a smaller value.
//Equivalent to temperature.Min() but implemented manually.
    }

}

