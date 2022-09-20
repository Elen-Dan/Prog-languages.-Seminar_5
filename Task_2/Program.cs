/*
Задача 2:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях
 (позиция - индекс элемента в массиве).

[3, 7, 23, 12] -> 12
[4, 6, 8, 1, 4] -> 6
*/

Console.Clear();

int Start = 0;
int Stop = 10;
int index = 0;
int Sum = 0;

int [] Array = new int[11];
// Заполнение массива
while(index < Array.Length)
    {
        Array[index] = new Random().Next(Start, Stop);
        Console.Write(Array[index] + " ");
        if (index % 2 !=0 & Array[index] % 2 == 0) //проверка условия задачи
            {
                Sum = Sum + Array[index];
            } 
        index++;
    }
Console.WriteLine("");
Console.WriteLine("Cумма четных элементов, стоящих на нечётных позициях равна " + Sum);

