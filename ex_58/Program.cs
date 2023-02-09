/* Урок 8. Двумерные массивы. Продолжение

Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
int[,] Multiply (int[,] array1, int[,] array2)
{
    int[,] multiplyMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int row = 0; row < array1.GetLength(0); row++)
    {
        for (int col = 0; col < array2.GetLength(1); col++)
        {
           for (int p = 0; p < array2.GetLength(0); p++)
           {
                multiplyMatrix[row, col] += array1[row, p] * array2[p,col];
           }
        }
    }
    return multiplyMatrix;
}

int Num(string text)
{
    Console.WriteLine(text);
    int num = Int32.Parse(Console.ReadLine());
    return num;
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


int n = Num("введите кол-во строк");
int m = Num("введите кол-во столбцов");

 int[,] matrixOne = NewMatrix(n, m);
 int[,] matrixTwo = NewMatrix(n, m);

Console.WriteLine("matrixOne");
Console.WriteLine();
 ShowResult(matrixOne);

Console.WriteLine();
Console.WriteLine("matrixTwo");
ShowResult(matrixTwo);
Console.WriteLine();

int[,] multiMatrix = Multiply(matrixOne, matrixTwo);
Console.WriteLine("Результат произведения");
ShowResult(multiMatrix);
Console.WriteLine();
