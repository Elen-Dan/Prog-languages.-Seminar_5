/*
Задача 1:
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Clear();

int Start = 100;
int Stop = 999;
int index = 0;
int Sum = 0;

int [] Array = new int[1000];
// Заполнение массива
while(index < Stop)
    {
        Array[index] = new Random().Next(Start, Stop);
        Console.Write(Array[index] + " ");
        if (Array[index] % 2 == 0)
            Sum = Sum + Array[index]; //Находим количество четных чисел в массиве
        index++;
    }
Console.WriteLine("");
Console.WriteLine("Сумма четных чисел массива равна " + Sum);