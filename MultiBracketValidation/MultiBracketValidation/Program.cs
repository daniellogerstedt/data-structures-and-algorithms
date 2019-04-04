using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static bool Validate(string input)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                switch (current)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case ')':
                        if (!stack.Peek().Data.Equals(current)) return false;
                        stack.Pop();
                        break;
                    case ']':
                        if (!stack.Peek().Data.Equals(current)) return false;
                        stack.Pop();
                        break;
                    case '}':
                        if (!stack.Peek().Data.Equals(current)) return false;
                        stack.Pop();
                        break;
                }
            }
            if (stack.Peek() != null) return false;
            return true;
        }
    }
}
