static void linear_search()
{
    string[] items = { "orange", "banana", "apple", "strawberries", "rasberries", "pear", "grapefruit" };
    Console.WriteLine("Enter the fruit to find: ");
    string? itemToFind = Console.ReadLine();

    int index = 0;
    bool found = false;

    while (index < items.Length)
    {
        if (items[index] == itemToFind )
        {
            Console.WriteLine("Value found at index " + index);
            found = true;
            break;
        }
        index++;
    }

    if (found == false)
    {
        Console.WriteLine("Value not found");
    }

}

linear_search();