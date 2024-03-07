using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
    class Program
    {   
        static void Main(string[] args)
        {
            //Variable assigned to Perks and is going to be used as storage
            Perks HeroPerks = 0;
        foreach (char ch in args[0])
        {   //Determines what happens if a 'wasd' letter is registered
            switch (ch)
            {
                case 'w':
                    HeroPerks ^= Perks.WaterBreathing;
                    break;

                case 's':
                    HeroPerks ^= Perks.Stealth;
                    break;
                    
                case 'a':
                    HeroPerks ^= Perks.AutoHeal;
                    break;
                
                case 'd':
                    HeroPerks ^= Perks.DoubleJump;
                    break;

                default:
                //If none of the options below is used, then it'll print this
                    Console.WriteLine("Unknown perk!");
                    return;
            }
         
        
        //Detects if the player has no perks and prints exactly that
        if (HeroPerks == 0)
        {
            Console.WriteLine("No perks at all!");
        }
        //Detects if the player has perks and prints them
        else
        {
            Console.WriteLine($"Player perks: {HeroPerks}");
        }
        //Prints this combination
        if ((HeroPerks & Perks.Stealth) == Perks.Stealth && 
            (HeroPerks & Perks.DoubleJump) == Perks.DoubleJump)
        {
            Console.WriteLine("Silent jumper!");
        }
        //Confirms if AutoHeal is valid
        if ((HeroPerks & Perks.AutoHeal) != Perks.AutoHeal)
        {
            Console.WriteLine("Not gonna make it!");
        }
        }
        }

        
    }
}