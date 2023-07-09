double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondNumber = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double thirdNumber = double.Parse(Console.ReadLine());
if (firstNumber < secondNumber)
{
   if (secondNumber < thirdNumber)
    {
        Console.Write($"Число { thirdNumber } максимальное");
    }
    else
        Console.Write($"Число { secondNumber } максимальное");
}
else
    if (firstNumber < thirdNumber)
    {
        Console.Write($"Число { thirdNumber } максимальное");
    }
    else
        Console.Write($"Число { firstNumber } максимальное");