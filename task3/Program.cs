// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int[,] MatrixMulti(int[,] matrix1, int[,] matrix2, int rows, int cols)
{
    int[,] matrMulti = new int[rows, cols];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
                            for (int y = 0; y < matrix1.GetLength(1); y++)
                {
                    matrMulti[i,j] += matrix1[i,y]*matrix2[y,j];
                }
        }
    }
    return matrMulti;
}

int rows = IntupNumber("Введите количество строк матрицы: ");
int cols = IntupNumber("Введите количество столбцов матрицы: ");

System.Console.WriteLine("Первая матрица: ");
int[,] matrix = FillMatrix(rows, cols);
PrintMatrix(matrix);
System.Console.WriteLine();

System.Console.WriteLine("Вторая матрица: ");
int[,] matrix2 = FillMatrix(rows, cols);
PrintMatrix(matrix2);
System.Console.WriteLine();

System.Console.WriteLine("Результат умножения матриц: ");
int[,] matrixMulti = MatrixMulti(matrix, matrix2, rows, cols);
PrintMatrix(matrixMulti);

