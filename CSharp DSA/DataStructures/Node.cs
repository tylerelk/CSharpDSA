namespace CSharp_DSA.DataStructures;

public class Node
{
    public dynamic Value { get; set; }
    public Node? NextNode { get; set; }
    public Node? PreviousNode { get; set; }

    public Node(dynamic value)
    {
        Value = value;
        NextNode = null;
        PreviousNode = null;
    }

    public void Print()
    {
        Console.WriteLine(Value);
    }
}