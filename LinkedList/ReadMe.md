# Linked List
#### *Author: Daniel Logerstedt*

------------------------------

## Description

This is a C# implementation of a linked list. It instantiates the linked list initially with a null head. The class also has instance methods to insert a head at the beginning of the list, find if a value is present in the list, print the list to an array format, and get the length of the list.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the `Linked List` | O(1) | O(1) | myList.Insert(99) |
| Includes | Takes in a value and returns a boolean if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| Length | Iterates over the list and returns an integer value for the length | O(n) | O(1) | myList.Length() |
| Print | Prints the `Linked List` to the console | O(n) | O(n) | myList.Print() |


------------------------------

## Visuals

##### Insert Method
Insert first creates a new node using the value provided and the current head, it then replaces the current head with this new node. By doing this it causes the previous head to be the second node and the new node to take the place as the head.
![Insert Method](./assets/insert.PNG)

##### Includes Method
Includes first checks if the head is null and returns false if it is. After checking if head is null it looks at the first node for the value and then proceeds to iterate over the list and if it ever finds the value in the list it returns true. Returns false if it makes it to the end of the list without finding the value.
![Includes Method](./assets/includes.PNG)

##### Length Method
Length first checks if head is null, if so it returns 0. If the head is not null it iterates over the list and keeps count of the Nodes then returns the length.
![Length Method](./assets/length.PNG)

##### Print Method
Print first calls the Length method to get the length, it then makes an array of that size and iterates over the list adding each value into the array before returning the array.
![Print Method](./assets/print.PNG)

------------------------------

## Change Log