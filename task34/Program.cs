// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// генерация массива
int[] GetArray(int size, int minEdge, int maxEdge)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minEdge, maxEdge + 1);
    Console.Write("Your new array: ");
    foreach (int i in arr) Console.Write(String.Format(" {0,3}", i));
    Console.Write('\n');
    return arr;
}

// вывод в консоль количества четных
static void CountOfEvens(int[] arr)
{
    int evens = 0; for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) evens++;
    Console.Write("Count of even values equals:   ");
    Console.WriteLine(evens);
}

// назначение 
int size = 6;     // GetNum("Input size array: ");
int minEdge = 100;  // GetNum("Input min edge array: ");
int maxEdge = 999;   // GetNum("Input max edge array: ");

// вызов массива
int[] arr = GetArray(size, minEdge, maxEdge);

// вызовы всех методов для all in one
CountOfEvens(arr);