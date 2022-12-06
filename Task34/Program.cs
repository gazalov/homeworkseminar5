// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int size = 10;
int leftRange = 100;
int rightRange = 999;
int[] array = new int[size];

int[] CreatRandomArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int CountOfEvenNumbers(int[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
array = CreatRandomArray(size, leftRange, rightRange);
System.Console.WriteLine("Массив, заполненный случайными положительными трехзначными числами:");
System.Console.WriteLine("[" + string.Join(",", array) + "]");

int countEven = CountOfEvenNumbers(array);
System.Console.Write($"Количество четных чисел в массиве: {countEven}");