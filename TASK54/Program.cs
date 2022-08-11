int m = InputInt("Please, enter the count of lines: ");
int n = InputInt("Please, enter the count of columns: ");
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
DescendingSort(array);
PrintArray(array);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

void DescendingSort(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {

                if (arr[m, j] < arr[m, j + 1])
                {
                    int temp = arr[m, j];
                    arr[m, j] = arr[m, j + 1];
                    arr[m, j + 1] = temp;

                }

            }
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
