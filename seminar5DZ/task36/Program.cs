Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Вот наш массив:");
PrintArray(numbers);
int sum = 0;

for (int v = 0; v < numbers.Length; v+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Shared.Next(1, 10);
        }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine($"[{string.Join(",", numbers)}]");
}