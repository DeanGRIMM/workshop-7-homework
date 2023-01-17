// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,cols ];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите искомое число");
int N = Convert.ToInt32(Console.ReadLine());
Search(array);

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,11);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
    }
}
void Search(int[,] array)
{
    int flag = 0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j] == N) 
            {
                flag = 1;
                Console.WriteLine($"искомое число в строке {i} и в столбце {j}");
                break;
            }
        }
        if (flag == 1)
        {
            break;
        }
    }
        if (flag == 0) Console.WriteLine("такого числа в массиве нет");
}