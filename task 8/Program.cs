// See https://aka.ms/new-console-template for more information


Console.Write("Введите цифру обозначающию день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


if(dayNumber == 6 || dayNumber == 7)
{

Console.Write("Наконец-то выходной");

}
else if (dayNumber >= 1 && dayNumber <= 5)
{

Console.Write("Этот день не выходной");

}
else 
{
Console.Write("Это вообще не день недели");
}