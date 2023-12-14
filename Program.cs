Console.Clear();
Console.WriteLine("Ведите строки через пробел:");
string row = Console.ReadLine();

string[] array = row.Split(" ");

string[] result = RowFiltering(array);
Console.WriteLine("Отфильтрованный массив из строк: ");
Console.WriteLine($"[{string.Join(", ", result)}]");

string [] RowFiltering( string [] array)
{
    string[] arr = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string input = array[i];
        if (input.Length <= 3)
        {
            arr[count] = input;
            count++;
        }     
    }
    return arr;
}

