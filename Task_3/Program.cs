/*
Задача 3*:
Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();

int Start = 1;
int Stop = 10;
int index = 0;

int [] Array = new int[11];
// 
while(index < Array.Length)
    {   
        Array[index] = new Random().Next(Start, Stop);
        Console.Write(Array[index] + " ");
        index++;
    }

int Min = Array[0];
for (int i = 0; i < Array.Length; i++)    
{
    if (Array[i] < Min)
        Min = Array[i];
}

int Max = Array[0];
for (int j = 0; j < Array.Length; j++)
{
    if (Array[j] > Max)
        Max = Array[j];
}

Console.WriteLine("");
Console.WriteLine("Разница между максимальным и минимальным значением равна " + (Max - Min));
Console.WriteLine("Min= " + Min);
Console.WriteLine("Max= " + Max);
