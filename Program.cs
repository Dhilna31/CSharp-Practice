using System.Diagnostics;

namespace TryCatchExpection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }
            //throw keyword
            Console.WriteLine("Enter your age");
            GetUserAge(Console.ReadLine());

            static int GetUserAge(string input)
            {
                int age;
                if (!int.TryParse(input, out age))
                {
                    throw new Exception("You didn't enter a valid age.");
                }
                if (age < 0 || age > 120)
                {
                    Console.WriteLine("Your age must be between 0 and 120");
                }
                return age;
                int result = 0;

                Debug.WriteLine("Main method is running");

                //try-catch expection
                try
                {
                    Console.WriteLine("Please enter a number");
                    int num1 = int.Parse(Console.ReadLine());
                    //int num1 = 0;
                    int num2 = 2;
                    result = num2 / num1;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Don't divide by zero!!!" + ex.Message);
                    result = 10;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("I told you to enter a number" + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Number too high!");
                }

                //its the parent expection
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    //This next line is only executed during "Debugging".
                    Debug.WriteLine(ex.ToString());
                }

                //finally keyword
                //code to cleanup or finalize.ideal for cleaning up resources,like closing file streams or database connections.

                finally
                {
                    Console.WriteLine("This always executes");
                }
                Console.WriteLine("Result: " + result);

                Console.ReadKey();
            }
            static void LevelOne()
            {
                LevelTwo();
            }
            static void LevelTwo()
            {
                Console.WriteLine("Level two before throw!");
                throw new Exception("Something went wrong!");
                Console.WriteLine("Level two After throw!");
            }
        }
    }
}


