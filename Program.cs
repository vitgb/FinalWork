// FinalWork
string [] CreateArray1 (int size)
{
    string [] Array1 = new string[size];
    
    for(int i = 0; i < size; i++)
    {
        
        Console.Write($"Enter text for the {i+1}th element of the array: ");
        Array1[i] = Console.ReadLine(); 
    }
    
    return Array1;
}

void ShowArray (string[] Array)

{
    for(int i = 0; i < Array.Length; i++)
        
        Console.Write("[" + Array[i] + "]" + " " );

    Console.WriteLine();
}

string [] CreateArrayThreeSymbol (string[] Array1)
{
    
    int count = 0;
    string [] Array2 = new string [Array1.Length];
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3)
        {
            Array2[count] = Array1[i];
            count++;
        }
    }
    return Array2;
}

void ShowArray2 (string[] Array2)

{
    for(int i = 0; i < Array2.Length; i++)
        
        Console.Write("[" + Array2[i] + "]" + " " );

    Console.WriteLine();
}



Console.Write("Enter the number of words: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] ArrayUser = CreateArray1 (n);
ShowArray (ArrayUser);
Console.WriteLine();

ShowArray (CreateArrayThreeSymbol(ArrayUser));

