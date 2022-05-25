//Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int length = array.Length;
int polSum = 0;
int otrSum = 0;
//int a = 0;
Random rnd = new Random();
for (int i = 0; i < length; i++)
	array[i] = rnd.Next(0, 10);
int count = 1;
foreach (int a in array)
{
	Console.WriteLine($"{count} элемент массива - {a}");
	count++;
}
for (int a = 0; a < length; a++)
{
	if (array[a] > 0) polSum += array[a];
	else if (array[a] < 0) otrSum += array[a];
}
Console.WriteLine($"Сумма положительных элементов массива = {polSum}, Сумма отрицательных элементов массива = {otrSum} ");