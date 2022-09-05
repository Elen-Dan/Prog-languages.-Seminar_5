/*
Задача 3*:
Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();

int Start = 1;
int Stop = 999;
int Min = 0;
int Max = 0;
int index = 0;
int Difference = 0;

int [] Array = new int[1000];
// Заполнение массива
while(index < Stop)
    {
        Array[index] = new Random().Next(Start, Stop);
        Console.Write(Array[index] + " ");
        if (Array[index] < Array[index+1])
            Min = Array[index]; //Находим минимальное значение
        else 
            Max = Array[index];
        index++;
        Difference = Max - Min;
    }
Console.WriteLine("");
Console.WriteLine("Разница между максимальным и минимальным значением равна " + Difference);
Console.WriteLine("Min= " + Min);
Console.WriteLine("Max= " + Max);
