// See https://aka.ms/new-console-template for more information
Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= N)
{

  Console.Write(current + " ");
  current = current + 2;

}
