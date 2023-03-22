Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Вот наш массив:");
PrintArray(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int b = 0; b < numbers.Length; b++)
{
    if (numbers[b] > max)
        {
            max = numbers[b];
        }
    if (numbers[b] < min)
        {
            min = numbers[b];
        }
}

Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между max  {max} и min {min} значением = {max - min}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] =  Random.Shared.Next(100, 1000) / 10;
        }
}
void PrintArray(int[] numbers)
{
   Console.WriteLine($"[{string.Join(",", numbers)}]");
}   
