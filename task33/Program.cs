// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// метод генерации массива
int[] GetArray(int size, int minEdge, int maxEdge)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minEdge, maxEdge + 1);
    Console.Write("Your new array: ");
    foreach (int i in arr) Console.Write(String.Format(" {0,3}", i));
    Console.Write('\n');
    return arr;
}

// метод нахождения заданного числа в массиве
static void FindVallueArray(int[] arr, int value)
{
    string result = "out of the Array";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value)
        {
            result = "in the Array"; break;
        }
    }
    Console.WriteLine($"Value {value} {result}");
}

// метод инверсии значений массива
// static void InverseArray(int[] arr) 
// {
//     for (int i = 0; i < arr.Length; arr[i] = -arr[i], i++);
//     Console.Write("Inverted array: ");
//     foreach (int i in arr) Console.Write(String.Format(" {0,3}", i));
//     Console.Write('\n');
// }

// метод подсчета суммы плюсов и минусов
// static void SumPMArray(int[] arr)
// {
//     int sumP = 0; int sumM = 0;
//     for (int i = 0; i < arr.Length; i++) 
//     {
//         if (arr[i] > 0) sumP += arr[i];
//         if (arr[i] < 0) sumM += arr[i];
//     }
//     Console.Write($"Summ of pluses:   {sumP}\nSumm of minuses: {sumM}\n");
// }

// получение данных от консоли
// int GetNum(string text)
// {
//     Console.WriteLine(text);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// назначение 
int size = 10;     // GetNum("Input size array: ");
int minEdge = -9;  // GetNum("Input min edge array: ");
int maxEdge = 9;   // GetNum("Input max edge array: ");
int value = 5;     // GetNum("Input value to serch: ");

// вызов массива
int[] arr = GetArray(size, minEdge, maxEdge);

// вызовы всех методов для будущего калькулятора
// InverseArray(arr);
// SumPMArray(arr);
FindVallueArray(arr, value);
