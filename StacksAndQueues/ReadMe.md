# Stacks and Queues

##### Stack
Stacks are a First In Last Out data structure. They place Nodes on top of eachother as they are filled and then take the most recent node when things are removed.

##### Queue
Queues are a First In First Out data structure. They place Nodes in the back of the line and remove from the front of the line.

## Challenge
Implement Stacks and Queues in C#. Include the following Methods for Stacks: Push, Pop, Peek. Include the following Methods for Queues: Enqueue, Dequeue, Peek.

## Approach & Efficiency

##### Stack
The Stack implementation that I built is O(1) for Push, Pop, and Peek in Time. It is O(n) for space when using Push with a value because it creates a node. Pushing a Node that already exists is O(1) as are Pop and Peek.

##### Queue
The Queue implementation that I built is O(1) for Enqueue in Time, and O(n) worst case for Dequeue and Peek. This is because it uses 2 Stacks, in the worst case if all the Nodes are located in the Back Stack it must first Cycle all of them to the front.
The Queue is O(1) Space for Peek and Dequeue, and O(n) space for Enqueue.

## API

##### Stack

Push: Takes in either a value or a Node of the type in the Stack (ex: `Node<string>` for a `Stack<string>`) and places it at the Top of the Stack.
Usage: `stack.Push("Data")` or `stack.Push(node)`


Pop: Takes the Top Node of the Stack off the Stack and returns it.
Usage: `stack.Pop()`

Peek: Returns the Top Node of the Stack without removing it from the Stack.
Usage: `stack.Peek()`

##### Queue

Enqueue: Takes in a value of the type in the Queue and places it in the Back Stack of the Queue.
Usage: `queue.Enqueue("Data")`

Dequeue: If needed it moves all of the Back Stack to the Front Stack (if the Front is empty) before removing the Front Node and returning it.
Usage: `queue.Dequeue()`

Peek: If needed it moves all of the Back Stack to the Front Stack (if the Front is empty) before returning the Front Node without removing it.
Usage: `queue.Peek()`