// in strings \ is an "Escape Characters"
// \n stands for new line"
// \r-carriage return

using Microsoft.VisualBasic;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

string rocket = "    |\r\n    |\r\n   / \\\r\n  / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |    |\r\n ,'|  | |'.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";
//Declares a string variable named rocket which contains an ASCII art of a rocket.
// \r\n is used to add a new line, making the art display correctly in multiple lines.

for(int counter=10; counter>=0;counter--)
    //Starts a for loop that counts down from 10 to 0.
    //This will act as the launch countdown.
    {

    Console.Clear();
    //Clears the console screen on every loop iteration.
    //This creates an animation effect when the rocket moves upward.

    Console.WriteLine("Counter is " + counter);
    //Displays the current countdown number.

    Console.WriteLine(rocket);
    //Prints the rocket ASCII art to the screen.

    rocket = "\r\n" + rocket;
    //Adds a blank line above the rocket in each loop iteration.
    //This visually moves the rocket upward as the countdown progresses.

    Thread.Sleep(1000);
    //Pauses the program for 1000 milliseconds (1 second).
    //Ensures each frame of the animation is visible.
}
Console.WriteLine("The rocket has landed");
//After the loop finishes, this message is displayed.
//Small typo here: Change "as landed" to "has landed" for correct grammar.

Console.ReadKey();
//Waits for the user to press any key before closing the program.
