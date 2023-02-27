// See https://aka.ms/new-console-template for more information



Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{

Console.Write("Вы ввели число: " + a + " оно является четным");

}
else
{

Console.Write("Вы ввели число: " + a + " оно является нечетным");

}