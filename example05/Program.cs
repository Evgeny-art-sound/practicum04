// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
Console.Write("Введите длину массива: ");
int count = int.Parse(Console.ReadLine());
int[] array = new int[count];
int b = 0;
Random rnd = new Random();
for (int i = 0; i < count; i++)
{
	array[i] = rnd.Next(-1000, 1000);
	Console.WriteLine($"{i} элемент массива {array[i]}");
}
while (b < count / 2)
{
	Console.WriteLine($"Произведение пары чисел = {array[b] * array[count - 1 - b]}");
	b++;
}