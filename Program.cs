string [] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string [] array2 = new string[array1.Length];

 void ShortArray(string[] array1,string[] array2 )
{
    int i = 0;
    int a = 3;
    for (int j = 0; j < array1.Length; j++)   
    {
        if (array1[j].Length >= a)
        {
            array1[j] = array2[i];
            i++;
        }
       else
        {
            j++;
       }
    }
 
}
void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array1[j]}");
    }
    Console.WriteLine();
}
ShortArray(array1,array2);
PrintArray(array2);