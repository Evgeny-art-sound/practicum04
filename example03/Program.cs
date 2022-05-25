// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Write("Задайте длину массива: ");
int count = int.Parse(Console.ReadLine());
int[] array = new int[count];
int chet = 0;
int nechet = 0;
int length = array.Length;
Random rnd = new Random();
for (int i = 0; i < length; i++) 
{
	array[i] = (int)rnd.Next(100, 999);
	if (array[i] % 2 == 0) chet++;
	else nechet++;
}
Console.WriteLine($"В массиве из {count} элементов  четных чисел = {chet}, нечетных чисел = {nechet} ");