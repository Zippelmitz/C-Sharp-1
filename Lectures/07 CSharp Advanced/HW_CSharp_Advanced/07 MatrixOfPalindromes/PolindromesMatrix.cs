﻿/*
Problem 7.	Matrix of Palindromes
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
Input	Output
3 6	aaa aba aca	ada aea afa
    bbb bcb bdb	beb bfb bgb
    ccc cec cdc	cfc cgc chc
 * 
2 3	aaa aba aca
    bbb bcb bdb
 * 
1 1	aaa
 * 
1 3	aaa aba aca
*/

using System;

class Palindromes
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        string[,] matrix = new string[height, width];

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
            }
        }

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}