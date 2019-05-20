using System;
using Xunit;
using Trees.Classes;
using static Challenges.Program;

namespace TestChallenges
{
    public class UnitTest1
    {
        [Fact]
        public void TestHeight()
        {
            BinaryTree<bool> tree = new BinaryTree<bool>();
            tree.Root = new Node<bool> {
                Data = true,
                Left = new Node<bool> {
                    Data = true,
                    Left = null,
                    Right = null },
                Right = new Node<bool> {
                    Data = true,
                    Left = new Node<bool> {
                        Data = true,
                        Left = null,
                        Right = null },
                    Right = null }
            };

            int height = GetHeight(tree.Root);
            Assert.Equal(2, height);
        }

        [Fact]
        public void TestLevels()
        {
            BinaryTree<bool> tree = new BinaryTree<bool>();
            tree.Root = new Node<bool>
            {
                Data = true,
                Left = new Node<bool>
                {
                    Data = true,
                    Left = null,
                    Right = null
                },
                Right = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    },
                    Right = null
                }
            };

            int levels = GetLevels(tree.Root);
            Assert.Equal(3, levels);
        }

        [Fact]
        public void TestBalanced()
        {
            BinaryTree<bool> tree = new BinaryTree<bool>();
            tree.Root = new Node<bool>
            {
                Data = true,
                Left = new Node<bool>
                {
                    Data = true,
                    Left = null,
                    Right = null
                },
                Right = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    },
                    Right = null
                }
            };

            bool balance = CheckBalanced(tree.Root);
            Assert.True(balance);
        }

        [Fact]
        public void TestUnBalanced()
        {
            BinaryTree<bool> tree = new BinaryTree<bool>();
            tree.Root = new Node<bool>
            {
                Data = true,
                Left = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = new Node<bool>
                        {
                            Data = true,
                            Left = new Node<bool>
                            {
                                Data = true,
                                Left = null,
                                Right = null
                            },
                            Right = null
                        },
                        Right = null
                    },
                    Right = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    }
                },
                Right = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    },
                    Right = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = new Node<bool>
                        {
                            Data = true,
                            Left = null,
                            Right = null
                        }
                    }
                }
            };

            bool balance = CheckBalanced(tree.Root);
            Assert.False(balance);
        }

        [Fact]
        public void TestIsAncestor()
        {
            BinaryTree<bool> tree = new BinaryTree<bool>();
            Node<bool> descendant = new Node<bool>
            {
                Data = true,
                Left = null,
                Right = null
            };
            Node<bool> ancestor = new Node<bool>
            {
                Data = true,
                Left = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    },
                    Right = descendant
                },
                Right = null
            };
            tree.Root = new Node<bool>
            {
                Data = true,
                Left = new Node<bool>
                {
                    Data = true,
                    Left = ancestor,
                    Right = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    }
                },
                Right = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    },
                    Right = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = new Node<bool>
                        {
                            Data = true,
                            Left = null,
                            Right = null
                        }
                    }
                }
            };

            bool test = IsAncestor(ancestor, descendant, tree.Root);
            Assert.True(test);
        }

        [Fact]
        public void TestIsNotAncestor()
        {
            BinaryTree<bool> tree = new BinaryTree<bool>();
            Node<bool> descendant = new Node<bool>
            {
                Data = true,
                Left = null,
                Right = null
            };
            Node<bool> ancestor = new Node<bool>
            {
                Data = true,
                Left = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    },
                    Right = null
                },
                Right = null
            };
            tree.Root = new Node<bool>
            {
                Data = true,
                Left = new Node<bool>
                {
                    Data = true,
                    Left = ancestor,
                    Right = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = null
                    }
                },
                Right = new Node<bool>
                {
                    Data = true,
                    Left = new Node<bool>
                    {
                        Data = true,
                        Left = descendant,
                        Right = null
                    },
                    Right = new Node<bool>
                    {
                        Data = true,
                        Left = null,
                        Right = new Node<bool>
                        {
                            Data = true,
                            Left = null,
                            Right = null
                        }
                    }
                }
            };

            bool test = IsAncestor(ancestor, descendant, tree.Root);
            Assert.False(test);
        }
    }
}
