using System;
using System.Text;
using StacksAndQueues.Classes;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Queue<DateTime> Cats { get; set; }
        public Queue<DateTime> Dogs { get; set; }

        public void Enqueue(Animal animal)
        {
            animal.Data = new DateTime();
            if (animal is Dog) Dogs.Enqueue(animal);
            else if (animal is Cat) Cats.Enqueue(animal);
        }

        public Node<DateTime> Dequeue(string type)
        {
            if (type == "dog") return Dogs.Dequeue();
            else if (type == "cat") return Cats.Dequeue();
            else return (Dogs.Peek().Data.CompareTo(Cats.Peek().Data) < 0)? Dogs.Dequeue() : Cats.Dequeue();
        }
    }
}
