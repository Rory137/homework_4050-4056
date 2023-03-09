
// Задание 19
Console.Write("Введите 5-ти значное число: ");

int number = Convert.ToInt32(Console.ReadLine());

int num0 = number / 10000;
int num1 = number / 1000 % 10;
int num2 = number / 100 % 10;
int num3 = number / 10 % 10;
int num4 = number % 10;


if (number >= 10000 && number < 100000)
{
    if (num0 == num4 && num1 == num3)
    {
        Console.WriteLine($"Вы ввели, {number} ваше число палиндром");
    }
    else
    {
        Console.WriteLine($"Вы ввели, {number} ваше число не палиндром, УВЫ");
    }
}
else
{
    Console.WriteLine($"Вы ввели {number} , это не 5-ти значное число, УВЫ");
}
