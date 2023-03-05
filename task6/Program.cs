// See https://aka.ms/new-console-template for more information
Console.Write("Введите 3-рех значное число: ");

int number = Convert.ToInt32(Console.ReadLine());
string secondDigit = Convert.ToString(number);

if(secondDigit.Length > 2)
{

Console.WriteLine("Вы ввели число: " + number + " вторая цифра этого числа: " + secondDigit[2]);

}
else 
{
    Console.Write("Введено не 3-рех значное число");
}