## Calculate the height of a binary tree (4 Points)
Implement a method with the following signature int CalculateBinaryTreeHeight(Node root) that calculates the height of a binary tree.

Hint: The height of a binary tree is the height of its root

#### Solution:

The solution I built is recursive with O(h) Space and O(n) Time where h is the height of the callstack.

### Stretch Goal (1 Additional Point)
Once you calculate the height of a tree, write a similar function to calculate the number of levels for a tree.

#### Solution:

The solution I built is recursive with O(h) Space and O(n) Time where h is the height of the callstack.

## Check if a binary tree is Balanced (3 Points)
Implement a method with the following signature bool IsBinaryTreeBalanced(Node root) that determines if a binary tree is balanced.

Reminder: We define a balanced binary tree as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

#### Solution:

The solution I built is recursive with O(h) Space and O(n) Time where h is the height of the callstack.

## Determine if two values in a binary tree have an ancestry relationship. (3 Points)
Implement a method with the following signature bool IsAncestor(int A, int B, Node root) that returns true if the value A is an ancestor of the value B in the provided binary tree; the function will return false otherwise.

You can assume that the binary tree will have unique values.
A classical definition of ancestor nodes: “Any node present in the path from that node to the root node (including the root node)”


#### Solution:

The solution I built utilizes a private method I built named "Contains" which checks whether a given tree contains a specific node. It uses this to check if node 1 is in the tree and if node 2 is in the node 1 sub tree. The solution is O(w) Space and O(n) time where w is the width of the tree at its widest point.
