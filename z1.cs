// Решение задачи на нахождение большей цифры в двузначном числе.

Console.Clear();
int num = new Random().Next(10, 100);
int first = num%10;
int second = num/10;
System.Console.WriteLine(num);
if(first > second)
{
    System.Console.WriteLine(first);
}
else if(first < second)
{
    System.Console.WriteLine(second);
}
else
{
    System.Console.WriteLine("Цифры равны - " + first);
}
