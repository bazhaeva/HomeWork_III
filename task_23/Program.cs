int N = UserCoord("Введите число N: ");
MethodCube(N);

//---------------------------------------Методы---------------------
//-------------Таблица кубов
void MethodCube(int Number)
{
    if(Number<0) 
    {
        //Number=Number*(-1);
        for(int i = -1; i>= Number; i--)
        {
        Console.WriteLine($"{i}^3 = {i*i*i}");
        }
    }
    
    for(int i = 1; i<= Number; i++)
    {
    Console.WriteLine($"{i}^3 = {i*i*i}");
    }
}

//----------------Ввод данных
static int UserCoord(string messageToUser)
{
    Console.Write(messageToUser);
    try
    {
        return int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
