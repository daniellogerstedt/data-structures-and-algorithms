# Multi Bracket Validation
Validation is a method that takes in a string, goes through it character by character and verifies that all opening brackets have a matching closing bracket (and vise versa).

## Challenge
Write a method that takes in a string, and validates whether or not it has the correct sequence of brackets. Return true for correctly formatted strings and false for incorrectly formatted strings.

## Approach & Efficiency
The method built iterates through the string one character at a time pushing openning brackets into a stack and validating order of closing brackets against that stack.
it is O(n) for time and space in worst case.

## Solution

<img src="./assets/challenge13solution.JPG" height=500 />