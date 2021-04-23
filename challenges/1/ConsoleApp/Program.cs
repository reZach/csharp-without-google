using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name, please: ");

            string name = Console.ReadLine();
            name = name.ToLower();

            int current = 0;
            char[] characters = name.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                // Convert to uppercase for first character,
                // and any letter following a space
                current = (int)name[i];
                if (i == 0 || ((int)name[i - 1] == 32 && current >= 97 && current <= 122))
                {
                    characters[i] = (char)((int)characters[i] - 32);
                }
            }

            Console.WriteLine($"Thank you {new string(characters)}!");
        }
    }
}
