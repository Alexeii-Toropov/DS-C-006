Console.Write("Введите кол-во элементов в массиве: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
    {
        count += 1;
    }
}
Console.WriteLine("Кол-во чисел в массиве > 0 =  " + count);