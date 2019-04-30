using Hashtable.Classes;
using System;

namespace Hashtable
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// Takes in a string and returns the first repeated word within that string.
        /// </summary>
        /// <param name="str">The string to be checked.</param>
        /// <returns>The first repeated word</returns>
        public static string RepeatedWord(string str)
        {
            char[] delimiters = { ' ', ',', '.', '\\', ';', ':', '/', '<', '>', '"', '&', '*', '(', ')', '!', '@', '#', '$', '%', '^', '-', '_', '+', '=', '\'', '[', ']',  '|', '`', '~', '\n', '\t' };

            string[] words = str.Split(delimiters);

            Table table = new Table(1024);

            for (int i = 0; i < words.Length; i++)
            {
                if (table.Contains(words[i])) return words[i];
                table.Add(words[i], words[i]);
            }

            return null;
        }
    }
}
