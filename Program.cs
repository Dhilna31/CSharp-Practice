//Advanture Game


using System.Numerics;

Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your Character's name: ");
string playerName=Console.ReadLine();
Console.WriteLine("Choose your Character type Warrior,Wizard,Archer");
string characterType = Console.ReadLine();  

Console.WriteLine($"You, { playerName } the { characterType } find yourself at the edge of a dark forest");
Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

string choice1 =Console.ReadLine();

if(choice1.ToLower() =="enter")
    //Converts input to lowercase to make comparison case-insensitive.
   // If the player chooses "enter", they proceed into the forest; otherwise, they set up camp.
{
    Console.WriteLine("You bravely enter the forest");

}
else
{
    Console.WriteLine("you decide to camp out and wait for daylight.");
}

bool gameContinues = true;
//A boolean flag that controls the main game loop.

while (gameContinues)
//Starts a loop that runs as long as the game is active.
{
    Console.WriteLine("You come to a fork in the road.Go left or right?");
    string direction = Console.ReadLine();
    if(direction.ToLower() == "Left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (fight/flee)");
        string fightChoice = Console.ReadLine();
        if(fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if(luck > 5)
            {
                Console.WriteLine("you beat the wild beast!");
                if(luck > 8)
                {
                    Console.WriteLine("the wild beast dropped a treasure!");
                }
            }
            else
            {
                Console.WriteLine("the beast attacked you where you didn't expect it1");
                Console.WriteLine("it rammed it's tusks into your chest and you bleed out!");
                gameContinues = false;
            }
        }
    }
}

Console.WriteLine("game over!");
Console.WriteLine("thank you for playing the game!");

Console.ReadKey();