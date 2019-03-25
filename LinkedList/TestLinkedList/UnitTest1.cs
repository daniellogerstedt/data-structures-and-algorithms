using System;
using Xunit;
using LinkedList;

namespace TestLinkedList

    //Can successfully instantiate an empty linked list
    //Can properly insert into the linked list
    //The head property will properly point to the first node in the linked list
    //Can properly insert multiple nodes into the linked list
    //Will return true when finding a value within the linked list that exists
    //Will return false when searching for a value in the linked list that does not exist
    //Can properly return a collection of all the values that exist in the linked list
{
    public class UnitTest1
    {
        [Fact]
        public void TestLinkedListInstantiation()
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            Assert.Null(listToTest.head);
        }

        [Fact]
        public void TestAddNodeToLinkedList()
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            listToTest.Insert(1);
            Assert.Equal(1, listToTest.head.value);
        }
    }
}
