﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FillTheMatrixA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please enter matrix rows and cows");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[][] coolMatrix = new int[rows][];
            int fill = 1;
            for (int i = 0; i < coolMatrix.Length; i++)
            {
                coolMatrix[i] = new int[cols];
                
            }

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < coolMatrix.Length; row++)
                {
                    coolMatrix[row][col] = fill;
                    fill++;
                }
            }
            foreach (int[] subArray in coolMatrix)
            {
                foreach (int i in subArray)
                {
                    string a = Convert.ToString(i);
                    Console.Write("{0} ",a.PadRight(2));
                }
                Console.WriteLine();
            }
        }
    }
}