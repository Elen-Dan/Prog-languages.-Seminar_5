/*
Задача 2:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях
 (позиция - индекс элемента в массиве).

[3, 7, 23, 12] -> 12
[4, 6, 8, 1, 4] -> 6
*/

Console.Clear();

int Start = 0;
int Stop = 999;
int index = 0;
int Sum = 0;

int [] Array = new int[1000];
// Заполнение массива
while(index <= Stop)
    {
        Array[index] = new Random().Next(Start, Stop);
        Console.Write(Array[index] + " ");
        if (Array[index] % 2 == 0 & index % 2 !=0)
            Sum = Sum + Array[index]; //Находим количество четных элементов в массиве
        index++;
    }
Console.WriteLine("");
Console.WriteLine("Cумма четных элементов, стоящих на нечётных позициях равна " + Sum);

