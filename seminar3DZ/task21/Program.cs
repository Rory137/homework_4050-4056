 // Задание 21
 int getInt(){

 return Convert.ToInt32(Console.ReadLine());

 }

 Console.WriteLine("Введите 3 координаты точек A, B :");

 int x1 = getInt();
 int y1 = getInt();
 int z1 = getInt();
 int x2 = getInt();
 int y2 = getInt();
int z2 = getInt();




 double d = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + 
                    Math.Pow((y2-y1), 2) + 
                    Math.Pow((z2-z1), 2)),2);


Console.WriteLine(d);