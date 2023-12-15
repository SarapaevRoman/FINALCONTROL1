Console.Clear();
Console.WriteLine("Ведите строки через пробел:");
string row = Console.ReadLine();

string[] array = row.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

string[] result = RowFiltering(array);
PrintArray(result);
void PrintArray(string[] result)
{
    Console.WriteLine("Отфильтрованный массив из строк: ");
    Console.Write("[");
    for (int i = 0; i< result.Length; i++)
    {
       Console.Write($"\"{result[i]}\"");
       if (i < result.Length - 1)
       {
        Console.Write(", ");
       }

    }
    Console.Write("]");

}

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

