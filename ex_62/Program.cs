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

int m = Num("qty rows");
int n = Num("qty colomns");
int s = 1;

int [,] array = NewMatrix(m, n);

for (int y = 0; y < array.GetLength(1); y++) // -> right
{
    array[0, y] = s;
    s++;
}
Console.WriteLine("right done");
for (int x = 1; x < array.GetLength(0); x++) // | down
{
    array[x, array.GetLength(1)-1] = s;
    s++;
}
Console.WriteLine("down done");

for (int y = array.GetLength(1) - 1-1; y >= 0; y--) // <- left
{
    array[array.GetLength(0) - 1, y] = s;
    s++;
}
Console.WriteLine("left done");
for (int x = array.GetLength(0) - 1 - 1; x > 0; x--) // up
{
    array[x, 0] = s;
    s++;
}
Console.WriteLine("up done");
int c = 1;
int d = 1;

ShowResult(array);

while (s < array.GetLength(0) * array.GetLength(1))
{
    Console.WriteLine($"while {s}");
    while (array[c, d + 1] == 0) // ->
    {
        array[c, d] = s;
        s++;
        d++;
    }

    while (array[c + 1, d] == 0) // down
    {
        array[c, d] = s;
        s++;
        c++;
    }

    while (array[c, d - 1] == 0) // left
    {
        array[c, d] = s;
        s++;
        d--;
    }

    while (array[c - 1, d] == 0) // up
    {
        array[c, d] = s;
        s++;
        c--;
    }
}

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = s;
        }
    }
}

ShowResult(array);