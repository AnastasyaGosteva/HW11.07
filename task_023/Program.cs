void Square(int value)
{
    for (int i = 1; i <= value; i++ )
    {
        int cub = (int) Math.Pow(i, 3);
        Console.WriteLine(cub);
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int value = GetInput("Введите число: ");
Square(value); 