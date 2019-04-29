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

        public void Add(string key, string value)
        {
            int hash = Hash(key);
            if (Map[hash] == null) Map[hash] = new LinkedList<Entry>();
            Map[hash].AddFirst(new Entry { Key = key, Value = value });

        }

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
