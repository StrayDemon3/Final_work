string[] OriginalArray()
{
    Console.Write("Input the number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string value = String.Empty;

    string[] originalArray = new string[size];
    
        for(int i = 0; i < size; i++, value = String.Empty)
        {
            while(value == String.Empty || value == null)
            {
                Console.Write($"Input an element {i + 1}: ");
                value = Console.ReadLine();
            }
            originalArray[i] = value;
        }
    return originalArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
            Console.Write(", ");
        else 
            Console.Write(".");
    }
    
    Console.WriteLine();
}

string[] originalArray = OriginalArray();
ShowArray(originalArray);

string[] ElementFilter(string[] array)
{
    int size = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            size ++;
    }

    string[] myArray = new string[size];

    for(int i = 0, j = 0; i < array.Length; i++)
        {
            if(array[i].Length <= 3)
            {
                myArray[j] = array[i];
                j++;
            }
        }

    return myArray;
}
string[] myArray = ElementFilter(originalArray);
ShowArray(myArray);