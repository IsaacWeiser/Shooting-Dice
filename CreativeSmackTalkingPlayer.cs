using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Smacks
        {
            get
            {
                return new List<string>()
                {
                    "daaaayumn u bad!", "mmmmmhhhhmmmm... that's right!", "what r u 2? LMAO"
                };
            }
        }


        public override int Roll()
        {
            int rand = new Random().Next(0, 3);
            Console.WriteLine($"{Smacks[rand]} said {Name}");
            return base.Roll();
        }

    }
}