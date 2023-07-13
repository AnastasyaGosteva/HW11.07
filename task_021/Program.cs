void Distance( double x1, double y1, double z1, double x2, double y2, double z2)
{
  double xAB = Math.Pow((x2 - x1), 2);
  double yAB = Math.Pow((y2 - y1), 2);
  double zAB = Math.Pow((z2 - z1), 2);
  double AB = Math.Sqrt(xAB + yAB + zAB);
  Console.Write(Math.Round(AB, 3));
}

double GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double x1 = GetInput("Введите координаты х1: ");
double y1 = GetInput("Введите координаты y1: ");
double z1 = GetInput("Введите координаты z1: ");
double x2 = GetInput("Введите координаты x2: ");
double y2 = GetInput("Введите координаты y2: ");
double z2 = GetInput("Введите координаты z2: ");
Distance(x1, y1, z1, x2, y2, z2);