// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int IntupNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено не корректное число. Попробуйте еще раз.");
    }
    return number;
}

void SumMin(int[,] matrix)
{
    int i = 0;
    int SumMin = 111000000;  // не додумался как изначально задать значение с чем сравнивать сумму строки, что бы код начал работать , поэтому "волшебное число"
    int minI = 0;
    while (i < matrix.GetLength(0))
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        System.Console.WriteLine($"Сумма элементов на {i + 1} строке: {sum}");

        if (sum < SumMin)
        {
            SumMin = sum;
            minI = i + 1;
        }
        i++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальная сумма элементов на {minI} строке.");
}


int rows = IntupNumber("Введите количество строк 2-мерного массива: ");
int cols = IntupNumber("Введите количество столбцов 2-мерного массива: ");

int[,] matrix = FillMatrix(rows, cols);
PrintMatrix(matrix);
System.Console.WriteLine();

SumMin(matrix);