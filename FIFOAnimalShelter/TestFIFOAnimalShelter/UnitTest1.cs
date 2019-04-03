using System;
using Xunit;
using FIFOAnimalShelter.Classes;
using StacksAndQueues.Classes;

namespace TestFIFOAnimalShelter
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueueCat()
        {
            AnimalShelter shelter = new AnimalShelter() { Cats = new Queue<DateTime>(), Dogs = new Queue<DateTime>() };
            DateTime testData = new DateTime();
            Cat testCat = new Cat { Data = testData };
            shelter.Enqueue(testCat);

            Assert.Equal(testData, shelter.Cats.Peek().Data);
        }
    }
}
