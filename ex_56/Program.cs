/* Урок 8. Двумерные массивы. Продолжение

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка
 */
int NumRow(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    int row = index + 1;
    return row;
}

int[] ArraySum(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        arraySum[k] = sum;
        k++;
    }
    
    Console.WriteLine("---------------"); //разделитель
    Console.WriteLine($"{string.Join(", ", arraySum)} суммы по строкам");
    return arraySum;
}

void ShowResult(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] NewMatrix(int row, int col)
{
    int[,] newMatrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newMatrix[i, j] = new Random().Next(0, 10);
        }
    }
    return newMatrix;
}

int Num(string text)
{
    Console.WriteLine(text);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

//задаем массив
int n = Num("введите кол-во строк");
int m = Num("введите кол-во столбцов");
int[,] matrix = NewMatrix(n, m);
//показываем массив
ShowResult(matrix);
//считаем минимум по строке и возвращаем номер строки
int[] arraySum = ArraySum(matrix);
int numRow = NumRow(arraySum);
//показываем номер строки
Console.WriteLine();
Console.WriteLine($"{numRow} строка");
