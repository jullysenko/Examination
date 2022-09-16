void FillArray1(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

int FindSize2(string[] arr1)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            j++;
        }
    }
    return j;
}

void FillArray2(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];            
            j++;
        }
    }
}

Console.Write("Укажите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
Console.Write("Заполните массив: ");
FillArray1(array1);

string[] array2 = new string[(FindSize2(array1))];

Console.WriteLine();
FillArray2(array1, array2);
Console.Write(string.Join(" ", array2));