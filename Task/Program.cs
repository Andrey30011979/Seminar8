int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        for (int j = 0; j < arr.GetLength(1); ++j)
        {
            Console.Write("  " + arr[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();
int[] arrayNew = new int[m * n];

int k = 0;

for (int i = 0; i < array.GetLength(0); ++i)
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        arrayNew[k] = array[i, j];
        ++k;
    }

}
Console.WriteLine(string.Join(" ", arrayNew));

for (int i = 0; i < arrayNew.Length; ++i)
{
    for (int j = i + 1; j < arrayNew.Length; ++j)
    {
        if (arrayNew[i] > arrayNew[j])
        {

            int temp = arrayNew[i];
            arrayNew[i] = arrayNew[j];
            arrayNew[j] = temp;
        }
    }
}
Console.Write(string.Join(" ", arrayNew));
int count = 1;
int el = arrayNew[0];
Console.WriteLine();
for (int i = 1; i < arrayNew.Length; ++i)
{
    if (arrayNew[i] == el)
    {
        count++;
    }
    else
    {
        Console.WriteLine(el + " встречается " + count);
        el = arrayNew[i];
        count = 1;
    }
}
Console.WriteLine(el + " встречается " + count);
