int n = InputInt("Please, enter the count of lines(ONLY FOUR ;) : ");
int[,] matrix = new int[n, n];
PrintArray(matrix);

int number = 1;
for (int i = 0; i < n; i++, number++)
{
    matrix[0, i] = number;
}
for (int i = 1; i < n; i++, number++)
{
    matrix[i, 3] = number;
}
for (int i = n - 2; i >= 0; i--, number++)
{
    matrix[3, i] = number;
}
for (int i = n - 2; i > 0; i--, number++)
{
    matrix[i, 0] = number;
}
//==============(Второй Цикл!)================//
for (int i = 1; i < n - 1; i++, number++)
{
    matrix[1, i] = number;
}
for (int i = 2; i < n - 1; i++, number++)
{
    matrix[i, 2] = number;
}
for (int i = n - 3; i > 0; i--, number++)
{
    matrix[2, i] = number;
}

PrintArray(matrix);
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