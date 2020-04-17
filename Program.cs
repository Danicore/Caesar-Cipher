/*
PAF KIET UNIVERSITY PROJECT
Subject: Programming Fundamentals 103471
Semester: Spring 2020
Topic: Caesar Cipher
Made By:
1. Danial Farooq Haider 11084
2. Yousuf Baloch 11495
3. Muhammad Haroon 11204
*/

using System;

namespace PF_Project
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter 'E' to encrypt or 'D' to decrypt: ");
            string choice = Console.ReadLine().ToUpper();
            
            if (choice == "E")
            {
                Console.Write("Please enter an unspaced alphabet string to encrypt: ");
                string decryptedInput = Console.ReadLine().ToUpper();
                string encryptedOutput = Caesar(decryptedInput, 3).ToUpper();

                Console.WriteLine(decryptedInput);
                Console.WriteLine(encryptedOutput);
            }

            else if (choice == "D")
            {
                Console.Write("Please enter an unspaced alphabet string to decrypt: ");
                string encryptedInput = Console.ReadLine().ToUpper();
                string decryptedOutput = Caesar(encryptedInput, -3).ToUpper();

                Console.WriteLine(encryptedInput);
                Console.WriteLine(decryptedOutput);
            }
        }

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
    }
}