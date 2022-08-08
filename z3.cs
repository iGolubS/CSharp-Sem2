// Решение задачи на нахождение кратности или не кратности двух чисел.

Console.Clear();
Console.Write("Число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 % number2 == 0)
{
    System.Console.WriteLine(number1 + ", " + number2 + " -> " + "кратно" );
}
else
{
    System.Console.WriteLine(number1 + ", " + number2 + " -> " + "не кратно, остаток " + number1 % number2);
}
