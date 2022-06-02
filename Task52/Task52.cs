// Specify a two-dimensional array of integers.
// Find the arithmetic mean of the elements in each
// column.

int rows = 3;
int cols = 4;

int[,] CreateAndShowArrayRowXCol(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < col; c++)
        {
            array[r, c] = rnd.Next(0, 6);
            Console.Write(array[r, c] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void FindMeanInColumns(int[,] array)
{
    Console.Write("Arithmetic mean of the elements in each column: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summa = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summa += array[j, i];
        }
        Console.Write(Math.Round(summa / array.GetLength(0), 2) + ", ");
    }
}

int[,] arr = CreateAndShowArrayRowXCol(rows, cols);
FindMeanInColumns(arr);