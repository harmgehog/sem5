// Задача 35: Создайте массив и отсортируйте его.

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

// сортировка массива
static void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++) if (arr[j] < arr[min]) min = j;
        (arr[i], arr[min]) = (arr[min], arr[i]);
    }
    Console.Write("A sorted array: ");
    foreach (int i in arr) Console.Write(String.Format(" {0,3}", i));
    Console.Write('\n');
}
// перемножение крайних пар к центру
static void MultEdges(int[] arr)
{
    int size = arr.Length-1;
    bool flag = size % 2 == 0;
    Console.Write("Products of ev: ");
    for (int i = 0; i < size; i++, size--) Console.Write(String.Format(" {0,4}", arr[i] * arr[size]));
    if (flag) Console.WriteLine(String.Format(" {0,4}", arr[arr.Length/2+1]));
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
static void InverseNumsArray(int[] arr)
{
    for (int i = 0; i < arr.Length; arr[i] = -arr[i], i++) ;
    Console.Write("Inverted value: ");
    foreach (int i in arr) Console.Write(String.Format(" {0,3}", i));
    Console.Write('\n');
}

// метод подсчета суммы плюсов и минусов
static void SumPMArray(int[] arr)
{
    int sumP = 0; int sumM = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumP += arr[i];
        if (arr[i] < 0) sumM += arr[i];
    }
    Console.Write($"Summ of pluses:   {sumP}\nSumm o'minuses: {sumM}\n");
}

// получение данных от консоли
// int GetNum(string text)
// {
//     Console.WriteLine(text);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// назначение 
int size = 11;     // GetNum("Input size array: ");
int minEdge = -9;  // GetNum("Input min edge array: ");
int maxEdge = 9;   // GetNum("Input max edge array: ");
int value = 5;     // GetNum("Input value to serch: ");

// вызов массива
int[] arr = GetArray(size, minEdge, maxEdge);

// вызовы всех методов для будущего калькулятора
InverseNumsArray(arr);
SumPMArray(arr);
SortArray(arr);
MultEdges(arr);
FindVallueArray(arr, value);
