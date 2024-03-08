using System;

namespace PlayerPowers
{
    [Flags]
    enum PlayerPowers
    {
        Fly ,
        XRayVision ,
        SuperStrength
    }
    class Program
    {
        static void Main(string[] args)
        {   
            //Asks the player for the number of players
            Console.WriteLine("How many players are playing?");
            string str = Console.ReadLine();

            //Converts the number from string to int and uses it to determine 
            //the size of the array
            int n = int.Parse(str);
            int[] array = new int[n];

           


        }
    }
}
