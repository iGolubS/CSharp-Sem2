// Решение задачи на удаление второй цифры из трехзначного числа.

Console.Clear();
int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);
int first = num / 100;
int second = num % 10;
System.Console.WriteLine(first + "" + second);