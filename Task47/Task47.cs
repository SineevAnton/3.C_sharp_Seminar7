// Create a two-dimensional array, fiiled with real numbers.

int rows = 3;
int cols = 4;

double[,] CreateAndShowArrayRowXCol(int row, int col)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();
    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < col; c++)
        {
            array[r, c] = Math.Round(rnd.Next(-99, 100) * rnd.NextDouble(), 2);
            Console.Write(array[r, c] + "\t");
        }
    Console.WriteLine();
    }
    return array;
}

double[,] arr = CreateAndShowArrayRowXCol(rows, cols);