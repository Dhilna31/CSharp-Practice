using System.Globalization;

namespace ListsApp
{
    public class Product
    {
        public string Name{get; set;}
        public string Price { get; set;}
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product> {
            new Product { Name = "Apple", Price = 0.80 },
            new Product { Name = "Banana", Price = 0.90 },
            new Product { Name = "Orange", Price = 0.10 },

            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();


            Console.WriteLine("Available Products for less than $1: ");

            // //iterate through the list
            foreach (Product product in products)
            {
                Console.WriteLine($"product name:{product.Name} for{product.Price}");
            }

            ////declaring and intializing the list
            List<string> colors = new List<string>();

            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("red");

            Console.WriteLine("Current colors in the colors list!");

            foreach (string color in colors)
            {

                Console.WriteLine(color);

            }

            ////removing an item from list
            bool isDeletingSuccessful = colors.Remove("red");

            ////deleting all same items from list
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("red");
            }


            Console.WriteLine("Current colors in the colors list!");

            foreach (string color in colors)
            {

                Console.WriteLine(color);

            }

            //sorting in a list
            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };
            Console.WriteLine("Unsorted List!");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            bool hasLargeNumber = numbers.Any(x => x > 30);

            if (hasLargeNumber)
            {
                Console.WriteLine("THere are large numbers in the numbers list");
            }
            else
            {
                Console.WriteLine("No large numbers in the list");
            }

            /*
             * In c# delegate is like a pointer or a reference to a method.
             * it allows you to pass methods as arguments to other methods,store them in variables,
             * and call them later.
             * this is useful when you want your code to be flexiable 
             * and able to handle different behaviours that aren't predetermined.
             */

            //Define the predicate to check if a number is greater than 10
            Predicate<int> isGreaterThanTen = x => x >= 10;

            ////findall
            ////this will return a list of numbers that are 10 and higher.
            List<int> higherWEqualTen = numbers.FindAll(isGreaterThanTen);

            //numbers.Sort();
            Console.WriteLine("All number 10 and higher in the list");
            foreach (int number in higherWEqualTen)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }

        //example for delegates
        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }

        //A lambda expression consists of 2 parts.
        //1.parameters
        //2.expression or statement block

        //parameters are written on the left side of => (this symbol is read as "goes to" or "becomes").the expression or action to perform is on the right side.

        //this reads as:
        //"take an input x and turn it into x multiplied by
        //x.x"
        //x => x*x;

        static int Squaring(int num1)
        {
            return num1 * num1;
        }
    }
}
