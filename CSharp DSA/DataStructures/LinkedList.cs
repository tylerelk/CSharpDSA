namespace CSharp_DSA.DataStructures;

public class LinkedList
{
    private Node Head { get; set; }
    private Node Tail { get; set; }
    private int Length { get; set; }

    public LinkedList(Node head)
    {
        Head = head;
        Tail = head;
        Length = 1;
    }

    public void Print()
    {
        var current = Head;
        while (current != null)
        {
            current.Print();
            current = current.NextNode;
        }
    }

    public void InsertAtHead(dynamic value)
    {
        Node newNode = new(value);
        Head.PreviousNode = newNode;
        newNode.NextNode = Head;
        Head = newNode;
        Length++;
    }

    public void InsertAtTail(dynamic value)
    {
        Node newNode = new(value);
        Tail.NextNode = newNode;
        newNode.PreviousNode = Tail;
        Tail = newNode;
        Length++;
    }

    public void InsertAfter(dynamic value, dynamic term)
    {
        Node newNode = new(value);
        Node current = Head;
        while (current != null)
        {
            if (current.Value == term)
            {
                newNode.NextNode = current.NextNode;
                newNode.PreviousNode = current;
                current.NextNode = newNode;
                if (newNode.NextNode != null) newNode.NextNode.PreviousNode = newNode;
                Length++;
                break;
            }
            else
            {
                current = current.NextNode;
            }
        }
    }

    public void UpdateNode(dynamic term, dynamic value)
    {
        Node current = Head;
        while (current != null)
        {
            if (current.Value.GetType() == term.GetType() && current.Value == term)
            {
                current.Value = value;
                Console.WriteLine($"Value {term} updated to {value}");
                return;
            }
            current = current.NextNode;
        }
        Console.WriteLine($"Search term {term} was not found");
    }

    public void DeleteNode(dynamic term)
    {
        Node current = Head;
        while (current != null)
        {
            if (current.Value.GetType() == term.GetType() && current.Value == term)
            {
                if (current.PreviousNode != null) current.PreviousNode.NextNode = current.NextNode;
                if (current.NextNode != null) current.NextNode.PreviousNode = current.PreviousNode;
                if (Head == current) Head = current.NextNode;
                if (Tail == current) Tail = current.PreviousNode;
                Console.WriteLine($"Value {term} deleted successfully");
                Length--;
                return;
            }
            current = current.NextNode;
        }
        Console.WriteLine($"{term} was not found");
    }
}