using System;
using System.Globalization;
using System.Numerics;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture =
            CultureInfo.InvariantCulture;

            //Declaration and creation of a 2x2 array and a 2x1 array,
            //in this order
            float[,] matrixA = new float[2, 2];
            float[,] matrixB = new float[2, 1];

            //Add the first three arguments to matrix A 
            for(int i = 0; i < 3; i += 2){
                for(int j = 0; j < 2; j++){
                    matrixA[i/2, j] = float.Parse(args[i + j]);
                }
            }

            //Add the last two arguments to matrix B 
            matrixB[0,0] = float.Parse(args[4]);
            matrixB[1,0] = float.Parse(args[5]);

            //Matrix Result
            float[,] matrix_result = new float[2, 1];
            //Auxiliary variable
            float A_plus_B = 0;

            //Double cicle for that multiplies, adds and gives variables
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    //Multiplication of values and adds the result 
                    //to the auxiliary variable
                    A_plus_B += matrixA[i, j] * matrixB[j, 0];
                }
                //Value assignment
                matrix_result[i, 0] = A_plus_B;
                //Auxiliary variable reset
                A_plus_B = 0;
            }

            //Show all the values on the Matrix Result
            foreach(float value in matrix_result)
                    Console.WriteLine(value);

        }
    }
}