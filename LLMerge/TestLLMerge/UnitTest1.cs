using System;
using Xunit;
using SLinkedList.Classes;
using static LLMerge.Program;

namespace TestLLMerge
{
    public class UnitTest1
    {
        [Fact]
        public void TestMergeLinkedListsEqualSizeLists()
        {
            LinkedList listOne = new LinkedList();
            listOne.Append(1);
            listOne.Append(3);

            LinkedList listTwo = new LinkedList();
            listTwo.Append(2);
            listTwo.Append(4);

            Node mergedTest = MergeLists(listOne, listTwo);

            int i = 1;
            while (mergedTest != null)
            {
                Assert.Equal(i, mergedTest.Value);
                i++;
                mergedTest = mergedTest.Next;
            }

        }

        [Fact]
        public void TestMergeLinkedListsLongerFirstList()
        {
            LinkedList listOne = new LinkedList();
            listOne.Append(1);
            listOne.Append(3);
            listOne.Append(4);

            LinkedList listTwo = new LinkedList();
            listTwo.Append(2);

            Node mergedTest = MergeLists(listOne, listTwo);

            int i = 1;
            while (mergedTest != null)
            {
                Assert.Equal(i, mergedTest.Value);
                i++;
                mergedTest = mergedTest.Next;
            }

        }

        [Fact]
        public void TestMergeLinkedListsLongerSecondList()
        {
            LinkedList listOne = new LinkedList();
            listOne.Append(1);

            LinkedList listTwo = new LinkedList();
            listTwo.Append(2);
            listTwo.Append(3);
            listTwo.Append(4);

            Node mergedTest = MergeLists(listOne, listTwo);

            int i = 1;
            while (mergedTest != null)
            {
                Assert.Equal(i, mergedTest.Value);
                i++;
                mergedTest = mergedTest.Next;
            }

        }

        [Fact]
        public void TestMergeLinkedListsNoFirstList()
        {
            LinkedList listOne = new LinkedList();

            LinkedList listTwo = new LinkedList();
            listTwo.Append(1);
            listTwo.Append(2);
            listTwo.Append(3);
            listTwo.Append(4);

            Node mergedTest = MergeLists(listOne, listTwo);

            int i = 1;
            while (mergedTest != null)
            {
                Assert.Equal(i, mergedTest.Value);
                i++;
                mergedTest = mergedTest.Next;
            }

        }

        [Fact]
        public void TestMergeLinkedListsNoSecondList()
        {
            LinkedList listOne = new LinkedList();
            listOne.Append(1);
            listOne.Append(2);
            listOne.Append(3);
            listOne.Append(4);

            LinkedList listTwo = new LinkedList();

            Node mergedTest = MergeLists(listOne, listTwo);

            int i = 1;
            while (mergedTest != null)
            {
                Assert.Equal(i, mergedTest.Value);
                i++;
                mergedTest = mergedTest.Next;
            }

        }

        [Fact]
        public void TestMergeLinkedListsNoLists()
        {
            LinkedList listOne = new LinkedList();

            LinkedList listTwo = new LinkedList();

            Node mergedTest = MergeLists(listOne, listTwo);

            Assert.Null(mergedTest);

        }
    }
}
