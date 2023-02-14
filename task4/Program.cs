// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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


int[,,] FillMatrix(int x, int y, int z)
{
    Random rand = new Random();
    int[,,] matr = new int[x, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int n = 0; n < z; n++)
            {
                matr[i, j, n] = rand.Next(10, 100);
            }

        }
    }
    return matr;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int n = 0; n < matr.GetLength(2); n++)
            {
                System.Console.Write(matr[i, j, n] + $"({i}, {j}, {n})" + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

int x = IntupNumber("Введите 1 размер 3-мерной матрицы: ");
int y = IntupNumber("Введите 2 размер 3-мерной матрицы: ");
int z = IntupNumber("Введите 3 размер 3-мерной матрицы: ");

int[,,] matrix = FillMatrix(x, y, z);
System.Console.WriteLine();

PrintMatrix(matrix);