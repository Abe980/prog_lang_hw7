// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

Console.WriteLine("Задача 47");

PrintDouble2dMatrix(GetDoubleMatrix(3, 4));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

double[,] GetDoubleMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(-99, 100) / 10.0;
        }
    }

    return matrix;
}


void PrintDouble2dMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}




// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

Console.WriteLine("Задача 50");
Console.Write("Введите индексы элемента через пробел: ");
string indexStr = Console.ReadLine();


int[,] originalMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(originalMatrix);
PrintElement(originalMatrix, GetIndex(indexStr));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }

    return matrix;
}


int[] GetIndex(string indexString)
{
    string[] index = indexString.Split(" ");
    int[] indexNum = new int[index.Length];
    for (int i = 0; i < index.Length; i++)
    {
        indexNum[i] = Convert.ToInt32(index[i]);
    }
    return indexNum;
}


void PrintElement(int[,] matrix, int[] elem)
{
    if (elem[0] < matrix.GetLength(0) && elem[1] < matrix.GetLength(1))
    {
        Console.WriteLine($"Искомый элемент: {matrix[elem[0], elem[1]]}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

Console.WriteLine("Задача 52");

int[,] newMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine(String.Join("; ", ArithmeticMeanCols(newMatrix)));

double[] ArithmeticMeanCols(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result[j] = result[j] + matrix[i, j];
        }
        result[j] = Math.Round(Convert.ToDouble(result[j]) / matrix.GetLength(0), 1);
    }
    return result;
}

