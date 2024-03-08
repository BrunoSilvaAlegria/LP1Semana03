using System;

namespace PlayerPowers
{
    [Flags]
    enum PlayerPowers
    {
        Fly,
        XRayVision,
        SuperStrength
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the player for the number of players
            Console.Write("How many players are playing? > ");
            string str = Console.ReadLine();

            //Converts the number from string to int and uses it to determine 
            //the size of the array
            int n = int.Parse(str);
            PlayerPowers[] array = new PlayerPowers[n];

            //
            for (int i = 0; i < array.Length; i++)
            {   //Players choose their powers
                Console.WriteLine("Powers: Fly, XRayVision, SuperStrength.");
                while (true)
                {
                    Console.Write($"Player {n} what powers would you like? > ");
                    string choice = Console.ReadLine();

                    PlayerPowers Perk = 0;

                    if (choice == "Fly")
                    {
                        Perk ^= PlayerPowers.Fly;

                    }

                    else if (choice == "Fly")
                    {
                        Perk ^= PlayerPowers.Fly;

                    }

                    else if (choice == "Fly")
                    {
                        Perk ^= PlayerPowers.Fly;

                    }

                    else
                    {
                        //If none of the options are used, then it'll print this
                        Console.WriteLine("Unknown perk!");
                        return;
                    }

                    Console.WriteLine("Thats it?");
                    Console.Write("Y -> Yes");
                    Console.Write("N -> No");
                    choice = Console.ReadLine();

                    if (choice == "Y")
                    {
                        array[i] = Perk;
                        break;
                    }


                }

            }

            for (int i = 0; i < array.Length; i++)
            {   //Special case
                Console.Write($"Player {i + 1} has: {array[i]}");
                if ((array[i] & PlayerPowers.SuperStrength) == 
                PlayerPowers.SuperStrength && (array[i] & PlayerPowers.Fly) == 
                PlayerPowers.Fly)
                {
                    Console.Write(", Flying radiation");
                }
                Console.WriteLine();
            }
        }
    }
}
