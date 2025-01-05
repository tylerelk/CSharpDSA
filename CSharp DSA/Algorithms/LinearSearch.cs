namespace CSharp_DSA.Algorithms;

public class LinearSearch
{
    private List<dynamic> Example { get; set; }

    public LinearSearch(List<dynamic> example)
    {
        Example = example;
    }
    
    //Search for anything in the Example list. If not found, return -1, if found return index
    public void Search(dynamic element)
    {
        var foundIndex = -1;
        var steps = 0;
        for (var i = 0; i < Example.Count; i++)
        {
            if (element.Equals(Example[i]))
            {
                foundIndex = Example.IndexOf(element);
                break;
            }
            steps++;
        }
        var result = foundIndex == -1 ? "Search term not found" : $"Search term {element} found at index {foundIndex}";
        Console.WriteLine(result);
        Console.WriteLine($"Operation took {steps} steps");
    }
}