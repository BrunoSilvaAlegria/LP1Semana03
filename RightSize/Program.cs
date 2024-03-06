using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string str in args)
            {
                if (str.Length > 3 & str.Length <= 6)
                {
                    Console.WriteLine(str);
                }
                else if (str.Length > 6)
                {
                    return;
                }
            }
        }
    }
}
