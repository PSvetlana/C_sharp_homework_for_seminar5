/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

void PrintArray(double[] arrayToPrint) //выводит массив в определенном формате: "[1, 2, ..., n]"
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

double[] CreateRandomArray(int length) //создает массив из рандомных элементов, значения которых < 100
{
    double[] returningArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(100);
    }
    return returningArray;
}

double SearchingMinElement(double[] arrayToSearch) //поиск минимального элемента в массиве
{
    double min = arrayToSearch[0];
    for (int i = 1; i < arrayToSearch.Length; i++)
    {
        if (min > arrayToSearch[i])
        {
            min = arrayToSearch[i];
        }
    }
    return min;
}

double SearchingMaxElement(double[] arrayToSearch) //поиск максимального элемента в массиве
{
    double max = arrayToSearch[0];
    for (int i = 1; i < arrayToSearch.Length; i++)
    {
        if (max < arrayToSearch[i])
        {
            max = arrayToSearch[i];
        }
    }
    return max;
}

double DifferenceMaxMinInArray(double[] arrayToCalculate) //находит разницу между максимальным и минимальным элементов массива
{
    double sum = 0;
    sum = SearchingMaxElement(arrayToCalculate) - SearchingMinElement(arrayToCalculate);
    return sum;
}

Console.Write("Введите число элементов массива: ");
int numberOfItems = Convert.ToInt32(Console.ReadLine());
double[] arrayRandom = CreateRandomArray(numberOfItems);
PrintArray(arrayRandom);
double result = DifferenceMaxMinInArray(arrayRandom);
Console.WriteLine($"Разницу между максимальным и минимальным элементом в данном массиве равна {result}");