using Hashtable.Classes;
using System;
using System.Collections.Generic;
using Trees.Classes;

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
            if (str == null) return null;
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

        /// <summary>
        /// Takes in two binary trees and returns any values that are shared between the two trees
        /// </summary>
        /// <param name="one">The first binary tree</param>
        /// <param name="two">The second binary tree</param>
        /// <returns>The set of values shared by the trees</returns>
        public static List<int> TreeIntersection(BinaryTree<int> one, BinaryTree<int> two)
        {
            if (one == null || two == null) return null;
            if (one.Root == null || two.Root == null) return null;
            Table table = new Table(1024);
            List<int> list = new List<int>();
            foreach (var value in one.InOrder())
            {
                table.Add(value.ToString(), value.ToString());
            }

            foreach (var value in two.InOrder())
            {
                if (table.Contains(value.ToString()) && !list.Contains(value))
                {
                    list.Add(value);
                }
            }

            return list;
        }
    }
}
