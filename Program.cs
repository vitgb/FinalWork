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

void ShowArray (string[] Array1)

{
    for(int i = 0; i < Array1.Length; i++)
        
        Console.Write("[" + Array1[i] + "]" + " " );

    Console.WriteLine();
}

Console.Write("Enter the number of words: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] ArrayUser = CreateArray1 (n);
ShowArray (ArrayUser);
