using System;
using System.Collections;

namespace Console_Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[,] array2 = new int[4,3];
            Random rand = new Random();


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = array[j]; 

                    Console.Write(array2[i, j]);
                }
                Console.WriteLine(" ");
                
            }
            
            
        }
        
    }
}
