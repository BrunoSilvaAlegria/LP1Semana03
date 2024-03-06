using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a string
            Console.Write("Please write a string: >");
            string str = Console.ReadLine();

            //Asks the user for a character
            Console.Write("Please choose a character: >");
            char letter = Console.ReadLine()[0];

            //Scroll character by character through the string
            foreach (char ch in str)
            {
                //Detects if the character is equal to the one given by the user
                //If true, replaces the character for X
                if (ch == letter)
                {
                    Console.Write('X');
                }
                //If false, just writes the normal character  
                else
                {
                    Console.Write(ch);
                }
            }    
        }
    }
}
