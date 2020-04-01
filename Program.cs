/*
PAF KIET UNIVERSITY PROJECT
Subject: Programming Fundamentals
Semester: Spring 2020
Made By:
1. Danial Farooq Haider 11084
2. Yousuf Baloch 11495
3. Muhammad Haroon 11204.
*/

using System;

namespace PF_Project
{
    class Program
    {
        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Add shift to all.
                buffer[i] = Convert.ToChar(buffer[i] + shift);
                // Subtract 26 on overflow.
                if (buffer[i] > 'Z')
                {
                    buffer[i] = Convert.ToChar(buffer[i] - 26);
                }
                // Add 26 on underflow.
                else if (buffer[i] < 'A')
                {
                    buffer[i] = Convert.ToChar(buffer[i] + 26);
                }
            }
            return new string(buffer);
        }

        static void Main()
        {
            Console.Write("Please enter an unspaced alphabet string to encrypt: ");
            string DecryptedInput = Console.ReadLine().ToUpper();
            string EncryptedOutput = Caesar(DecryptedInput, 3).ToUpper();

            Console.WriteLine(DecryptedInput);
            Console.WriteLine(EncryptedOutput);
        }
    }
}