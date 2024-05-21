using System;

//Printing Multidimensional Arrays


namespace Assignment_3._2._1
{
    class Program
    {
        static void Main()
        {
            int[,] array = new int[,] { { 2, 3, 4 }, { 1, 4, 6 } };

            PrintArray(array);
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                    if (j < array.GetLength(1) - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine("|");
            }
        }
    }
}
