int m = InputInt("Please, enter the count of lines: ");
int n = InputInt("Please, enter the count of columns: ");
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[m, n];
FillArray(firstMatrix);
FillArray(secondMatrix);
PrintArray(firstMatrix);
PrintArray(secondMatrix);
Console.WriteLine("Multiply result here!");
PrintArray(MultiplyMatrixes(firstMatrix, secondMatrix));
int[,] MultiplyMatrixes(int[,] a, int[,] b)
{
    int[,] multiMatrix = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            {
                multiMatrix[i, j] += a[i, j] * b[i, j];
            }
        }
    }
    return multiMatrix;
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}