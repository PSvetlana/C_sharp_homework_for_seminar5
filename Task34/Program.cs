/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void PrintArray(int[] arrayToPrint) //выводит массив в определенном формате: "[1, 2, ..., n]"
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] CreateRandomArray(int length) //создает массив из рандомных элементов в диапазоне от [100; 999]
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(100, 1000);
    }
    return returningArray;
}

int SearchingEvenNumbersInArray(int[] arrayToSearch) //определяет количество четных элементов в массиве
{
    int count = 0;
    for (int i = 0; i < arrayToSearch.Length; i++)
    {
        if (arrayToSearch[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите число элементов массива: ");
int numberOfItems = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = CreateRandomArray(numberOfItems);
PrintArray(arrayRandom);
int result = SearchingEvenNumbersInArray(arrayRandom);
Console.WriteLine($"В данном массиве количество четных чисел равно {result}");
