using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public void PromptRoll()
        {
        Console.WriteLine("Enter a number for a Roll! (1-6)");
        
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            PromptRoll();
            int myRoll = Roll();
            int otherRoll = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}