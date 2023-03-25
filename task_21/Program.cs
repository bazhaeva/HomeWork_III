double X1 = UserCoord("Введите координату х1: ");
double Y1 = UserCoord("Введите координату у1: ");
double Z1 = UserCoord("Введите координату z1: ");
double X2 = UserCoord("Введите координату х2: ");
double Y2 = UserCoord("Введите координату у2: ");
double Z2 = UserCoord("Введите координату z2: ");

double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));

Console.WriteLine($"A({X1}, {Y1}, {Z1}), B({X2}, {Y2},{Z2}) -> {distance})");




//----------------Ввод данных
static double UserCoord(string messageToUser)
{
    Console.Write(messageToUser);
    try
    {
        return double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
