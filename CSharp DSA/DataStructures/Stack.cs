namespace CSharp_DSA.DataStructures;

public class Stack
{
    public int Length { get; set; } = 0;
    public Node? Top { get; set; }

    public void Push(Node node)
    {
        if (Top?.PreviousNode != null) Top.PreviousNode = node;
        node.NextNode = Top;
        Top = node;
        Length++;
    }

    public void Pop()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Top = Top.NextNode;
        Length--;
    }

    public void Print()
    {
        Node current = Top;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.NextNode;
        }
    }
}