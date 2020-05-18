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
            Console.Write("Please enter 'E' to encrypt or 'D' to decrypt: ");
            string choice = Console.ReadLine().ToUpper();

            
            
            if (choice == "E")
            {
                Console.Write("Please enter an unspaced alphabet string to encrypt: ");
                string decryptedInput = Console.ReadLine().ToUpper();
                Console.WriteLine("How many places do you want to shift the alphabets? Please enter a number: ");
                string shift = Console.ReadLine();
                string encryptedOutput = Caesar(decryptedInput, Convert.ToInt32(shift)).ToUpper();

                Console.WriteLine(decryptedInput);
                Console.WriteLine(encryptedOutput);
            }

            else if (choice == "D")
            {
                Console.Write("Please enter an unspaced alphabet string to decrypt: ");
                string encryptedInput = Console.ReadLine().ToUpper();
                Console.WriteLine("How many places do you want to shift the alphabets? Please enter a number: ");
                string shift = Console.ReadLine();
                string decryptedOutput = Caesar(encryptedInput, -Convert.ToInt32(shift)).ToUpper();

                Console.WriteLine(encryptedInput);
                Console.WriteLine(decryptedOutput);
            }

            Repeat();
        }

        static void Repeat()
        {
            Console.WriteLine("Do you want to encrypt or decrypt anything else? Enter 'Y' for yes or 'N' for no: ");
            string more = Console.ReadLine().ToUpper();
            if (more == "Y")
            {
                Main();
            }
        }
    }
}