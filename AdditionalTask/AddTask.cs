// Set an integer two-dimensional array of dimension n x m.
// Find out in which row the sequence is ascending or descending.

// I use this numbers of columns and rows to make check easier
// Because of using random generation of the array you may have to run the program several times
int rows = 6;
int cols = 3;

// Method for generationg an array
int[,] CreateAndShowArrayRowXCol(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < col; c++)
        {
            array[r, c] = rnd.Next(0, 20);
            Console.Write(array[r, c] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

// Method to find ascending and descending rows
void FindOutAscending(int[,] array)
{
    for (int row = 0; row < array.GetLength(0) - 1; row++)
    {
        bool ascendingFlag = true;
        bool descendingFlag = true;
        for (int col = 0; col < array.GetLength(1) - 1; col++)
        {
            // If current element of the row greater or equal the next one, this row isn't ascending
            if (array[row, col] >= array[row, col + 1]){ascendingFlag = false;}
            // If current element of the row less or equal the next one, this row isn't descending
            if (array[row, col] <= array[row, col + 1]){descendingFlag = false;}
        }
        if (descendingFlag){Console.WriteLine($"Row {row} is descending.");}
        if (ascendingFlag){Console.WriteLine($"Row {row} is ascending.");}
    }
}

int[,] arr = CreateAndShowArrayRowXCol(rows, cols);
FindOutAscending(arr);