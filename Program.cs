string[] OriginalArray()
{
    Console.WriteLine("Input the number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string value = string.Empty;

    string[] originalArray = new string[size];
    
        for(int i = 0; i < size; i++)
        {
            while(value == String.Empty || value == null)
            {
                Console.WriteLine($"Input an element {i + 1}: ");
                value = Console.ReadLine();
            }
            originalArray[i] = value;
        }
    return originalArray;
}


