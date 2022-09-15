// Сбор черники
Console.Clear();
Console.Write("Введите кол-во кустов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);

Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");

int[] result_array = new int[n];
for (int i = 1; i < array.Length - 1; i++)
{
    result_array[i - 1] = array[i - 1] + array[i] + array[i + 1];
}
result_array[result_array.Length - 2] = array[array.Length - 1] + array[0] + array[1];
result_array[result_array.Length - 1] = array[0] + array[array.Length - 1] + array[array.Length - 2];
Console.WriteLine("Конечный массив: [" + string.Join(", ", result_array) + "]");

int max_number = result_array[0];
for (int i = 1; i < result_array.Length; i++)
{
    if (max_number < result_array[i])
        max_number = result_array[i];
}
Console.WriteLine(max_number);


