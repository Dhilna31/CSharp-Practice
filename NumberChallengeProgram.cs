//the while loop

Random random = new Random();

int secretNumber = random.Next(1,101);
//Generates a random number between 1 and 100 (inclusive of 1, exclusive of 101) and
//stores it in secretNumber.
int userGuess = 0;
//the player's guess.
int counter = 0;
//how many attempts the user makes.

Console.WriteLine("Guess the number i'm thinking of between 1 and 100");

while (userGuess != secretNumber)
//Starts a loop that will continue until the user guesses the correct number.
{
    counter++;
    //Increases the attempt counter by one every time the user makes a guess.
    Console.WriteLine("Enter your Guess:");
    userGuess = int.Parse(Console.ReadLine());
    if(userGuess < secretNumber)
    {
        Console.WriteLine("Too low! Try again.");
    } else if(userGuess > secretNumber)
        {
        Console.WriteLine("Too high! Try again");
    }
    else
    {
        Console.WriteLine("Congratualtions! you guessed the number right! It took you" + counter + "tries!");
    }
}
Console.ReadKey();
