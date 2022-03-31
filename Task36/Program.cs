/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int[] CreateRandomArray(int length) //создает массив из рандомных элементов в диапазоне от [-100; 100]
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(-100, 101);
    }
    return returningArray;
}

int SearchingSumOfElementsInArray(int[] arrayToSearch) //находит сумму элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 1; i < arrayToSearch.Length; i += 2)
    {
        sum += arrayToSearch[i];
    }
    return sum;
}

Console.Write("Введите число элементов массива: ");
int numberOfItems = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = CreateRandomArray(numberOfItems);
PrintArray(arrayRandom);
int result = SearchingSumOfElementsInArray(arrayRandom);
Console.WriteLine($"В данном массиве сумма элементов, стоящих на нечётных позициях, равна {result}");