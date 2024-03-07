using System;

namespace PowTwoUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling this method twice despite its location
            PowersOf2Until5();
            PowersOf2Until5();
        }
        
        private static void PowersOf2Until5() //Added another method
        {
            for(int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
            
        }
    }   
    
}
