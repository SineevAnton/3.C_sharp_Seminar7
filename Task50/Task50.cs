// Write a program that takes the positions of an element
// in a two-dimensional array as input, and
// returns the value of this element or an indication
// that there is no such element.

Console.WriteLine("Enter number of row and column of element, you want to get.");
Console.WriteLine("Example: entering 17 means that you want to get element from");
Console.WriteLine("row 1 and column 7");

int choice = int.Parse(Console.ReadLine());
int rowChoice = choice / 10;
int colChoice = choice % 10;

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
            array[r, c] = rnd.Next(-99, 100);
            Console.Write(array[r, c] + "\t");
        }
    Console.WriteLine();
    }
    return array;
}

int[,] arr = CreateAndShowArrayRowXCol(rows, cols);

if (rowChoice > rows - 1 || colChoice > cols - 1) {Console.WriteLine("Array doesn't contain this element");}
else{Console.WriteLine(arr[rowChoice, colChoice]);}