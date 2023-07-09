Console.Write("Введите первое число: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondNumber = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double thirdNumber = double.Parse(Console.ReadLine());
double max = firstNumber;
if (firstNumber < secondNumber)
    max = secondNumber;
    if (secondNumber < thirdNumber)
        max = thirdNumber;

Console.Write($"Число { max } максимальное");