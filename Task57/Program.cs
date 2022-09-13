// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

/*void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] mass = new int[4, 4];

FillArray(mass);
Print(mass);

// Поиск частоты встречаемости конкретного элемента массива
// int count = 0;
// int a = 2;

//for (int i = 0; i < mass.GetLength(0); i++)
//{
//    for (int j = 0; j < mass.GetLength(1); j++)
//    {
//        if (mass[i, j] == a)
//        {
//            count++;
//        }
//    }
//} 

Console.WriteLine();

int[] massive = new int[mass.Length];
int[] elcount = new int[massive.Length];

int index = 0;

// Перевод двумерного массива в одномерный
//for (int i = 0; i < mass.GetLength(0); i++)
//{
//    for (int j = 0; j < mass.GetLength(1); j++)
//    {
//        massive[index] = mass[i,j];
//        index++;
//    }
//} 

bool exist = false;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        exist = false;
        for (int l = 0; l < index; l++)
        {
            if (massive[l] == mass[i, j])
            {
                exist = true;
                elcount[l]++;
                break;
            }
        }
        if (!exist)
        {
            massive[index] = mass[i, j];
            elcount[index] = 1;
            index++;
        }
    }
}

for (int i = 0; i < index; i++)
{
    Console.WriteLine(massive[i] + " встречается " + elcount[i] + " раз(а)");
}
*/

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