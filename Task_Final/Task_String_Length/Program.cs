void FillArray1(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

int FindSize2(string[] arr1)
{
    int p = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            p++;
        }
    }
    return p;
}

void FillArray2(string[] arr1, string[] arr2)
{
    int p = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[p] = arr1[i];            
            p++;
        }
    }
}

Console.Write("Укажите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayF = new string[size];
Console.Write("Заполните массив: ");
FillArray1(arrayF);

string[] arrayS = new string[(FindSize2(arrayF))];

Console.WriteLine();
FillArray2(arrayF, arrayS);
Console.Write(string.Join(" ", arrayS));