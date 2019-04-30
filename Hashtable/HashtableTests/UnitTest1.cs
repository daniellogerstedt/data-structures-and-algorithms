using Hashtable.Classes;
using static Hashtable.Program;
using System;
using Xunit;

namespace HashtableTests
{
    public class UnitTest1
    {
        [Fact]
        public void testRepeatedWord()
        {
            string test = "test/string]test,string,this&is(a)test";
            string expected = "test";
            string actual = RepeatedWord(test);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testRepeatedWordNull()
        {
            string test = "test/string]null}value";
            string actual = RepeatedWord(test);
            Assert.Null(actual);
        }

        [Fact]
        public void testHash()
        {
            Table table = new Table(1024);
            int hash = table.Hash("a");
            Assert.Equal(131, hash);
        }

        [Fact]
        public void testAdd()
        {
            Table table = new Table(1024);
            Entry entry = null;
            table.Add("test", "test value");
            for (int i = 0; i < table.Map.Length; i++)
            {
                if (table.Map[i] != null)
                {
                    entry = table.Map[i].First.Value;
                }
            }
            Assert.Equal("test value", entry.Value);
        }

        [Fact]
        public void testGetEntry()
        {
            Table table = new Table(1024);
            Entry entry = null;
            table.Add("test", "test value");
            entry = table.Get("test");
            Assert.Equal("test value", entry.Value);
        }

        [Fact]
        public void testGetNull()
        {
            Table table = new Table(1024);
            table.Add("test", "test value");
            Entry entry = table.Get("null");
            Assert.Null(entry);
        }

        [Fact]
        public void testContainsTrue()
        {
            Table table = new Table(1024);
            table.Add("test", "test value");
            Assert.True(table.Contains("test"));
        }

        [Fact]
        public void testContainsFalse()
        {
            Table table = new Table(1024);
            table.Add("test", "test value");
            Assert.False(table.Contains("false"));
        }

    }
}
