// See https://aka.ms/new-console-template for more information
Console.Write("Введите 3-рех значное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number / 10 % 10;


if(number >= 100 && number < 1000)
{

Console.WriteLine("Вы ввели число: " + number + " вторая цифра этого числа: " + secondDigit);

}
else 
{
    Console.Write("Введено не 3-рех значное число");
}