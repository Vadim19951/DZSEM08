int m = InputInt("Please, enter the count of lines: ");
int n = InputInt("Please, enter the count of columns: ");
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
int min = GetFirstSum(array);

int minLineIndex = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < min)
    {
        min = sum;
        minLineIndex = i;
    }
}
Console.WriteLine($"The Line, that has minimal sum = {min} has index {minLineIndex}");
int GetFirstSum(int[,] arr)
{
    int i = 0;
    int sum = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];

    }
    return sum;
}
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