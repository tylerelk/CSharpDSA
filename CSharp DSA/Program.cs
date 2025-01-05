//This file is used as a sandbox to play around with the various data structures and algorithms within the solution

using CSharp_DSA.Algorithms;
using CSharp_DSA.DataStructures;

LinkedList linkedList = new(new Node(3));

linkedList.InsertAtHead(2);
linkedList.InsertAtHead(1);

linkedList.InsertAtTail(4);
linkedList.InsertAtTail(5);
linkedList.InsertAtTail(6);

linkedList.InsertAfter("Inserted after", 4);

linkedList.Print();