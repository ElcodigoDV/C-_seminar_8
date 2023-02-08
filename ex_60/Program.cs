/* Урок 8. Двумерные массивы. Продолжение

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */

void ShowResult(int[,,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[y, x, z]}\t");
            }
        }    
    Console.WriteLine();
    }
}

int[,,] New3dArray(int height, int width, int depth)
{
    int[,,] array3d = new int[height, width, depth];

    for (int y = 0; y < array3d.GetLength(0); y++)
    {
        for (int x = 0; x < array3d.GetLength(1); x++)
        {
            for (int z = 0; z < array3d.GetLength(2); z++)
            {
                array3d[y, x, z] = new Random().Next(10,100);
            }
        }
    }
    return array3d;
}

int Num(string text)
{
    Console.WriteLine(text);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

 // создаем трехмерный массив
int x = Num("Ширина");
int y = Num("Высота");
int z = Num("Глубина");
 int[,,] array3d = New3dArray(x, y, z);
//  ф-я создания
 //заполняем массив:
//1.формируем одномерный массив размером № х № х №
//генерируем число
//проверяем поиском есть ли число в нем
// числа нет - добавляем в массив и заполняем ячейку
// идем к след. ячейке
 //
ShowResult(array3d);