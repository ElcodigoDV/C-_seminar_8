/* Урок 8. Двумерные массивы. Продолжение

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */

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
            newMatrix[i, j] = 0;//new Random().Next(0, 10);
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

int m = 4;//Num("qty rows");
int n = m; //Num("qty colomns");
int num = 1;

int [,] array = NewMatrix(m, n);

for (int col = 0; col < array.GetLength(1); col++)
{
    array[0, col] = num;
    num++;
}
num--;
for (int row = 0; row < array.GetLength(0); row++)
{
    array[row, array.GetLength(1)-1] = num;
    num++;
}
num--;


ShowResult(array);