using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override void Play(Player other)
        {
           
            int myRoll = Roll();
            int otherRoll = other.Roll();
            if (myRoll <= 3)
            {
                Random r = new Random();
                myRoll = r.Next(4,7);
            }
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