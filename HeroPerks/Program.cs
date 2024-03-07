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
        foreach (char c in args[0])
        {   //Determines what happens if a 'wasd' letter is registered
            switch (c)
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
        }

        
    }
}