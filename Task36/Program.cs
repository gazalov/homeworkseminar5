// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int size = 10;
int leftRange = -9;
int rightRange = 9;
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

int SumOfUnevenPosition(int[] arr)
{
    int sumUneven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumUneven = sumUneven + arr[i];
        }
    }
    return sumUneven;
}

array=CreatRandomArray(size, leftRange, rightRange);
System.Console.WriteLine("Ождномерный массив, заполненный случайными числами: ");
System.Console.WriteLine("[" + string.Join(", ", array) + "]");

int sumUnevenPosition = SumOfUnevenPosition(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sumUnevenPosition}.");
