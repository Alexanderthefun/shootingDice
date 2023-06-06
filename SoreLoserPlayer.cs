using System;

namespace ShootingDice
{

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
           
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
                try
                {
                    Console.WriteLine("Let's try again, double or nuthing!");
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} {Name} flips the table and storms off, middle finger in the air!");
                }
            }
            else
            {
               
                Console.WriteLine("It's a tie");
            }
        }
    }
}