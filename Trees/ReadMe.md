# Trees
A tree is a data structure that contains a Root Node, Each Node has 2 or more child nodes none of which point toward a node farther up the chain.

Binary Trees have 2 child nodes on each node.
Binary Search Trees are special types of Binary Trees in which all the nodes are comparable values in order with the lower values to the left and higher values to the right.

## Challenge
Implement a Binary Tree and BST

The Binary Tree should have PreOrder, InOrder, and PostOrder traversals

The BST should have AddNode and Contains methods

## Approach & Efficiency

PreOrder is O(n) time and O(H) space where H is the height of the callstack
InOrder is O(n) time and O(H) space where H is the height of the callstack
PostOrder is O(n) time and O(H) space where H is the height of the callstack

AddNode is O(log n) time and O(H) space where H is the height of the callstack
Contains is O(log n) time and O(1) space.

## API

PreOrder traversal moves across the tree adding the current node to a list then calling itself on the left node and right node in that order. It then returns the list at the end.

InOrder traversal moves across the tree calling itself on the left node, adding the current node to a list then calling itself on the right node in that order. It then returns the list at the end.

PostOrder traversal moves across the tree calling itself on the left node and right node in that order then adding the current node to a list. It then returns the list at the end.

AddNode searches the tree for the location the node should be and then adds it into the tree.

Contains searches the tree for the node and if found returns true, otherwise returns false.
