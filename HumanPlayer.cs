using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = 0;
            while (otherRoll > 6 || otherRoll < 1)
            {
                Console.WriteLine("What was your roll Human?: ");
                otherRoll = int.Parse(Console.ReadLine());
                if (otherRoll > 6 || otherRoll < 1)
                {
                    Console.WriteLine("between 1 & 6 plz");
                    otherRoll = int.Parse(Console.ReadLine());
                }
            }

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