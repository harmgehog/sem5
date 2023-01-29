// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// генерация массива
int[] GetArray(int size, int minEdge, int maxEdge)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minEdge, maxEdge + 1);
    Console.Write("Your new array is: ");
    foreach (int i in arr) Console.Write(String.Format(" {0,3}", i));
    Console.Write('\n');
    return arr;
}

// вывод в консоль суммы нечетных
static void SumOfOdds(int[] arr)
{
    int odds = 0; for (int i = 0; i < arr.Length; odds += arr[i], i += 2) ;
    Console.Write("Sum of values over odd indices:   ");
    Console.WriteLine(odds);
}

// получение данных от консоли
int GetNum(string text)
{
    Console.WriteLine(text); int num = int.Parse(Console.ReadLine()!); return num;
}

// назначение 
int size = GetNum("Input size array: ");
int minEdge = GetNum("Input min edge array: ");
int maxEdge = GetNum("Input max edge array: ");

// вызов массива
int[] arr = GetArray(size, minEdge, maxEdge);

// вызовы всех методов All_in_One
SumOfOdds(arr);
