using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string str in args)
            {
                if (str.Length > 3)
                {
                    Console.WriteLine(str);
                }
                
                
             
            }
        }
    }
}
