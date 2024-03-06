using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string str in args)
            {//Prints words with more than 3 characters and 
             //less/equal to 6 characters
                if (str.Length > 3 & str.Length <= 6) 
                {
                    Console.WriteLine(str);
                }
                
                //Detects if the word as more than 6 characters and 
                //exits the program if true
                else if (str.Length > 6)
                {
                    return;
                }
            }
        }
    }
}
