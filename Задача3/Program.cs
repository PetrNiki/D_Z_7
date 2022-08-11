// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

void GetArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          array[i, j] = new Random().Next(1, 20);
       }
   }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    
}
string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + " ";
    }
    return result;
}
int m = 5;
int n = 2;
int[,] array = new int[m, n];

GetArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));

