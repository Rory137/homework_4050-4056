
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());



int max = a;
int min =a;



if (a > max) max = a;
else if (b > max) max = b;
else if (a < min) min = a;
else if (b < min) min = b;


Console.Write("max= " + max );
Console.Write(", min= " + min);