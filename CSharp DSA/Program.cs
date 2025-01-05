//This file is used as a sandbox to play around with the various data structures and algorithms within the solution

using CSharp_DSA.Algorithms;
using CSharp_DSA.DataStructures;

Node node1 = new Node(1);
Node node2 = new Node(2);
Node node3 = new Node(3);
Node node4 = new Node(4);
Node node5 = new Node(5);

Stack stack = new();

stack.Push(node1);
stack.Push(node2);
stack.Push(node3);
stack.Push(node4);
stack.Push(node5);

stack.Pop();

stack.Print();