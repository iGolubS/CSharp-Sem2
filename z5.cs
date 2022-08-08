// Решение задачи на проверку является ли вводимые число квадрантом другого введенного числа.

Console.Write("Число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2)
{
    System.Console.WriteLine(number1 + " " + number2 + " -> да");
}
else
{
    System.Console.WriteLine(number1 + " " + number2 + " -> нет");
}
if(number2 == number1 * number1)
{
    System.Console.WriteLine(number2 + " " + number1 + " -> да");
}
else
{
    System.Console.WriteLine(number2 + " " + number1 + " -> нет");
}
