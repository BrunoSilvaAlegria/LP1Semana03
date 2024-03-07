using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        WaterBreathing , Stealth , AutoHeal, DoubleJump
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
