using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<String> taunts = new List<string>();
        public CreativeSmackTalkingPlayer()
        {
        taunts.Add("You have a 90's haircut.");
        taunts.Add("You wreak of bad luck.");
        taunts.Add("I hate you.");
        }

        public void ShoutTaunt()
        {
        Random r = new Random();
        int randomTaunt = r.Next(0,2);
        Console.WriteLine(taunts[randomTaunt]);
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            ShoutTaunt();
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