int numberN = UserNumber("Введите пятизначное число: ");
MethodPalindrome(numberN);

//--------------------------------Методы----------------------------------
//----------------------------Палиндром
void MethodPalindrome(int Number)
{
    int i = 0;
string resDescription = String.Empty;     
int countN = (int)Math.Log10(numberN) + 1;

while(i<countN/2)
{
    if((numberN/(int)Math.Pow(10, i))%10 == (numberN/(int)Math.Pow(10, countN-1-i))%10)
    {
        i=i+1;
        resDescription = "Да";
    }
    else
    {
        resDescription = "Нет";
        break;
    }
}
Console.Write($"{numberN} -> {resDescription}");
}



//----------------Ввод данных
static int UserNumber(string messageToUser)
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
