// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] array = new int[123];
int count = 0;
Random rnd = new Random();
for (int i = 0; i < 123; i++)
	{
	array[i] = rnd.Next(-1000, 1000);
	Console.Write($"{array[i]}, ");
   if ( array[i] > 9 && array[i] < 100)
		count++;
	}
Console.WriteLine($"\nКоличество элементов массива в диапазоне от 10 до 99 = {count}");