namespace Assignment5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Use recursion function to print digits of number --
            PrintdigitProg();

            // -- Get the sum of right diagonal of matrix --
            SumOfRightDiagonalsProg();

            Console.ReadKey();
        }


        static void PrintdigitProg()
        {
            Console.WriteLine("\n-- Use recursion function to print digits of number --\n");
            int num = GetInt();
            Console.Write($"The digits in the number {num} are: ");
            PrintDigit_Recursion(num);
            Console.WriteLine();
        }
        static void SumOfRightDiagonalsProg()
        {
            Console.WriteLine("\n-- Get the sum of right diagonal of matrix --\n");
            int [,] matrix = InitializeTwoDArray();
            Print2DArray(matrix);
            Console.WriteLine($"\nAddition of the right Diagonal elements is : {SumOfRightDiagonals(matrix)}");
        }
        static int SumOfRightDiagonals(int[,] matrix)
        {
            if (matrix == null) return -1;
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        sum += matrix[i, j];
                }
            }
            return sum;
        }
        static void PrintDigit_Recursion(int num)
        {
            if (num < 10)
            {
                Console.Write(num + " ");
                return;
            }
            else
            {
                PrintDigit_Recursion(num / 10);
                Console.Write(num % 10 + " ");
            }
        }
        static int GetInt()
        {
            bool isValid;
            int num;
        getNumber:
            Console.Write($"Enter a number: ");
            isValid = int.TryParse(Console.ReadLine(), out num);
            if (!isValid || num < 1)
            {
                Console.WriteLine("\nError! Enter valid integer!\n");
                goto getNumber;
            }
            return num;
        }
        static int[,] InitializeTwoDArray()
        {
            int row, col;
            int[,] matrix;

            GetUserRowAndCol(out row, out col);
            matrix = new int[row, col];
            InputMatrix(matrix);
            return matrix;
        }
        static void InputMatrix(int[,] matrix)
        {
            bool isValid;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                getVal:
                    Console.Write($"Enter number in matrix[{i}][{j}]: ");
                    isValid = int.TryParse(Console.ReadLine(), out matrix[i, j]);
                    if (!isValid)
                    {
                        Console.WriteLine("\nError! Enter a valid integer!\n");
                        goto getVal;
                    }
                }
            }
        }
        static void GetUserRowAndCol(out int row, out int col)
        {
            bool isValid;
        getRow:
            Console.Write("Enter number of rows: ");
            isValid = int.TryParse(Console.ReadLine(), out row);
            if (!isValid || row == 0)
            {
                Console.WriteLine("\nError! Enter a valid integer!\n");
                goto getRow;
            }

        getCol:
            Console.Write("Enter number of columes: ");
            isValid = int.TryParse(Console.ReadLine(), out col);
            if (!isValid || col == 0)
            {
                Console.WriteLine("\nError! Enter a valid integer!\n");
                goto getCol;
            }
        }
        static void Print2DArray(int[,] matrix)
        {
            if (matrix == null) return;
            Console.WriteLine("\nMatrix:");
            for (int i = 0;i < matrix.GetLength(0);i++)
            {
                Console.Write("[");
                for (int j = 0;j < matrix.GetLength(1);j++)
                {
                    Console.Write(matrix[i,j] + ", ");
                }
                Console.WriteLine("\b\b]");
            }
        }
    }
}
