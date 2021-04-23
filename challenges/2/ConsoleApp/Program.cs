using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "My test string";
            temp = temp.Reverse();

            Console.WriteLine(temp);
        }
    }

    public static class Extensions
    {
        public static string Reverse(this string str)
        {
            string reversed = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
    }
}
