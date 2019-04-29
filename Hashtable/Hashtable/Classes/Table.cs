using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class Table
    {
        public int Size { get; set; }
        public LinkedList<Entry>[] Map { get; set; }

        public Table (int size)
        {
            Size = size;
            Map = new LinkedList<Entry>[size];
        }

        /// <summary>
        /// Takes in a key and value, Hashes the key and places an Entry instance into the HashTable at the hashed location.
        /// </summary>
        /// <param name="key">The key to hash for location</param>
        /// <param name="value">The value associated with the key</param>
        public void Add(string key, string value)
        {
            int hash = Hash(key);
            if (Map[hash] == null) Map[hash] = new LinkedList<Entry>();
            Map[hash].AddFirst(new Entry { Key = key, Value = value });

        }

        /// <summary>
        /// Takes in a key and returns the Entry for the key value pair if it is found.
        /// </summary>
        /// <param name="key">The key to search for and retrieve</param>
        /// <returns>The entry for the key presented</returns>
        public Entry Get(string key)
        {
            int hash = Hash(key);
            if (Map[hash] == null) return null;
            foreach (var entry in Map[hash])
            {
                if (entry.Key == key) return entry;
            }
            return null;
        }

        /// <summary>
        /// Takes in a key and checks if that key exists in the HashTable
        /// </summary>
        /// <param name="key">The key to check for</param>
        /// <returns>A boolean value on whether the key is present in the HashTable</returns>
        public bool Contains (string key)
        {
            int hash = Hash(key);
            if (Map[hash] == null) return false;
            foreach (var entry in Map[hash])
            {
                if (entry.Key == key) return true;
            }
            return false;
        }

        /// <summary>
        /// Takes in a key and converts it into an integer value
        /// </summary>
        /// <param name="key">The string key to hash</param>
        /// <returns>The integer value converted from the key</returns>
        public int Hash (string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash += key[i];
            }
            return (hash * 5987) % Size;
        }
    }
}
