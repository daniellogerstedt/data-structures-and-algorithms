using Hashtable.Classes;
using System;

namespace Hashtable
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

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
