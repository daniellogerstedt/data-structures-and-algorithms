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
The Queue implementation that I built is O(1) for Enqueue, Dequeue and Peek. It is also O(1) for space when Dequeuing and Peeking but O(n) in space for Enqueue.

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

Dequeue: Removes the Front Node and returning it. Sets the back to null if the Front.Next is null.
Usage: `queue.Dequeue()`

Peek: Returns the Front Node without removing it.
Usage: `queue.Peek()`