using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                myRoll = otherRoll + 1;
                Console.WriteLine($"{Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                myRoll = otherRoll + 1;
                Console.WriteLine($"{Name} Wins!");
            }
        }
    }
}
