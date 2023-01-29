// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// задача противоречит примеру

// генерация массива
double[] GetArray(int size, int minEdge, int maxEdge)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() + Convert.ToDouble(new Random().Next(minEdge, maxEdge + 1));
    }
    Console.Write("Your new array: ");
    foreach (double i in arr) Console.Write(String.Format(" {0}", Math.Round(i, 2)));
    Console.Write('\n');
    return arr;
}

// вывод в консоль max & min
static void MaxMinDiff(double[] arr)
{
    // Console.Write($"Max is: {arr.Max()} Min is: {arr.Min()} "); 
    double max = arr[0]; double min = arr[0];
    foreach (double a in arr) if (a > max) max = Math.Round(a, 2); else if (a < min) min = Math.Round(a, 2);
    Console.Write($"The diff between '{max}' and '{min}' is: '{max - min}' ");
}

// назначение переменных
int size = 13;     // GetNum("Input size array: ");
int minEdge = -100;  // GetNum("Input min edge array: ");
int maxEdge = 100;   // GetNum("Input max edge array: ");

// вызов массива
double[] arr = GetArray(size, minEdge, maxEdge);

// вызовы всех методов для 
MaxMinDiff(arr);