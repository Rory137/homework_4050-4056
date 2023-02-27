// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());



int max = a;


if (a != b | b != c)
{
if (a > max) 
{ 
max = a;
}
if (b > max) 
{
max = b;
}
if (c > max) 
{
max = c;
}
Console.Write("Самое большое число: " + max);
}
else Console.Write("Числа равны");


