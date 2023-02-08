/* Урок 8. Двумерные массивы. Продолжение
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

int[,] RowSort(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        int tmp;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i, k])
                {
                    tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
    return array;
}

void ShowResult (int[,] array)
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

//задаем матрицу
int n = Num("введите кол-во строк");
int m = Num("введите кол-во столбцов");
Console.WriteLine("----------------");
int[,] matrix = NewMatrix(n, m);

//выводим м-цу
ShowResult(matrix);

//сортируем м-цу
RowSort(matrix);
Console.WriteLine("----------------");
// выводим рез-щую м-цу
ShowResult(matrix);