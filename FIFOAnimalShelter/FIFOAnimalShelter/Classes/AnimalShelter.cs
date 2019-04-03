using System;
using System.Text;
using StacksAndQueues.Classes;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Queue<DateTime> Cats { get; set; }
        public Queue<DateTime> Dogs { get; set; }

        /// <summary>
        /// Takes an animal and enqueues it.
        /// </summary>
        /// <param name="animal">The animal to enqueue.</param>
        public void Enqueue(Animal animal)
        {
            animal.Data = new DateTime();
            if (animal is Dog) Dogs.Enqueue(animal);
            else if (animal is Cat) Cats.Enqueue(animal);
        }

        /// <summary>
        /// Dequeues a specific animal type or the oldest animal.
        /// </summary>
        /// <param name="type">the Type of animal</param>
        /// <returns>The oldest animal of the requested type</returns>
        public Node<DateTime> Dequeue(string type = null)
        {
            if (type == "dog") return Dogs.Dequeue();
            else if (type == "cat") return Cats.Dequeue();
            else return (Dogs.Peek().Data.CompareTo(Cats.Peek().Data) < 0)? Dogs.Dequeue() : Cats.Dequeue();
        }
    }
}
