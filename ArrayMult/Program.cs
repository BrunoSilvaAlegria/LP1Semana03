using System;
using System.Numerics;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {   //Arguments given
            foreach(string str in args)
            {   
                //Conversion string to int
                float s = float.Parse(str);

                //Declare and create a 2x2 array and a 2x1 array, respectively
                float[,] matrix1 = new float[2, 2];
                float[,] matrix2 = new float[2, 1];

                //Initialize it elements
                //Array 2x2
                matrix1[0, 0] = s;
                matrix1[0, 1] = s;
                matrix1[0, 2] = s;
                matrix1[0, 3] = s;
                matrix1[1, 0] = s;
                matrix1[1, 1] = s;
                matrix1[1, 2] = s;
                matrix1[1, 3] = s;
                matrix1[2, 0] = s;
                matrix1[2, 1] = s;
                matrix1[2, 2] = s;
                matrix1[2, 3] = s;
                matrix1[3, 0] = s;
                matrix1[3, 1] = s;
                matrix1[3, 2] = s;
                matrix1[3, 3] = s;

                //Array 2x1
                matrix1[0, 0] = s;
                matrix2[0, 1] = s;
                matrix2[1, 0] = s;
                matrix2[1, 1] = s;
                

                

                
            }
        }
    }
}
