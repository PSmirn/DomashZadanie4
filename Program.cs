void FillArray(int[] array)
{
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 999);
    }
}
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Zadacha34()
{
    int size = new Random().Next(4, 10);
    int[] array = new int[size];
    int kolichestvo = 0;
    FillArray(array);
    PrintArray(array);
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)  kolichestvo ++;
    }
    Console.Write("Количество четных чисел: " + kolichestvo);
}
void Zadacha36()
{
    int size = new Random().Next(3, 5);
    int[] array = new int[size]; 
    int summa = 0;
    FillArray(array);
    PrintArray(array);
    for (int i = 1; i < size; i+=2)
    {
        summa += array[i];
    }
    Console.WriteLine("Сумма: " + summa);
}
void Zadacha38()
{
    int size = new Random().Next(4, 6);
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < size; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        else if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("Минимальное число: " + min);
    Console.WriteLine("Разница чисел: "  + (max - min));
    }
Zadacha38();