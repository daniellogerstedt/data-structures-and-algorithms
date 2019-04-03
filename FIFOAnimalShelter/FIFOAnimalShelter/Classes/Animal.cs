using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace FIFOAnimalShelter.Classes
{
    public class Animal : Node<DateTime>
    {
        new public DateTime Data { get; set; }
    }
}
