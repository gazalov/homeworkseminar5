// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int size = 10;
double leftRange = -100.0;
double rightRange = 100.0;
double[] array = new double[size];

double[] CreatRandomArray(int size, double leftRange, double rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.NextDouble() * (rightRange - leftRange) + leftRange;
    }
    return arr;
}

double DiffMaxMin(double[] arr1)
{
    int maxPos = 0;
    int minPos = 0;

    for (int i = 1; i < arr1.Length; i++)
    {
        if (arr1[i] > arr1[maxPos])
        {
            maxPos = i;
        }
        if (arr1[i] < arr1[minPos])
        {
            minPos = i;
        }
    }
    double diff = arr1[maxPos] - arr1[minPos];
    return diff;
}

array = CreatRandomArray(size, leftRange, rightRange);
System.Console.WriteLine("[" + string.Join(", ", array) + "]");

double diff = DiffMaxMin(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diff}");