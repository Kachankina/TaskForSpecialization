string[] array1 = new string[8] {"123", "23", "hello", "world", "res", "lige","hate","variant"};
string[] array2 = new string[array1.Length];

void ShortArray(string[] array1,string[] array2 )
{
    int i = 0;
    for (int j = 0; i < array1.Length; j++)   
    {
        if (array1[j].Length <= 3)
        {
            array2[i] = array1[j];
            i++;
        }

    }
}
void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
ShortArray(array1, array2);
PrintArray(array2);