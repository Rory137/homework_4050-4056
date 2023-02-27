// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());



int max = a;



if (a > max) max = a;
else if(b > max) max = b;
else if (c > max) max = c;

    
Console.Write("max= " + max);


