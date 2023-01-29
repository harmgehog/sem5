// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма отрицательных равна -20.

// метод генерирации массива
int[] GetArray(int size, int minEdge, int maxEdge)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minEdge, maxEdge + 1);
    return arr;
}

// метод подсчета суммы плюсов и минусов
static void GetSumPM(int[] arr)
{
    int sumP = 0; int sumM = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > 0) sumP += arr[i];
        if (arr[i] < 0) sumM += arr[i];
    }
    Console.Write($"Summ of pluses: {sumP} \n Summ of minuses: {sumM}");
}

// получение данных от консоли
int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// назначение переменных
int size = GetNum("Input size array: ");
int minEdge = GetNum("Input min edge array: ");
int maxEdge = GetNum("Input max edge array: ");

// вызов метода массива
int[] arr = GetArray(size, minEdge, maxEdge);
Console.Write(string.Join(" ", arr));
Console.WriteLine("");

// вызов нахождения сумм
GetSumPM(arr);